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


        public CreateRecipeForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("You are about to submit a new recipe, are you ready to do that?", "Ready to submit?", MessageBoxButtons.YesNo);
            if(response == DialogResult.Yes)
            {
                //DB_Interface.AddRecipe(CurrentRecipe);
                if(DB_Interface.Search(CurrentRecipe.Name, includeTags: CurrentRecipe.Tags, filterStyle: FilterStyle.matchAll).Count > 0)
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to cancel?\nAll progress will be lost!", "Are you sure?", MessageBoxButtons.YesNo);
            if(response == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void EditIngredientsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
