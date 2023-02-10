using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SH = MyKitchenVault.Util_SettingsHandler;

namespace MyKitchenVault
{
    public partial class MKV_Main : Form
    {
        public static User user;
        
        //Autocomplete Lists
        public static List<string> ac_recipe_name;
        public static List<string> ac_ingredient_name;
        public static List<string> ac_ingredient_plural_name;
        public static List<string> ac_unit_name;
        public static List<string> ac_all_tags;
        public static Dictionary<string, string> ac_name_pairs;

        //Filter Tag Options
        public static List<string> includeTags = null;
        public static List<string> excludeTags = null;
        public static int rating = 0;
        public static FilterStyle filterStyle = FilterStyle.none;

        public MKV_Main()
        {
            InitializeComponent();
            DisableControls();
            GetAutocompleteLists();
        }

        /// <summary>
        /// Opens login menu (fired when "log in" menu item is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void Log_In_MenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new MKV_LoginForm())
            {
                var results = form.ShowDialog();
                if (results == DialogResult.OK)
                {
                    user = new User(form.Username, form.User_Id);
                    UsernameLabel.Text = ($"Signed in as {user.GetUsername()} (user id # {user.GetUserID()}).");
                    EnableControls();
                }
            }
        }

        /// <summary>
        /// Logs out active user (fired when "log out" menu item is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void LogOutMenuItem_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                var confirmLogout = MessageBox.Show("Are you sure you want to log out?\nUnsaved changes will be lost!", "Confirm", MessageBoxButtons.YesNo);
                if (confirmLogout == DialogResult.Yes)
                {
                    user = null;
                    UsernameLabel.Text = "(Not signed in)";
                    ClearFilters();
                    RecipeGrid.Rows.Clear();
                    searchBox.Text = "Recipe Search";
                    DisableControls();
                }
            }
            else
            {
                MessageBox.Show("No user signed in.", "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Populates favorites into recipeGrid (fired when "favorites" menu item is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void FavoritesMenuItem_Click(object sender, EventArgs e)
        {
            List<(string, string, int)> searchResults = Util_DBInterface.GetFavs(SH.GetSettings(user.GetUserID()).Item1);

            if (searchResults.Count > 0)
            {
                SetSearchResults(searchResults);

            }
            else
            {
                SetSearchResults(new List<(string, string, int)> { ("NO FAVORITES FOUND", "", 0) });
            }
        }

        /// <summary>
        /// Opens blacklist menu (fired when the "ingredient blacklist" menu item is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void IngredientBlacklistMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new MKV_TagSelectorForm("Blacklist", SH.StringToList(SH.GetSettings(user.GetUserID()).Item2)))
            {
                var results = form.ShowDialog();
                if (results == DialogResult.OK)
                {
                    if (form.Current != null && form.Current.Count > 0)
                    {
                        SH.AddBL(user.GetUserID(), form.Current);
                    }
                    if (form.Removed != null && form.Removed.Count > 0)
                    {
                        SH.RemoveBL(user.GetUserID(), form.Removed);
                    }
                }
            }
        }

        /// <summary>
        /// Clears text from search box (fired when search box is clicked) 
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void SearchBox_Click(object sender, EventArgs e)
        {
            searchBox.Text = string.Empty;
        }        

        /// <summary>
        /// Clears search and filter data from the form (fired when the "clear" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to clear\nsearch settings?","Clear Search Screen?", MessageBoxButtons.YesNo);
            if(response == DialogResult.Yes)
            {
                ClearFilters();
                RecipeGrid.Rows.Clear();
                searchBox.Text = "Recipe Search";
            }
        }

        /// <summary>
        /// Opens the filter form and sets filter information on accepting (fired when "filters" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void FiltersButton_Click(object sender, EventArgs e)
        {
            using (var form = new MKV_FiltersForm())
            {
                var results = form.ShowDialog();
                if (results == DialogResult.OK)
                {
                    includeTags = form.IncludeTags;
                    excludeTags = form.ExcludeTags;
                    filterStyle = form.FilterStyle;
                    rating = form.Rating;

                    CheckForFilters();
                }
                else if(results == DialogResult.Cancel)
                {
                    ClearFilters();
                }
            }
        }

        /// <summary>
        /// Prompts user to ask if they want to close the application (fired when the application is attempting to be closed)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void Mkv_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the application?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        /// <summary>
        /// Refreshes autocomplete lists (fired when the "refresh autocomplete lists" menu item is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void RefreshAutocompleteListsMenuItem_Click(object sender, EventArgs e)
        {
            GetAutocompleteLists();
        }

        /// <summary>
        /// Performs search based on selected search and filter criteria (fired when the "search" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<string> excludeList = excludeTags;

            if(SH.GetSettings(user.GetUserID()).Item2.Length > 0)
            {
                Console.WriteLine(SH.GetSettings(user.GetUserID()).Item2);
                List<string> blacklist = SH.StringToList(SH.GetSettings(user.GetUserID()).Item2);


                if(excludeList == null)
                {
                    excludeList = blacklist;
                }
                else
                {
                    excludeList.AddRange(blacklist);
                }
            }

            RecipeGrid.Rows.Clear();

            string search = null;

            if(searchBox.Text != "Recipe Search")
            {
                search = searchBox.Text;
            }

            List<(string, string, int)> searchResults = Util_DBInterface.Search(search, includeTags, excludeList, rating, filterStyle);

            if(searchResults.Count > 0)
            {
                SetSearchResults(searchResults);
            }
            else
            {
                SetSearchResults(new List<(string, string, int)> { ("NO RESULTS FOUND", "", 0) });
            }
        }

        /// <summary>
        /// Sets data in recipeGrid
        /// </summary>
        /// <param name="input">Recipe data as a tuple (name, description, recipe ID)</param>
        private void SetSearchResults(List<(string, string, int)> input)
        {
            RecipeGrid.Rows.Clear();
            foreach (var item in input)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(RecipeGrid);
                newRow.Cells[0].Value = item.Item1;
                newRow.Cells[1].Value = item.Item2;
                newRow.Cells[2].Value = item.Item3;
                RecipeGrid.Rows.Add(newRow);
            }
        }

        /// <summary>
        /// Opens "add recipe" form (fired when the "add recipe" menu item is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void AddRecipeMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new CreateRecipeForm())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Opens selected recipe (fired when the "select" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (RecipeGrid.SelectedRows.Count > 0)
            {
                int recipieID = (int)RecipeGrid.CurrentRow.Cells[2].Value;
                if(recipieID != 0)
                {
                    MKV_RecipeViewForm recipe = new MKV_RecipeViewForm(Util_DBInterface.GetRecipe(recipieID));
                    recipe.Show();
                }
            }
        }

        /// <summary>
        /// Opens selected recipe (fired when a recipeGrid item is double clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void RecipeGrid_Double_Click(object sender, EventArgs e)
        {
            selectButton.PerformClick();
        }

        /// <summary>
        /// Checks for filters and displays or hides the "filters applied" label text as appropriate
        /// </summary>
        private void CheckForFilters()
        {
            if(includeTags != null || excludeTags != null || rating != 0)
            {
                filterStatusLabel.Visible = true;
            }
            else
            {
                filterStatusLabel.Visible = false;
            }
        }

        /// <summary>
        /// Clears filter variables
        /// </summary>
        private void ClearFilters()
        {
            includeTags = null;
            excludeTags = null;
            filterStyle = FilterStyle.none;
            rating = 0;

            CheckForFilters();
        }

        /// <summary>
        /// Disables all controls except the "account" menu for when users are not logged in
        /// </summary>
        private void DisableControls()
        {
            foreach (Control item in this.Controls)
            {
                if (!(item is MenuStrip))
                {
                    item.Enabled = false;
                }
            }
            LogInMenuItem.Enabled = true;
            LogOutMenuItem.Enabled = false;
            RecipesMenu.Enabled = false;
            SettingsMenu.Enabled = false;
            titleLabel.Enabled = true;
        }

        /// <summary>
        /// Enables controls for when users log in
        /// </summary>
        private void EnableControls()
        {
            foreach (Control item in this.Controls)
            {
                if (!(item is MenuStrip))
                {
                    item.Enabled = true;
                }
            }
            LogInMenuItem.Enabled = false;
            LogOutMenuItem.Enabled = true;
            RecipesMenu.Enabled = true;
            SettingsMenu.Enabled = true;
        }

        /// <summary>
        /// Gets or refreshes lists for autocomplete purposes
        /// </summary>
        private void GetAutocompleteLists()
        {
            (List<string>, List<string>, List<string>, List<string>, List<string>, Dictionary<string, string>) Lists = Util_DBInterface.GetAutocompleteLists();

            ac_recipe_name = Lists.Item1;
            ac_ingredient_name = Lists.Item2;
            ac_ingredient_plural_name = Lists.Item3;
            ac_unit_name = Lists.Item4;
            ac_all_tags = Lists.Item5;
            ac_name_pairs = Lists.Item6;
        }

    }

}
