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
    public partial class MKV_IngredientSelectorForm : Form
    {
        public List<Ingredient> IngredientList { get; set; }

        public MKV_IngredientSelectorForm(List<Ingredient> ings)
        {
            InitializeComponent();
            if (ings != null)
            {
                Populate(ings);
            }
        }

        /// <summary>
        /// Populates the displayed ingredients based on a supplied list of ingredient objects
        /// </summary>
        /// <param name="previous">List of ingredient objects to populate the form with</param>
        private void Populate(List<Ingredient> previous)
        {
            foreach(Ingredient ing in previous)
            {
                MKV_IngredientListItemForm item = new MKV_IngredientListItemForm(ing) { Dock = DockStyle.Top, TopLevel = false, TopMost = true, Visible = true };
                this.ingredientPanel.Controls.Add(item);
            }
        }

        /// <summary>
        /// Adds a new line in the form to enter an ingredient (fired when the "add ingredient" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            MKV_IngredientListItemForm item = new MKV_IngredientListItemForm() { Dock = DockStyle.Top, TopLevel = false, TopMost = true, Visible = true };
            this.ingredientPanel.Controls.Add(item);
        }

        /// <summary>
        /// Collects all ingredient objects into a list and closes the form (fired when the "accept" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (IngredientList == null)
            {
                IngredientList = new List<Ingredient>();
            }

            foreach (MKV_IngredientListItemForm item in ingredientPanel.Controls)
            {
                if (item.OutputIngredient == null)
                {
                    MessageBox.Show("One or more ingredients are incomplete.\nPlease correct this before accepting.", "Error", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    IngredientList.Add(item.OutputIngredient);
                }
            }
            if (IngredientList.Count > 0)
            {                
                var response = MessageBox.Show("Save and close?", "Are you sure?", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("At least 1 ingredient is required.", "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Cancels and closes the form (fired when the "cancel" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Close without saving?", "Are you sure?", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
