using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKitchenVault
{
    public partial class MKV_RecipeViewForm : Form
    {
        private Recipe InputRecipe { get; set; }
        private decimal UserRating { get; set; }
        private bool IsFav { get; set; }

        public MKV_RecipeViewForm((Recipe, decimal) inputData)
        {
            InputRecipe = inputData.Item1;
            UserRating = inputData.Item2;
            InitializeComponent();
            Populate();
        }

        /// <summary>
        /// Populates (or repopulates) the form with recipe information
        /// </summary>
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
            
            if(Util_SettingsHandler.IsFav(MKV_Main.user.GetUserID(), InputRecipe.RecipeID))
            {
                favStar.Image = starList.Images[2];
                IsFav = true;
            }
            else
            {
                favStar.Image = starList.Images[0];
                IsFav = false;
            }

            UpdateRatings();
            UpdateStars(InputRecipe.Rating);
        }

        /// <summary>
        /// Formats the list of ingredient values for display
        /// </summary>
        /// <returns>Formatted list of ingredients as a string</returns>
        private string FormatIngr()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Ingredient ing in InputRecipe.Ingredients)
            {
                if(ing.Quantity > 1 && ing.PluralName!= null && ing.Unit == "qty")
                {
                    sb.AppendLine($"{Util_FractionConverter.ToFraction(ing.Quantity)} {ing.PluralName}");
                }
                else if(ing.Quantity > 1)
                {
                    sb.AppendLine($"{Util_FractionConverter.ToFraction(ing.Quantity)} {ing.Unit}s of {ing.Name}");
                }
                else
                {
                    sb.AppendLine($"{Util_FractionConverter.ToFraction(ing.Quantity)} {ing.Unit} of {ing.Name}");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Formats the list of tag values for display
        /// </summary>
        /// <returns>Formatted list of tags as a string</returns>
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

        /// <summary>
        /// Sets the star PictureBox image values to match a given rating
        /// </summary>
        /// <param name="rating">Rating as a decimal between 0 and 5</param>
        private void UpdateStars(decimal rating)
        {
            int[] starVals = StarHandler.SetStars(rating);
            star1.Image = starList.Images[starVals[0]];
            star2.Image = starList.Images[starVals[1]];
            star3.Image = starList.Images[starVals[2]];
            star4.Image = starList.Images[starVals[3]];
            star5.Image = starList.Images[starVals[4]];
        }

        /// <summary>
        /// Sets the star PictureBox image values to match a given configuration
        /// </summary>
        /// <param name="setting">Array of index values to determine which star to display</param>
        private void UpdateStars(int[] setting)
        {
            star1.Image = starList.Images[setting[0]];
            star2.Image = starList.Images[setting[1]];
            star3.Image = starList.Images[setting[2]];
            star4.Image = starList.Images[setting[3]];
            star5.Image = starList.Images[setting[4]];
        }

        /// <summary>
        /// Sets the values of the two ratings labels to match the pertinent data
        /// </summary>
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
        
        /// <summary>
        /// Updates the star images based on mouse position above them (fired when the mouse moves over any star)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
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

        /// <summary>
        /// Updates the star images based on mouse position above them (fired when the mouse moves off any star)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
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

        /// <summary>
        /// Updates the user rating based on which star (and where on the star) is clicked (fired when the user clicks any star)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void Star_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coords = me.Location;
            var star = sender as PictureBox;

            decimal rating = 0.0M;

            switch (star)
            {
                case object s when (s.Equals(star2)):
                    rating = 1.0M;
                    break;
                case object s when (s.Equals(star3)):
                    rating = 2.0M;
                    break;
                case object s when (s.Equals(star4)):
                    rating = 3.0M;
                    break;
                case object s when (s.Equals(star5)):
                    rating = 4.0M;
                    break;

            }

            if (coords.X <= star.Width / 2)
            {
                rating += 0.5M;
            }
            else if (coords.X > star.Width / 2)
            {
                rating += 1.0M;
            }
            
            Util_DBInterface.SetRating(InputRecipe.RecipeID, rating);
            (Recipe, decimal) newRecipe = Util_DBInterface.GetRecipe(InputRecipe.RecipeID);
            this.InputRecipe = newRecipe.Item1;
            this.UserRating = newRecipe.Item2;
            Populate();
        }

        /// <summary>
        /// Updates "favorite" status of the recipe (fired when the favorite star is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void FavStar_Click(object sender, EventArgs e)
        {
            if (IsFav)
            {
                favStar.Image = starList.Images[0];
                Util_SettingsHandler.RemoveFav(MKV_Main.user.GetUserID(), InputRecipe.RecipeID);
                IsFav = false;
            }           
            else
            {
                favStar.Image = starList.Images[2];
                Util_SettingsHandler.AddFav(MKV_Main.user.GetUserID(), InputRecipe.RecipeID);
                IsFav = true;
            }
        }

        /// <summary>
        /// Creates a .txt file and primpts the user to save it to a location (fired when the "save" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"##### {InputRecipe.Name.ToUpper()} BY {InputRecipe.UserName.ToUpper()} #####\n");
            sb.AppendLine("##### DESCRIPTION #####");
            sb.AppendLine(InputRecipe.Description + "\n");
            sb.AppendLine("##### INGREDIENTS #####");
            sb.AppendLine(FormatIngr());
            sb.AppendLine("##### INSTRUCTIONS #####");
            sb.AppendLine(InputRecipe.Instructions + "\n");
            sb.AppendLine("##### TAGS #####");
            sb.AppendLine(FormatTags());

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Select output file:";
            saveDialog.Filter = ".txt file|*.txt";
            saveDialog.FileName = $"{InputRecipe.Name} by {InputRecipe.UserName}.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = File.CreateText(saveDialog.FileName))
                {
                    writer.Write(sb.ToString());
                }
            }
        }
    }
}
