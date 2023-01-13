using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DataColumn newColumn = new DataColumn();
            DataRow row;

            //ingredient_name
            newColumn.ColumnName = "ingredient_name";
            newColumn.DataType = System.Type.GetType("System.String");
            dt.Columns.Add(newColumn);

            //ingredient_plural_name
            newColumn = new DataColumn
            {
                ColumnName = "ingredient_plural_name",
                DataType = System.Type.GetType("System.String")
            };
            dt.Columns.Add(newColumn);

            //ingredient_qty
            newColumn = new DataColumn
            {
                ColumnName = "ingredient_qty",
                DataType = System.Type.GetType("System.Decimal")
            };
            dt.Columns.Add(newColumn);

            //ingredient_unit
            newColumn = new DataColumn
            {
                ColumnName = "ingredient_unit",
                DataType = System.Type.GetType("System.String")
            };
            dt.Columns.Add(newColumn);

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
            DataColumn newColumn = new DataColumn
            {
                ColumnName = "tag_name",
                DataType = System.Type.GetType("System.String")
            };
            dt.Columns.Add(newColumn);

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
