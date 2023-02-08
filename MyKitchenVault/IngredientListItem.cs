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
    public partial class IngredientListItem : Form
    {
        public Ingredient OutputIngredient { get; set; }

        public IngredientListItem()
        {
            InitializeComponent();
        }

        //Updates the internal Ingredient object (fires when text is changed on any text box)
        private void TextBox_Text_Changed(object sender, EventArgs e)
        {
            OutputIngredient.Name = ingredientNameBox.Text;
            OutputIngredient.PluralName = ingredientPNameBox.Text;
            if(!Decimal.TryParse(ingredientQtyBox.Text, out decimal qty))
            {
                qty = 0.0M;
            }
            OutputIngredient.Quantity = qty;
            OutputIngredient.Unit = ingredientUnitBox.Text;
        }

        /// <summary>
        /// Closes the form to remove it (fires when the "Remove" button is clicked)
        /// </summary>
        /// <param name="sender">Object that </param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
