using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKitchenVault
{
    public class TestRecipe
    {

        //FOR TESTING/DEMO PURPOSES ONLY, DO NOT RUN!

        public static void InsertRecipe()
        {
            List<(string, decimal, string, string)> m_Recipes = new List<(string, decimal, string, string)>();
            m_Recipes.Add(("peanut butter", 1, "tablespoon", null));
            m_Recipes.Add(("strawberry jelly", 1, "tablespoon", null));
            m_Recipes.Add(("slice of bread", 2, "qty", "slices of bread"));

            List<Ingredient> ingredients = new List<Ingredient>();

            foreach(var item in m_Recipes)
            {
                Ingredient newIng = new Ingredient(item.Item1, item.Item2, item.Item3, item.Item4);
                ingredients.Add(newIng);
            }

            List<string> tags = new List<string> { "simple", "easy", "fast" };

            Recipe newRecipe = new Recipe("Peanut Butter and Jelly Sandwich", "A quick and simple classic sandwich", "Take 1 slice of bread, spread the peanut butter on it.\nTake the other slice of bread and spread the jelly on it.\nPut the two slices together with the peanut butter and jelly inside of the sandwich.\nEnjoy!", 2, 0, ingredients, Mkv_Main.user.GetUsername(), tags);

            var response = MessageBox.Show("Are you sure you want to do this?", "Sure?", MessageBoxButtons.YesNo);
            if(response == DialogResult.Yes)
            {
                DB_Interface.AddRecipe(newRecipe);
            }


        }

    }
}
