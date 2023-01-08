using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKitchenVault
{
    public class User
    {
        public static string username { get; set; }
        public static int user_id { get; set; }

        public User(string _username, int _user_id)
        {
            username = _username;
            user_id = _user_id;
        }
        public string GetUsername()
        {
            return username;
        }
        public int GetUserID()
        {
            return user_id;
        }
    }
}
