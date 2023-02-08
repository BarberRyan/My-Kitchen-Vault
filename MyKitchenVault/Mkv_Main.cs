using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SH = MyKitchenVault.SettingsHandler;

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
        public static int rating = 0;
        public static FilterStyle filterStyle = FilterStyle.none;

        public Mkv_Main()
        {
            InitializeComponent();
            //DisableControls();
            GetAutocompleteLists();
            user = new User("Meoco55", 2);
        }

        /// <summary>
        /// Opens login menu (fired when "log in" menu item is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
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
                    recipeBox.Items.Clear();
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
        /// Clears text from search box (fired when search box is clicked) 
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void SearchBox_Click(object sender, EventArgs e)
        {
            searchBox.Text = string.Empty;
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
        /// Clears search and filter data from the form (fired when the "clear" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to clear?","Clear Search Screen?", MessageBoxButtons.YesNo);
            if(response == DialogResult.Yes)
            {
                ClearFilters();
                recipeBox.Items.Clear();
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
            using (var form = new Filters_Form())
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

            recipeBox.Items.Clear();

            string search = null;

            if(searchBox.Text != "Recipe Search")
            {
                search = searchBox.Text;
            }

            List<(string, string, int)> searchResults = DB_Interface.Search(search, includeTags, excludeList, rating, filterStyle);

            if(searchResults.Count > 0)
            {
                foreach(var item in searchResults)
                {
                    recipeBox.Items.Add($"{item.Item1} - {item.Item2} ({item.Item3})");
                }
            }
            else
            {
                recipeBox.Items.Add("NO RESULTS FOUND");
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
            RecipesMenu.Enabled = true;
            SettingsMenu.Enabled = true;
        }

        /// <summary>
        /// Gets or refreshes lists for autocomplete purposes
        /// </summary>
        private void GetAutocompleteLists()
        {
            (List<string>, List<string>, List<string>, List<string>, List<string>) Lists = DB_Interface.GetAutocompleteLists();

            ac_recipe_name = Lists.Item1;
            ac_ingredient_name = Lists.Item2;
            ac_ingredient_plural_name = Lists.Item3;
            ac_unit_name = Lists.Item4;
            ac_all_tags = Lists.Item5;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if(recipeBox.SelectedItems.Count > 0)
            {
                try
                {
                    string item = recipeBox.SelectedItem.ToString();
                    int startIndex = item.LastIndexOf('(') + 1;
                    int length = item.LastIndexOf(')') - startIndex;
                    string numberString = item.Substring(startIndex, length);
                    int number = int.Parse(numberString);

                    RecipeView recipe = new RecipeView(DB_Interface.GetRecipe(number));
                    recipe.Show();
                }
                catch { }
            }
        }

        private void FavoritesMenuItem_Click(object sender, EventArgs e)
        {
            List<(string, string, int)> searchResults = DB_Interface.GetFavs(SH.GetSettings(user.GetUserID()).Item1);
            
            if (searchResults.Count > 0)
            {
                recipeBox.Items.Clear();
                foreach (var item in searchResults)
                {
                    recipeBox.Items.Add($"{item.Item1} - {item.Item2} ({item.Item3})");
                }
            }
            else
            {
                recipeBox.Items.Clear();
                recipeBox.Items.Add("NO FAVORITES FOUND");
            }
        }

        private void IngredientBlacklistMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new TagSelector("Blacklist", SH.StringToList(SH.GetSettings(user.GetUserID()).Item2)))
            {
                var results = form.ShowDialog();
                if(results == DialogResult.OK)
                {
                    if(form.Current != null && form.Current.Count > 0)
                    {
                        SH.AddBL(user.GetUserID(), form.Current);
                    }
                    if(form.Removed != null && form.Removed.Count > 0)
                    {
                        SH.RemoveBL(user.GetUserID(), form.Removed);
                    }
                }
            }
        }
    }

}
