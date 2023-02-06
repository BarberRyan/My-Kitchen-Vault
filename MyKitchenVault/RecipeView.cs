using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKitchenVault
{
    public partial class RecipeView : Form
    {
        private Recipe InputRecipe { get; set; }
        private decimal UserRating { get; set; }
        private int CurRecipeID { get; set; }

        public RecipeView((Recipe, decimal) inputData)
        {
            InputRecipe = inputData.Item1;
            UserRating = inputData.Item2;
            CurRecipeID = InputRecipe.RecipeID;
            InitializeComponent();
            Populate();
        }

        private void Populate()
        {
            this.Text = $"Viewing \"{InputRecipe.Name}\" by {InputRecipe.UserName}";
            nameLabel.Text = InputRecipe.Name;
            userLabel.Text = "By: " + InputRecipe.UserName + "\n\n";
            descTitleLabel.Text = "\nDescription";
            descLabel.Text = InputRecipe.Description + "\n\n\n";
            ingrLabel.Text = FormatIngr() + "\n\n";
            instLabel.Text = InputRecipe.Instructions + "\n\n\n";
            tagLabel.Text = FormatTags();

            UpdateRatings();
            UpdateStars(InputRecipe.Rating);
        }

        private string FormatIngr()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Ingredient ing in InputRecipe.Ingredients)
            {
                if(ing.Quantity > 1 && ing.PluralName!= null && ing.Unit == "qty")
                {
                    sb.AppendLine($"{FractionUtil.ToFraction(ing.Quantity)} {ing.PluralName}");
                }
                else if(ing.Quantity > 1)
                {
                    sb.AppendLine($"{FractionUtil.ToFraction(ing.Quantity)} {ing.Unit}s of {ing.Name}");
                }
                else
                {
                    sb.AppendLine($"{FractionUtil.ToFraction(ing.Quantity)} {ing.Unit} of {ing.Name}");
                }
            }
            return sb.ToString();
        }

        private string FormatTags() 
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < InputRecipe.Tags.Count; i++)
            {
                if(i > 0)
                {
                    sb.Append(", ");
                }
                sb.Append(InputRecipe.Tags[i]);
            }

            return sb.ToString();
        }

        private void UpdateStars(decimal rating)
        {
            int[] starVals = starHandler.SetStars(rating);
            star1.Image = starList.Images[starVals[0]];
            star2.Image = starList.Images[starVals[1]];
            star3.Image = starList.Images[starVals[2]];
            star4.Image = starList.Images[starVals[3]];
            star5.Image = starList.Images[starVals[4]];
        }

        private void UpdateStars(int[] setting)
        {
            star1.Image = starList.Images[setting[0]];
            star2.Image = starList.Images[setting[1]];
            star3.Image = starList.Images[setting[2]];
            star4.Image = starList.Images[setting[3]];
            star5.Image = starList.Images[setting[4]];
        }

        private void UpdateRatings()
        {
            if(InputRecipe.RatingCount > 1)
            {
                ratingLabel.Text = $"Rating: {InputRecipe.Rating}/5 ({InputRecipe.RatingCount} ratings)";
            }
            else
            {
                ratingLabel.Text = $"Rating: {InputRecipe.Rating}/5 ({InputRecipe.RatingCount} rating)";
            }
            if(UserRating > 0.0M)
            {
                userRatingLabel.Text = $"Your rating: {UserRating}/5";
            }
            else
            {
                userRatingLabel.Text = "You have not rated this recipe.";
            }
        }
        
        private void Star_Mouse_Move(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coords = me.Location;
            var star = sender as PictureBox;

            switch (star)
            {
                case object s1 when (s1.Equals(star1)):
                    UpdateStars(new int[] { 1, 0, 0, 0, 0 });
                    break;
                case object s2 when (s2.Equals(star2)):
                    UpdateStars(new int[] { 2, 1, 0, 0, 0 });
                    break;
                case object s3 when (s3.Equals(star3)):
                    UpdateStars(new int[] { 2, 2, 1, 0, 0 });
                    break;
                case object s4 when (s4.Equals(star4)):
                    UpdateStars(new int[] { 2, 2, 2, 1, 0 });
                    break;
                case object s5 when (s5.Equals(star5)):
                    UpdateStars(new int[] {2, 2, 2, 2, 1 });
                    break;
                  
            }

            if (coords.X <= star.Width / 2 && star.Image != starList.Images[1])
            {
                star.Image = starList.Images[1];
            }
            else if (coords.X > star.Width / 2 && star.Image != starList.Images[2])
            {
                star.Image = starList.Images[2];
            }
        }
        
        private void Star_Mouse_Leave(object sender, EventArgs e)
        {
            if(this.UserRating > 0.0M)
            {
                UpdateStars(UserRating);
            }
            else
            {
                UpdateStars(InputRecipe.Rating);
            }
        }

        private void Star_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coords = me.Location;
            var star = sender as PictureBox;

            decimal rating = 0.0M;

            switch (star)
            {
                case object s2 when (s2.Equals(star2)):
                    rating = 1.0M;
                    break;
                case object s3 when (s3.Equals(star3)):
                    rating = 2.0M;
                    break;
                case object s4 when (s4.Equals(star4)):
                    rating = 3.0M;
                    break;
                case object s5 when (s5.Equals(star5)):
                    rating = 4.0M;
                    break;

            }

            if (coords.X <= star.Width / 2 && star.Image != starList.Images[1])
            {
                rating += 0.5M;
            }
            else if (coords.X > star.Width / 2 && star.Image != starList.Images[2])
            {
                rating += 1.0M;
            }
            
            DB_Interface.SetRating(InputRecipe.RecipeID, rating);
            (Recipe, decimal) newRecipe = DB_Interface.GetRecipe(InputRecipe.RecipeID);
            this.InputRecipe = newRecipe.Item1;
            this.UserRating = newRecipe.Item2;
            Populate();
        }
    }
}
