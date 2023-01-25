using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MyKitchenVault
{
    public class DB_Interface
    {
        static string user_admin_cs = System.Configuration.ConfigurationManager.ConnectionStrings["User_Admin_CS"].ConnectionString;
        static string user_cs = System.Configuration.ConfigurationManager.ConnectionStrings["User_CS"].ConnectionString;
        

        /*********
         * LOGIN *
         *********/

        public static string GenerateHash(string password, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
            SHA256Managed SHAM = new SHA256Managed();
            byte[] hash = SHAM.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
        
        public static (string, int, LoginStatus) CheckLogin(string username, string password)
        {
            using (SqlConnection c = new SqlConnection(user_admin_cs))
            {
                SqlCommand command = new SqlCommand("EXEC check_login @username = @name", c);
                command.Parameters.AddWithValue("@name", username);

                c.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        int user_id = reader.GetInt32(0);
                        string user_name = reader.GetString(1);
                        string passHash = reader.GetString(2);
                        string salt = reader.GetString(3);

                        if(GenerateHash(password, salt) == passHash)
                        {
                            return (user_name, user_id, LoginStatus.OK);
                        }
                        else
                        {
                            return ("ERROR", 0, LoginStatus.Incorrect);
                        }
                    }
                }
            }
            return ("ERROR", 0, LoginStatus.NotExist);
        }

        public static bool CheckUserExists(string username)
        {
            bool result;
            using (SqlConnection c = new SqlConnection(user_admin_cs))
            {
                SqlCommand command = new SqlCommand($"EXEC check_login @username = @name", c);
                command.Parameters.AddWithValue("@name", username);
                c.Open();
                SqlDataReader reader = command.ExecuteReader();
                result = reader.HasRows;
                reader.Close();
                c.Close();
            }
            return result;
        }

        public static bool CreateUser(string username, string password)
        {
            if (!CheckUserExists(username))
            {
                using (SqlConnection c = new SqlConnection(user_admin_cs))
                {
                    Random rand = new Random();
                    string salt = rand.Next(1000, 10000).ToString();
                    string passHash = GenerateHash(password, salt);
                    SqlCommand command = new SqlCommand("EXEC add_user @username = @u, @passhash = @p, @salt = @s", c);
                    command.Parameters.AddWithValue("@u", username);
                    command.Parameters.AddWithValue("@p", passHash);
                    command.Parameters.AddWithValue("@s", salt);
                    c.Open();
                    command.ExecuteNonQuery();
                }
            }
            return CheckUserExists(username);
        }

        /**************
         * ADD RECIPE *
         **************/

        public static void AddRecipe(Recipe input)
        {
            using (SqlConnection c = new SqlConnection(user_cs))
            {
                SqlCommand command = new SqlCommand("EXEC add_full_recipe " +
                                                    "@recipeName= @iName, " +
                                                    "@recipeDescription= @iDescription, " +
                                                    "@recipeInstructions= @iInstructions, " +
                                                    "@recipePrepTime= @iPrepTime, " +
                                                    "@recipeCookTime= @iCookTime, " +
                                                    "@userID= @iUserID, " +
                                                    "@Tags= @iTags, " +
                                                    "@Ingredients= @iIngredients", c);

                command.Parameters.AddWithValue("@iName", input.Name);
                command.Parameters.AddWithValue("@iDescription", input.Description);
                command.Parameters.AddWithValue("@iInstructions", input.Instructions);
                command.Parameters.AddWithValue("@iPrepTime", input.PrepTime);
                command.Parameters.AddWithValue("@iCookTime", input.CookTime);
                command.Parameters.AddWithValue("@iUserID", Mkv_Main.user.GetUsername());

                SqlParameter tagList = new SqlParameter("@iTags", SqlDbType.Structured)
                {
                    TypeName = "dbo.TagTableType",
                    Value = input.GetTags()
                };
                command.Parameters.Add(tagList);

                SqlParameter ingList = new SqlParameter("@iIngredients", SqlDbType.Structured)
                {
                    TypeName = "dbo.IngredientTableType",
                    Value = input.GetIngredients()
                };
                command.Parameters.Add(ingList);

                c.Open();
                command.ExecuteNonQuery();
                c.Close();
            }
        }

        /**********
         * SEARCH *
         **********/

        public static List<(string, string, int)> Search(string search = null, string includeTags = null, string excludeTags = null, bool partial = true, bool only = false)
        {
            StringBuilder sb = new StringBuilder();
            List<(string, string, int)> results = new List<(string, string, int)>();
            int param = 0;
            sb.Append("EXEC search ");
            if (search != null)
            {
                sb.Append($@"@search= @iSearch");
                param++;
            }
            if (includeTags != null)
            {
                if (param > 0)
                {
                    sb.Append(", ");
                }
                if (partial)
                {
                    sb.Append($@"@includePartial= @iIncludeTags");
                }
                else if (only)
                {
                    sb.Append($@"@includeOnly= @iIncludeTags");
                }
                else
                {
                    sb.Append($@"@includeTags= @iIncludeTags");
                }
                param++;
            }
            if (excludeTags != null)
            {
                if (param > 0)
                {
                    sb.Append(", ");
                }
                sb.Append($@"@excludeTags= @iExcludeTags");
            }

            using (SqlConnection c = new SqlConnection(user_cs))
            {
                SqlCommand command = new SqlCommand(sb.ToString(), c);
                if (search != null)
                {
                    command.Parameters.AddWithValue("@iSearch", search);
                }
                if (includeTags != null)
                {
                    command.Parameters.AddWithValue("@iIncludeTags", includeTags);
                }
                if (excludeTags != null)
                {
                    command.Parameters.AddWithValue("@iExcludeTags", excludeTags);
                }
                c.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    string desc = reader.GetString(1);
                    int id = reader.GetInt32(2);

                    results.Add((name, desc, id));
                }
            }
            return results;
        }
        public static List<(string, string, int)> Search(string search = null, List<string> includeTags = null, List<string> excludeTags = null, bool partial = true, bool only = false)
        {
            return Search(search, ListToString(includeTags), ListToString(excludeTags), partial, only);
        }

        public static string ListToString(List<string> input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Count; i++)
            {
                if (i > 0)
                {
                    sb.Append(", ");
                }
                sb.Append(input.ElementAt(i));
            }
            return sb.ToString();
        }

        public static List<string> GetTagList()
        {
            List<string> results = new List<string>();
            using (SqlConnection c = new SqlConnection(user_cs))
            {
                SqlCommand command = new SqlCommand("EXEC get_tag_list", c);

                c.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    results.Add(reader.GetString(0));
                }
            }

            return results;
        }
    }
}
