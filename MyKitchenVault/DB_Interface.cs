using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
                SqlCommand command = new SqlCommand($"EXEC check_login @username = @name", c);
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
                                                    "@Ingredients= @iIngredients");
                command.Parameters.AddWithValue("@iName", input.Name);
                command.Parameters.AddWithValue("@iDescription", input.Description);
                command.Parameters.AddWithValue("@iInstructions", input.Instructions);
                command.Parameters.AddWithValue("@iPrepTime", input.PrepTime);
                command.Parameters.AddWithValue("@iCookTime", input.CookTime);
                command.Parameters.AddWithValue("@iUserID", Mkv_Main.user.GetUserID());
                command.Parameters.AddWithValue("@iTags", input.GetTags());
                command.Parameters.AddWithValue("@iIngredients", input.GetIngredients());

                c.Open();
                command.ExecuteNonQuery();
                c.Close();
            }
        }
    }
}
