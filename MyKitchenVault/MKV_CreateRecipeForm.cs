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
    public partial class CreateRecipeForm: Form
    {
        public Recipe CurrentRecipe { get; set; }
        private List<string> CurrentTags { get; set; }
        private List<Ingredient> CurrentIngs { get; set; }

        private Dictionary<RecipeStatus, Control> ControlMap;

        public CreateRecipeForm()
        {
            InitializeComponent();
            PopulateMap();
        }

        /// <summary>
        /// Validates then submits recipe data to the database (fired when the "submit" button is clicked.)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var response = MessageBox.Show("You are about to submit a new recipe, are you ready to do that?", "Ready to submit?", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {

                    Util_DBInterface.AddRecipe(CurrentRecipe);
                    if (Util_DBInterface.Search(CurrentRecipe.Name, includeTags: CurrentRecipe.Tags, filterStyle: FilterStyle.matchAll).Count > 0)
                    {
                        MessageBox.Show($"{CurrentRecipe.Name} was added to the database!", "Success!", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"{CurrentRecipe.Name} was not added to the database.\nEnsure that all fields are filled in properly and try again.", "Failure", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Some fields are not filled in properly (all fields are required).\nPlease check all red fields.", "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Cancels and closes the form (fired when the "cancel" button is clicked.)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to cancel?\nAll progress will be lost!", "Are you sure?", MessageBoxButtons.YesNo);
            if(response == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        /// <summary>
        /// Opens the ingredient selection form (fired when the "edit ingredients" button is clicked.)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void EditIngredientsButton_Click(object sender, EventArgs e)
        {
            using (var form = new MKV_IngredientSelectorForm(this.CurrentIngs))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.CurrentIngs = form.IngredientList;
                    ingredientBox.Text = "";
                    foreach (Ingredient ing in CurrentIngs)
                    {
                        ingredientBox.AppendText(ing.FormatData() + Environment.NewLine);
                    }
                }
            }
        }

        /// <summary>
        /// Opens the tag selection form (fired when the "edit tags" button is clicked.)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void EditTagsButton_Click(object sender, EventArgs e)
        {
            using (var form = new MKV_TagSelectorForm("SelectTags", CurrentTags))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CurrentTags = form.Current;
                    tagBox.Text = "";
                    foreach (string tag in CurrentTags)
                    {
                        tagBox.AppendText(tag + Environment.NewLine);
                    }
                }
            }
        }

        /// <summary>
        /// Constrains input in the cook and prep time boxes to only numbers (fired when a key is pressed in those boxes)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void TimeBox_Key_Press(object sender, KeyPressEventArgs e)
        {
            // Check if the entered character is a digit or backspace.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If it's not, cancel the event and prevent the character from being entered.
                e.Handled = true;
            }
        }
        
        /// <summary>
        /// Takes local data and builds a Recipe object from it
        /// </summary>
        private void BuildRecipe()
        {
            if(CurrentRecipe == null)
            {
                CurrentRecipe = new Recipe();
            }

            CurrentRecipe.Name = nameBox.Text;
            CurrentRecipe.Description = descriptionBox.Text;
            CurrentRecipe.Instructions = instructionsBox.Text;
            Int32.TryParse(cookTimeBox.Text, out int cookTime);
            CurrentRecipe.CookTime = cookTime;
            Int32.TryParse(prepTimeBox.Text, out int prepTime);
            CurrentRecipe.PrepTime = prepTime;
            if(CurrentTags != null)
            {
                CurrentRecipe.Tags = CurrentTags;
            }
            if(CurrentIngs != null)
            {
                CurrentRecipe.Ingredients = CurrentIngs;
            }
        }

        /// <summary>
        /// Validates the form to ensure completeness
        /// </summary>
        /// <returns>list of recipe statuses. A single value of "OK" means the form is valid.</returns>
        private List<RecipeStatus> ValidateBoxes()
        {
            List<RecipeStatus> statuses = new List<RecipeStatus>();
            BuildRecipe();
            if (CurrentRecipe.Name.Trim().Length < 3) statuses.Add(RecipeStatus.BadName);
            if (CurrentRecipe.Description.Trim().Length < 10) statuses.Add(RecipeStatus.BadDesc);
            if (CurrentRecipe.Instructions.Trim().Length < 50) statuses.Add(RecipeStatus.BadInst);
            if (CurrentRecipe.PrepTime == 0) statuses.Add(RecipeStatus.BadPrep);
            if (CurrentRecipe.CookTime == 0) statuses.Add(RecipeStatus.BadCook);
            if (CurrentRecipe.Ingredients.Count == 0) statuses.Add(RecipeStatus.BadIngr);
            if (CurrentRecipe.Tags.Count == 0) statuses.Add(RecipeStatus.BadTags);

            return statuses;
        }

        /// <summary>
        /// Validates input on a single control for feedback purposes
        /// </summary>
        /// <param name="control">Control to validate</param>
        /// <returns>RecipeStatus in a list to use in "IsValid"</returns>
        private List<RecipeStatus> ValidateBox(Control control)
        {
            List<RecipeStatus> statuses = ValidateBoxes();

            foreach(var item in statuses)
            {
                if (ControlMap[item] == control)
                {
                    return new List<RecipeStatus> { item };
                }
            }
            return new List<RecipeStatus> { RecipeStatus.OK };
        }

        /// <summary>
        /// Populates the control map used for validation
        /// </summary>
        private void PopulateMap()
        {
            ControlMap = new Dictionary<RecipeStatus, Control>
            {
                {RecipeStatus.BadName, nameBox },
                {RecipeStatus.BadDesc, descriptionBox },
                {RecipeStatus.BadInst, instructionsBox },
                {RecipeStatus.BadPrep, prepTimeBox },
                {RecipeStatus.BadCook, cookTimeBox },
                {RecipeStatus.BadIngr, ingredientBox },
                {RecipeStatus.BadTags, tagBox }
            };
        }

        /// <summary>
        /// Determines if a control's entered data is valid for recipe submission and recolors invalid controls for feedback
        /// </summary>
        /// <param name="statuses">Optional RecipeStatus list to narrow operations to specific controls</param>
        /// <returns>boolean representing if control data is valid or not</returns>
        private bool IsValid(List<RecipeStatus> statuses = null)
        {
            if (statuses == null)
            {
                statuses = ValidateBoxes();
            }
            foreach(Control control in ControlMap.Values)
            {
                control.BackColor = Color.FromArgb(33, 18, 10);
            }

            if(statuses[0] != RecipeStatus.OK)
            {
                foreach(RecipeStatus status in statuses)
                {
                    if (ControlMap.ContainsKey(status))
                    {
                        Control control = ControlMap[status];
                        control.BackColor = Color.FromArgb(70, 18, 10);
                    }
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Updates textbox colors based on validation status (fired when the text in a textbox is changed)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void Box_Text_Changed(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            IsValid(ValidateBox(control));
        }
    }
}
