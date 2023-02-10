using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MyKitchenVault
{
    internal class Util_SettingsHandler
    {
        static string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Gods of Code/My Kitchen Vault";
        static string FilePath = Path.Combine(FolderPath, "usersettings.xml");



        /// <summary>
        /// Adds recipe id to user's favorites
        /// </summary>
        /// <param name="userID">ID of user to save to</param>
        /// <param name="RecipeID">ID of recipe to save</param>
        public static void AddFav(int userID, int RecipeID)
        {
            CheckSettingsExist(userID);
            XDocument doc = XDocument.Load(FilePath);
            XElement favorites = doc.Descendants("users").Descendants("user")
                                    .Where(e => e.Attribute("id").Value == userID.ToString())
                                    .Elements("favorites")
                                    .FirstOrDefault();
            List<int> favs = new List<int>();
            if(favorites.Value.Length > 0)
            {
                favs = StringToIntList(favorites.Value);
            }    

            if (!favs.Contains(RecipeID))
            {
                favs.Add(RecipeID);
                favs.Sort();

                favorites.Value = ListToString(favs);
                doc.Save(FilePath);
            }

        }

        /// <summary>
        /// Removes recipe id from user's favorites
        /// </summary>
        /// <param name="userID">ID of user to remove from</param>
        /// <param name="RecipeID">ID of recipe to remove</param>
        public static void RemoveFav(int userID, int RecipeID)
        {
            CheckSettingsExist(userID);
            XDocument doc = XDocument.Load(FilePath);
            XElement favorites = doc.Descendants("users").Descendants("user")
                                    .Where(e => e.Attribute("id").Value == userID.ToString())
                                    .Elements("favorites")
                                    .FirstOrDefault();
            List<int> favs = StringToIntList(favorites.Value);

            if (favs.Contains(RecipeID))
            {
                favs.Remove(RecipeID);
                favs.Sort();

                favorites.Value = ListToString(favs);
                doc.Save(FilePath);
            }
        }

        /// <summary>
        /// Checks to see if a recipe is in a user's favorites
        /// </summary>
        /// <param name="userID">ID of user to check</param>
        /// <param name="RecipeID">ID of recipe to check</param>
        /// <returns>boolean representing if the recipe is favorited</returns>
        public static bool IsFav(int userID, int RecipeID)
        {
            CheckSettingsExist(userID);
            XDocument doc = XDocument.Load(FilePath);
            XElement favorites = doc.Descendants("users").Descendants("user")
                                    .Where(e => e.Attribute("id").Value == userID.ToString())
                                    .Elements("favorites")
                                    .FirstOrDefault();

            List<int> favs = new List<int>();
            
            if (favorites.Value.Length > 0)
            {
                favs = StringToIntList(favorites.Value);
            }

            if (favs.Contains(RecipeID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Adds a tag to a user's blacklist (single tag)
        /// </summary>
        /// <param name="userID">ID of user to add to</param>
        /// <param name="tag">Tag to add</param>
        public static void AddBL(int userID, string tag)
        {
            CheckSettingsExist(userID);
            XDocument doc = XDocument.Load(FilePath);
            XElement blacklist = doc.Descendants("users").Descendants("user")
                                    .Where(e => e.Attribute("id").Value == userID.ToString())
                                    .Elements("blacklist")
                                    .FirstOrDefault();
            List<string> bl = StringToList(blacklist.Value);

            if (!bl.Contains(tag))
            {
                bl.Add(tag);
                bl.Sort();

                blacklist.Value = ListToString(bl);
                doc.Save(FilePath);
            }

        }

        /// <summary>
        /// Adds tags to a user's blacklist (list of tags)
        /// </summary>
        /// <param name="userID">ID of user to add to</param>
        /// <param name="tags">Tags to add</param>
        public static void AddBL(int userID, List<string> tags)
        {
            CheckSettingsExist(userID);
            foreach (string tag in tags)
            {
                AddBL(userID, tag);
            }
        }

        /// <summary>
        /// Removes a tag from a user's blacklist (single tag)
        /// </summary>
        /// <param name="userID">ID of user to remove from</param>
        /// <param name="tag">Tag to remove</param>
        public static void RemoveBL(int userID, string tag)
        {
            CheckSettingsExist(userID);
            XDocument doc = XDocument.Load(FilePath);
            XElement blacklist = doc.Descendants("users").Descendants("user")
                                    .Where(e => e.Attribute("id").Value == userID.ToString())
                                    .Elements("blacklist")
                                    .FirstOrDefault();
            List<string> bl = StringToList(blacklist.Value);

            if (bl.Contains(tag))
            {
                bl.Remove(tag);
                bl.Sort();

                blacklist.Value = ListToString(bl);
                doc.Save(FilePath);
            }
        }

        /// <summary>
        /// Removes tags from a user's blacklist (list of tags)
        /// </summary>
        /// <param name="userID">ID of user to remove from</param>
        /// <param name="tags">Tags to remove</param>
        public static void RemoveBL(int userID, List<string> tags)
        {
            CheckSettingsExist(userID);
            foreach (String tag in tags)
            {
                RemoveBL(userID, tag);
            }
        }

        /// <summary>
        /// Retrieve favorites and blacklist
        /// </summary>
        /// <param name="userID">ID of user to check</param>
        /// <returns>tuple containing the favorite and blacklist lists as strings</returns>
        public static (string, string) GetSettings(int userID)
        {
            CheckSettingsExist(userID);
            if (!File.Exists(FilePath))
            {
                CreateUserSettings();
            }

            (string, string) output = ("", "");
            XDocument doc = XDocument.Load(FilePath);
            XElement favorites = doc.Descendants("users").Descendants("user")
                                    .Where(e => e.Attribute("id").Value == userID.ToString())
                                    .Elements("favorites")
                                    .FirstOrDefault();
            XElement blacklist = doc.Descendants("users").Descendants("user")
                                    .Where(e => e.Attribute("id").Value == userID.ToString())
                                    .Elements("blacklist")
                                    .FirstOrDefault();
            if(favorites != null && blacklist != null)
            {
                output = (favorites.Value, blacklist.Value);
            }
            return output;
        }

        //Adds current user to usersettings.xml (adds usersettings.xml if it doesn't exist)
        static void CreateUserSettings()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }


            if (!File.Exists(FilePath))
            {
                using (XmlWriter writer = XmlWriter.Create(FilePath, settings))
                {
                    writer.WriteStartElement("users");
                    writer.WriteStartElement("user");
                    writer.WriteAttributeString("id", MKV_Main.user.GetUserID().ToString());
                    writer.WriteStartElement("favorites");
                    writer.WriteString("");
                    writer.WriteEndElement();
                    writer.WriteStartElement("blacklist");
                    writer.WriteString("");
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.Close();
                }
            }
            else
            {
                XDocument doc = XDocument.Load(FilePath);
                XElement newUser = new XElement("user",
                    new XAttribute("id", MKV_Main.user.GetUserID().ToString()),
                    new XElement("favorites", ""),
                    new XElement("blacklist", "")
                );
                doc.Root.Add(newUser);
                doc.Save(FilePath);
            }
        }

        /// <summary>
        /// Checks if the supplied userID has settings saved and creates them if thet do not
        /// </summary>
        /// <param name="userID">ID of user to check</param>
        static void CheckSettingsExist(int userID)
        {
            if (File.Exists(FilePath))
            {
                XDocument doc = XDocument.Load(FilePath);
                XElement favorites = doc.Descendants("users").Descendants("user")
                                        .Where(e => e.Attribute("id").Value == userID.ToString())
                                        .Elements("favorites")
                                        .FirstOrDefault();
                XElement blacklist = doc.Descendants("users").Descendants("user")
                                        .Where(e => e.Attribute("id").Value == userID.ToString())
                                        .Elements("blacklist")
                                        .FirstOrDefault();

                if (favorites == null || blacklist == null)
                {
                    CreateUserSettings();
                }
            }
        }

        /// <summary>
        /// Converts a comma separated list of strings into a string List container
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <returns>List of string elements</returns>
        public static List<string> StringToList(string input)
        {
            string[] items = Regex.Split(input, @",\s*");
            return new List<string>(items);
        }

        /// <summary>
        /// Converts a comma separated list of strings into an integer List container
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <returns>List of int elements</returns>
        public static List<int> StringToIntList(string input)
        {
            string[] items = Regex.Split(input, @",\s*");
            List<int> output = new List<int>();

            foreach(string item in items)
            {
                output.Add(int.Parse(item));
            }

            return output; 
        }

        /// <summary>
        /// Converts list of strings to a comma separated string
        /// </summary>
        /// <param name="input">List of strings to parse</param>
        /// <returns>string of comma separated values</returns>
        public static string ListToString(List<string> input)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < input.Count; i++)
            {
                if(i > 0)
                {
                    sb.Append(", ");
                }
                sb.Append(input[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Converts list of integers to a comma separated string
        /// </summary>
        /// <param name="input">List of ints to parse</param>
        /// <returns>string of comma separated values</returns>
        public static string ListToString(List<int> input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Count; i++)
            {
                if (i > 0)
                {
                    sb.Append(", ");
                }
                sb.Append(input[i]);
            }
            return sb.ToString();
        }

    }
}
