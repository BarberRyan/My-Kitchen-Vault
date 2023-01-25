using System;
using System.Collections.Generic;
using System.Data;

namespace MyKitchenVault
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public string UserName { get; set; }
        public List<string> Tags { get; set; }

        public Recipe(string name, string description, string instructions, int prepTime, int cookTime, List<Ingredient> ingredients, string userName, List<string> tags)
        {
           
            Name = name;
            Description = description.Replace(@"\n", Environment.NewLine);
            Instructions = instructions.Replace(@"\n", Environment.NewLine);
            PrepTime = prepTime;
            CookTime = cookTime;
            Ingredients = ingredients;
            UserName = userName;
            Tags = tags;
        }

        public DataTable GetIngredients()
        {
            DataTable dt = new DataTable();
            DataRow row;

            //ingredient_name
            dt.Columns.Add("ingredient_name", typeof(string));

            //ingredient_plural_name
            dt.Columns.Add("ingredient_plural_name", typeof(string));

            //ingredient_qty
            dt.Columns.Add("ingredient_qty", typeof(decimal));

            //ingredient_unit
            dt.Columns.Add("ingredient_unit", typeof(string));

            foreach (Ingredient ing in this.Ingredients)
            {
                row = dt.NewRow();
                row["ingredient_name"] = ing.Name;
                row["ingredient_plural_name"] = ing.PluralName;
                row["ingredient_qty"] = ing.Quantity;
                row["ingredient_unit"] = ing.Unit;
                dt.Rows.Add(row);
            }

            return dt;

        }

        public DataTable GetTags()
        {
            DataTable dt = new DataTable();
            DataRow row;

            //tag_name
            dt.Columns.Add("tag_name", typeof(string));
            

            foreach(string tag in this.Tags)
            {
                row = dt.NewRow();
                row["tag_name"] = tag.ToLower();
                dt.Rows.Add(row);
            }

            return dt;
        }
    }
}
