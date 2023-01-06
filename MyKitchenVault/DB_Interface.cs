using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyKitchenVault
{
    public static class DB_Interface
    {
        
        public static string GenerateHash(string password, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
            SHA256Managed SHAM = new SHA256Managed();
            byte[] hash = SHAM.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
        
        public static (string, int, LoginStatus) CheckLogin(string username, string password)
        {
            using (SqlConnection c = new SqlConnection(Connections.UserAdminCS))
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM users WHERE user_name = @username", c);
                command.Parameters.AddWithValue("@username", username);

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
            using (SqlConnection c = new SqlConnection(Connections.UserAdminCS))
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM users WHERE user_name = @username", c);
                command.Parameters.AddWithValue("@username", username);
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
                using (SqlConnection c = new SqlConnection(Connections.UserAdminCS))
                {
                    Random rand = new Random();
                    string salt = rand.Next(1000, 10000).ToString();
                    string passHash = GenerateHash(password, salt);
                    SqlCommand command = new SqlCommand("INSERT INTO users (user_name, password, salt) VALUES (@username, @password, @salt)", c);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", passHash);
                    command.Parameters.AddWithValue("@salt", salt);
                    c.Open();
                    command.ExecuteNonQuery();
                }
            }
            return CheckUserExists(username);
        }
    }
}
