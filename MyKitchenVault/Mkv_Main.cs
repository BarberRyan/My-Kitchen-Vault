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
    public partial class Mkv_Main : Form
    {
        public static User user;
        
        //Autocomplete Lists
        public static List<string> ac_recipe_name;
        public static List<string> ac_ingredient_name;
        public static List<string> ac_ingredient_plural_name;
        public static List<string> ac_unit_name;
        public static List<string> ac_all_tags;

        //Filter Tag Options
        public static List<string> includeTags = null;
        public static List<string> excludeTags = null;
        public static FilterStyle filterStyle = FilterStyle.none;

        public Mkv_Main()
        {
            InitializeComponent();
            DisableControls();
            GetAutocompleteLists();
        }

        private void Log_In_MenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Login_Form())
            {
                var results = form.ShowDialog();
                if (results == DialogResult.OK)
                {
                    user = new User(form.Username, form.User_Id);
                    MessageBox.Show($"Successfully signed in as {user.GetUsername()}.");
                    UsernameLabel.Text = ($"Signed in as {user.GetUsername()} (user id # {user.GetUserID()}).");
                    foreach (Control item in this.Controls)
                    {
                            item.Enabled = true;
                    }
                }
            }
        }

        private void DisableControls()
        {
            foreach (Control item in this.Controls)
            {
                if (!(item is MenuStrip))
                {
                    item.Enabled = false;
                }
            }
            RecipesMenu.Enabled = false;
            SettingsMenu.Enabled = false;
        }

        private void GetAutocompleteLists()
        {
            (List<string>, List<string>, List<string>, List<string>) Lists = DB_Interface.GetAutocompleteLists();

            ac_recipe_name = Lists.Item1;
            ac_ingredient_name = Lists.Item2;
            ac_ingredient_plural_name = Lists.Item3;
            ac_unit_name = Lists.Item4;
            ac_all_tags = DB_Interface.GetTagList();
        }

        private void LogOutMenuItem_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                var confirmLogout = MessageBox.Show("Are you sure you want to log out?\nUnsaved changes will be lost!", "Confirm", MessageBoxButtons.YesNo);
                if (confirmLogout == DialogResult.Yes)
                {
                    user = null;
                    UsernameLabel.Text = "(Not signed in)";
                    DisableControls();
                }
            }
            else
            {
                MessageBox.Show("No user signed in.", "Error", MessageBoxButtons.OK);
            }
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
          searchBox.Text = string.Empty;
        }

        private void Mkv_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the application?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to clear","Clear Screen", MessageBoxButtons.YesNo);
        }

        private void FiltersButton_Click(object sender, EventArgs e)
        {
            using (var form = new Filters_Form())
            {
                var results = form.ShowDialog();
                if (results == DialogResult.OK)
                {
                    includeTags = form.IncludeTags;
                    excludeTags = form.ExcludeTags;
                    filterStyle = form.FilterStyle;

                    CheckForFilters();
                }
                else if(results == DialogResult.Cancel)
                {
                    includeTags = null;
                    excludeTags = null;
                    filterStyle = FilterStyle.none;

                    CheckForFilters();
                }
            }
        }

        private void RefreshAutocompleteListsMenuItem_Click(object sender, EventArgs e)
        {
            GetAutocompleteLists();
        }

        private void CheckForFilters()
        {
            if(includeTags != null || excludeTags != null)
            {
                filterStatusLabel.Visible = true;
            }
            else
            {
                filterStatusLabel.Visible = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            recipeBox.Items.Clear();

            bool partial = true;
            bool only = false;
            string search = null;

            if(filterStyle == FilterStyle.matchAny)
            {
                partial = true;
            }
            else if (filterStyle == FilterStyle.includeOnlySelected)
            {
                only = true;
                partial = false;
            }

            if(searchBox.Text != "Recipe Search")
            {
                search = searchBox.Text;
            }

            List<(string, string, int)> searchResults = DB_Interface.Search(search, includeTags, excludeTags, partial, only);

            if(searchResults.Count > 0)
            {
                foreach(var item in searchResults)
                {
                    recipeBox.Items.Add($"{item.Item1} - {item.Item2}");
                }
            }
            else
            {
                recipeBox.Items.Add("NO RESULTS FOUND");
            }
        }
    }

}
