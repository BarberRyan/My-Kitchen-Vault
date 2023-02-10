using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyKitchenVault
{
    public partial class MKV_IngredientListItemForm : Form
    {
        public Ingredient OutputIngredient { get; set; }
        private Dictionary<string, string> NamePairs { get; set; }

        public MKV_IngredientListItemForm()
        {
            InitializeComponent();
            SetAutocomplete();
        }

        public MKV_IngredientListItemForm(Ingredient startIng)
        {
            InitializeComponent();
            SetAutocomplete();
            this.ingredientNameBox.Text = startIng.Name;
            this.ingredientPNameBox.Text = startIng.PluralName;
            this.ingredientQtyBox.Text = startIng.Quantity.ToString();
            this.ingredientUnitBox.Text = startIng.Unit;
        }

        /// <summary>
        /// Sets autocomplete lists for textboxes
        /// </summary>
        private void SetAutocomplete()
        {
            //Name
            AutoCompleteStringCollection names = new AutoCompleteStringCollection();
            names.AddRange(MKV_Main.ac_ingredient_name.ToArray());
            ingredientNameBox.AutoCompleteCustomSource = names;

            //Plural Name
            AutoCompleteStringCollection pNames = new AutoCompleteStringCollection();
            pNames.AddRange(MKV_Main.ac_ingredient_plural_name.ToArray());
            ingredientPNameBox.AutoCompleteCustomSource = pNames;

            //Units
            AutoCompleteStringCollection units = new AutoCompleteStringCollection();
            units.AddRange(MKV_Main.ac_unit_name.ToArray());
            ingredientUnitBox.AutoCompleteCustomSource = units;

            NamePairs = MKV_Main.ac_name_pairs;
        }

        /// <summary>
        /// Updates the internal Ingredient object (fired when text is changed on any text box)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void TextBox_Text_Changed(object sender, EventArgs e)
        {
            string name = null;
            string pName = null;
            decimal quantity;
            string unit;

            if(ingredientNameBox.Text.Length > 0)
            {
                name = ingredientNameBox.Text.ToLower();
            }

            if(ingredientPNameBox.Text.Length > 0)
            {
                pName = ingredientPNameBox.Text.ToLower();
            }

            if(!Decimal.TryParse(ingredientQtyBox.Text, out decimal qty))
            {
                try
                {
                    qty = Util_FractionConverter.ToDecimal(ingredientQtyBox.Text);
                }
                catch
                {
                    qty = 0.0M;
                }
            }
            quantity = qty;


            if(ingredientUnitBox.Text.Length > 0)
            {
               unit = ingredientUnitBox.Text.ToLower();
            }
            else
            {
                unit = "qty";
            }

            if(name != null && quantity > 0)
            {
                BuildIngredient(name, pName, quantity, unit);
                nameErrorLabel.Visible = false;
                qtyErrorLabel.Visible = false;
            }
            else
            {
                if(name == null)
                {
                    nameErrorLabel.Visible = true;
                }
                else
                {
                    nameErrorLabel.Visible = false;
                }

                if(quantity <= 0)
                {
                    qtyErrorLabel.Visible = true;
                }
                else
                {
                    qtyErrorLabel.Visible = false;
                }

                OutputIngredient = null;
            }
        }

        /// <summary>
        /// Sets local data into the Ingredient attribute of the form
        /// </summary>
        /// <param name="name">Ingredient name</param>
        /// <param name="pName">Plural ingredient name</param>
        /// <param name="quantity">Quantity as a decimal</param>
        /// <param name="unit">Unit of measurement</param>
        private void BuildIngredient(string name, string pName, decimal quantity, string unit)
        {
            if (OutputIngredient == null)
            {
                OutputIngredient = new Ingredient(name, quantity, unit, pName);
            }
            else
            {
                OutputIngredient.Name = name;
                OutputIngredient.PluralName = pName;
                OutputIngredient.Quantity = quantity;
                OutputIngredient.Unit = unit;
            }
        }

        /// <summary>
        /// Closes the form to remove it (fires when the "Remove" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event Arguments</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            this.Close();
        }

        /// <summary>
        /// Automatically fills in the plural name for an ingredient if one exists in the database (fired when focus is removed from the ingredient name box)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void IngredientNameBox_Leave(object sender, EventArgs e)
        {
            string name = ingredientNameBox.Text;

            if (NamePairs.ContainsKey(name))
            {
                ingredientPNameBox.Text = NamePairs[name];
                ingredientQtyBox.Focus();
            }
        }
    }
}
