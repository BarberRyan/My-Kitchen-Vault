﻿using System;
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
        public decimal Rating { get; set; }
        public int RatingCount { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public string UserName { get; set; }
        public List<string> Tags { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Tags = new List<string>();
        }

        public Recipe(int recipeID, string name, string description, string instructions, int prepTime, int cookTime, decimal rating, int ratingCount, List<Ingredient> ingredients, string userName, List<string> tags)
        {
            RecipeID = recipeID;
            Name = name;
            Description = description.Replace(@"\n", Environment.NewLine);
            Instructions = instructions.Replace(@"\n", Environment.NewLine);
            PrepTime = prepTime;
            CookTime = cookTime;
            Rating = rating;
            RatingCount = ratingCount;
            Ingredients = ingredients;
            UserName = userName;
            Tags = tags;
        }    

        /// <summary>
        /// Refreshes the rating inside the object based on input data
        /// </summary>
        /// <param name="newRate">A tuple representing the average rating, the number of ratings, and the current user's rating (unused here).</param>
        public void RefreshRatings((decimal, int, decimal) newRate)
        {
            this.Rating = newRate.Item1;
            this.RatingCount = newRate.Item2;
        }

        /// <summary>
        /// Returns a DataTable of all ingredients in the recipe (used for DB entry)
        /// </summary>
        /// <returns>DataTable representing ingredients</returns>
        public DataTable GetIngredientTable()
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

        /// <summary>
        /// Returns a DataTable of all tags associated with the recipe (used for DB entry)
        /// </summary>
        /// <returns>DataTable representing tags</returns>
        public DataTable GetTagTable()
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
