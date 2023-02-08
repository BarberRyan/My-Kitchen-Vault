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
    internal class SettingsHandler
    {
        static readonly string settingsPath = Environment.CurrentDirectory.ToString() + "/usersettings.xml";

        public static void AddFav(int userID, int RecipeID)
        {
            CheckSettingsExist(userID);
            XDocument doc = XDocument.Load(settingsPath);
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

                favorites.Value = IntListToString(favs);
                doc.Save(settingsPath);
            }

        }

        public static void RemoveFav(int userID, int RecipeID)
        {
            CheckSettingsExist(userID);
            XDocument doc = XDocument.Load(settingsPath);
            XElement favorites = doc.Descendants("users").Descendants("user")
                                    .Where(e => e.Attribute("id").Value == userID.ToString())
                                    .Elements("favorites")
                                    .FirstOrDefault();
            List<int> favs = StringToIntList(favorites.Value);

            if (favs.Contains(RecipeID))
            {
                favs.Remove(RecipeID);
                favs.Sort();

                favorites.Value = IntListToString(favs);
                doc.Save(settingsPath);
            }
        }

        public static bool IsFav(int userID, int RecipeID)
        {
            CheckSettingsExist(userID);
            XDocument doc = XDocument.Load(settingsPath);
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

        public static void AddBL(int userID, string tag)
        {
            CheckSettingsExist(userID);
            XDocument doc = XDocument.Load(settingsPath);
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
                doc.Save(settingsPath);
            }

        }

        public static void AddBL(int userID, List<string> tags)
        {
            CheckSettingsExist(userID);
            foreach (string tag in tags)
            {
                AddBL(userID, tag);
            }
        }

        public static void RemoveBL(int userID, string tag)
        {
            CheckSettingsExist(userID);
            XDocument doc = XDocument.Load(settingsPath);
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
                doc.Save(settingsPath);
            }
        }

        public static void RemoveBL(int userID, List<string> tags)
        {
            CheckSettingsExist(userID);
            foreach (String tag in tags)
            {
                RemoveBL(userID, tag);
            }
        }

        public static (string, string) GetSettings(int userID)
        {
            CheckSettingsExist(userID);
            if (!File.Exists(settingsPath))
            {
                CreateUserSettings();
            }

            (string, string) output = ("", "");
            XDocument doc = XDocument.Load(settingsPath);
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

        static void CreateUserSettings()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            if (!File.Exists(settingsPath))
            {
                using (XmlWriter writer = XmlWriter.Create(settingsPath, settings))
                {
                    writer.WriteStartElement("users");
                    writer.WriteStartElement("user");
                    writer.WriteAttributeString("id", Mkv_Main.user.GetUserID().ToString());
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
                XDocument doc = XDocument.Load(settingsPath);
                XElement newUser = new XElement("user",
                    new XAttribute("id", Mkv_Main.user.GetUserID().ToString()),
                    new XElement("favorites", ""),
                    new XElement("blacklist", "")
                );
                doc.Root.Add(newUser);
                doc.Save(settingsPath);
            }
        }

        static void CheckSettingsExist(int userID)
        {
            if (File.Exists(settingsPath))
            {
                XDocument doc = XDocument.Load(settingsPath);
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

        public static List<string> StringToList(string input)
        {
            string[] items = Regex.Split(input, @",\s*");
            return new List<string>(items);
        }

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

        public static string IntListToString(List<int> input)
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
