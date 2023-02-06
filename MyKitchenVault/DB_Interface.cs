using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Caching;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyKitchenVault
{
    public class DB_Interface
    {
        //Load connection strings from config file
        static readonly string user_admin_cs = System.Configuration.ConfigurationManager.ConnectionStrings["User_Admin_CS"].ConnectionString;
        static readonly string user_cs = System.Configuration.ConfigurationManager.ConnectionStrings["User_CS"].ConnectionString;


        /*********
         * LOGIN *
         *********/

        /// <summary>
        /// Generates password hash for password storage and authentication
        /// </summary>
        /// <param name="password">Plaintext password to be hashed</param>
        /// <param name="salt">Value to salt the hash with</param>
        /// <returns>Hashed password value</returns>
        public static string GenerateHash(string password, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
            SHA256Managed SHAM = new SHA256Managed();
            byte[] hash = SHAM.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        /// <summary>
        /// Checks username and password against database data
        /// </summary>
        /// <param name="username">Username to check</param>
        /// <param name="password">Password to check</param>
        /// <returns>Tuple of stored username, user ID number, and LoginStatus object</returns>
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

                        if (GenerateHash(password, salt) == passHash)
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

        /// <summary>
        /// Checks to see if a username already exists in the database
        /// </summary>
        /// <param name="username">Username to check</param>
        /// <returns>Boolean representing if the user exists or not</returns>
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

        /// <summary>
        /// Adds a user and password data to the database
        /// </summary>
        /// <param name="username">Username to add</param>
        /// <param name="password">Password to associate with the account</param>
        /// <returns>Boolean representing if the user exists in the database after creation</returns>
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

        /// <summary>
        /// Adds recipe to the database
        /// </summary>
        /// <param name="input">Recipe object to add to the database</param>
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
                command.Parameters.AddWithValue("@iUserID", Mkv_Main.user.GetUserID());

                SqlParameter tagList = new SqlParameter("@iTags", SqlDbType.Structured)
                {
                    TypeName = "dbo.TagTableType",
                    Value = input.GetTagTable()
                };
                command.Parameters.Add(tagList);

                SqlParameter ingList = new SqlParameter("@iIngredients", SqlDbType.Structured)
                {
                    TypeName = "dbo.IngredientTableType",
                    Value = input.GetIngredientTable()
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

        /// <summary>
        /// Searches database for recipes fitting search and filter criteria (tag lists formatted as strings)
        /// </summary>
        /// <param name="search">Search value (searches for any recipes containing this string in name or description)</param>
        /// <param name="includeTags">List of tags to include in search (as a string)</param>
        /// <param name="excludeTags">List of tags to exclude in search (as a string)</param>
        /// <param name="filterStyle">FilterStyle object to determine if recipe needs to include all include tags or any of them</param>
        /// <returns>Tuple of recipe name, recipe description, and recipe ID</returns>
        public static List<(string, string, int)> Search(string search = null, string includeTags = null, string excludeTags = null, int rating = 0, FilterStyle filterStyle = FilterStyle.none)
        {
            StringBuilder sb = new StringBuilder();
            List<(string, string, int)> results = new List<(string, string, int)>();
            int param = 0;
            sb.Append("EXEC search ");
            if (search != null)
            {
                sb.Append("@search= @iSearch");
                param++;
            }
            if (includeTags != null)
            {
                if (param > 0)
                {
                    sb.Append(", ");
                }
                if (filterStyle == FilterStyle.matchAny)
                {
                    sb.Append("@includePartial= @iIncludeTags");
                }
                else
                {
                    sb.Append("@includeTags= @iIncludeTags");
                }
                param++;
            }
            if (excludeTags != null)
            {
                if (param > 0)
                {
                    sb.Append(", ");
                }
                sb.Append("@excludeTags= @iExcludeTags");
                param++;
            }
            if (rating != 0)
            {
                if (param > 0)
                {
                    sb.Append(", ");
                }
                sb.Append("@rating= @iRating");
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
                if (rating != 0)
                {
                    command.Parameters.AddWithValue("@iRating", rating);
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

        /// <summary>
        /// Searches database for recipes fitting search and filter criteria (Override using List instead of String for tags)
        /// </summary>
        /// <param name="search">Search value (searches for any recipes containing this string in name or description)</param>
        /// <param name="includeTags">List of tags to include in search</param>
        /// <param name="excludeTags">List of tags to exclude in search</param>
        /// <param name="filterStyle">FilterStyle object to determine if recipe needs to include all include tags or any of them</param>
        /// <returns>Tuple of recipe name, recipe description, and recipe ID</returns>
        public static List<(string, string, int)> Search(string search = null, List<string> includeTags = null, List<string> excludeTags = null, int rating = 0, FilterStyle filterStyle = FilterStyle.none)
        {
            string include = null;
            string exclude = null;
            if(includeTags != null)
            {
                include = ListToString(includeTags);
            }
            if(excludeTags != null)
            {
                exclude = ListToString(excludeTags);
            }

            return Search(search, include, exclude, rating, filterStyle);
        }

        public static (Recipe, decimal) GetRecipe(int recipeID)
        {
            string recipeName = "";
            string recipeDesc = "";
            string recipeInst = "";
            string recipeUser = "";
            decimal recipeRate = 0;
            int recipeRateCount = 0;
            decimal userRate = 0;
            int recipePrep = 0;
            int recipeCook = 0;
            List<string> recipeTags = new List<string>();
            List<Ingredient> recipeIngr = new List<Ingredient>();

            using (SqlConnection c = new SqlConnection(user_cs))
            {               
                SqlCommand command = new SqlCommand("EXEC get_recipe @RecipeID=@recipe_id, @UserID=@user_id", c);
                command.Parameters.AddWithValue("@recipe_id", recipeID);
                command.Parameters.AddWithValue("@user_id", Mkv_Main.user.GetUserID());
                
                c.Open();

                SqlDataReader reader = command.ExecuteReader();
                
                //RECIPE INFO

                while (reader.Read())
                {
                    recipeName = reader.GetString(0);
                    recipeDesc = reader.GetString(1);
                    recipeInst = reader.GetString(2);
                    recipePrep = reader.GetInt32(3);
                    recipeCook = reader.GetInt32(4);
                }

                //USER

                reader.NextResult();

                while (reader.Read())
                {
                    recipeUser = reader.GetString(0);
                }

                //INGREDIENTS
                reader.NextResult();

                while (reader.Read())
                {
                    string ingName;
                    string ingPName = null;
                    decimal ingQty;
                    string ingUnit; 
                    
                    ingName = reader.GetString(0);
                    try
                    {
                        ingPName = reader.GetString(1);
                    }                    
                    catch{}
                    ingQty = reader.GetDecimal(2);
                    ingUnit = reader.GetString(3);
                    recipeIngr.Add(new Ingredient(ingName, ingQty, ingUnit, ingPName));
                }

                //RATING
                reader.NextResult();

                while (reader.Read())
                {
                    recipeRate = reader.GetDecimal(0);
                    recipeRateCount = reader.GetInt32(1);
                    userRate = reader.GetDecimal(2);
                }

                //TAGS
                reader.NextResult();

                while (reader.Read())
                {
                    recipeTags.Add(reader.GetString(0));
                }
            }

            Recipe output = new Recipe(recipeID, recipeName, recipeDesc, recipeInst, recipePrep, recipeCook, recipeRate, recipeRateCount, recipeIngr, recipeUser, recipeTags);

            return (output, userRate);                
        }

        /***********
         * RATINGS *
         ***********/

        public static void SetRating(int recipeID, decimal rating)
        {

            using (SqlConnection c = new SqlConnection(user_cs))
            {
                SqlCommand command = new SqlCommand("EXEC new_rating @UserID=@user_id, @RecipeID=@recipe_id, @Rating=@new_rating", c);
                command.Parameters.AddWithValue("@recipe_id", recipeID);
                command.Parameters.AddWithValue("@user_id", Mkv_Main.user.GetUserID());
                command.Parameters.AddWithValue("@new_rating", rating);

                c.Open();
                command.ExecuteNonQuery();
            }
        }

        /*************
         * UTILITIES *
         *************/

        /// <summary>
        /// Converts a string list to a comma-separated string
        /// </summary>
        /// <param name="input">List to convert</param>
        /// <returns>String of list items separated by a comma and a space</returns>
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

        /// <summary>
        /// Gets list data for autocomplete purposes
        /// </summary>
        /// <returns>Tuple of recipe name, ingredient name, ingredient plural name, unit name, and all tags (tags + ingredient name/plural name)</returns>
        public static (List<string>, List<string>, List<string>, List<string>, List<string>) GetAutocompleteLists()
        {
            List<string> ac_recipe_name = new List<string>();
            List<string> ac_ingredient_name = new List<string>();
            List<string> ac_ingredient_plural_name = new List<string>();
            List<string> ac_unit_name = new List<string>();
            List<string> ac_all_tags = new List<string>();

            using (SqlConnection c = new SqlConnection(user_cs))
            {
                SqlCommand command = new SqlCommand("EXEC get_autocomplete_list", c);

                c.Open();

                SqlDataReader reader = command.ExecuteReader();             
                while (reader.Read())
                {
                    try
                    {
                        ac_recipe_name.Add(reader.GetString(0));
                    }
                    catch { }
                }

                reader.NextResult();
                while (reader.Read())
                {
                    try
                    {
                        ac_ingredient_name.Add(reader.GetString(0));
                    }
                    catch { }
                }

                reader.NextResult();
                while (reader.Read())
                {
                    try
                    {
                        ac_ingredient_plural_name.Add(reader.GetString(0));
                    }
                    catch { }
                }

                reader.NextResult();
                while (reader.Read())
                {
                    try
                    {
                        ac_unit_name.Add(reader.GetString(0));
                    }
                    catch { }
                }

                reader.NextResult();
                while (reader.Read())
                {
                    try
                    {
                        ac_all_tags.Add(reader.GetString(0));
                    }
                    catch { }
                }

                return (ac_recipe_name, ac_ingredient_name, ac_ingredient_plural_name, ac_unit_name, ac_all_tags);
            }
        }
    }
}
