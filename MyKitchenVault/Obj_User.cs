using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKitchenVault
{
    public class User
    {
        public static string Username { get; set; }
        public static int UserID { get; set; }

        public User(string _username, int _user_id)
        {
            Username = _username;
            UserID = _user_id;
        }

        /// <summary>
        /// Provides username of the associated user
        /// </summary>
        /// <returns>Username as a string</returns>
        public string GetUsername()
        {
            return Username;
        }

        /// <summary>
        /// Provides user ID of the associated user
        /// </summary>
        /// <returns>User ID as an integer</returns>
        public int GetUserID()
        {
            return UserID;
        }
    }
}
