
using System;
using System.Drawing;

namespace MyKitchenVault
{
    partial class Mkv_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mkv_Main));
            this.titleLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AccountMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LogInMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecipesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FavoritesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRecipeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.IngredientBlacklistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshAutocompleteListsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.FiltersButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.recipeBox = new System.Windows.Forms.ListBox();
            this.filterStatusLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.CausesValidation = false;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.titleLabel.Location = new System.Drawing.Point(250, 89);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(503, 63);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "My Kitchen Vault";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.Info;
            this.searchBox.Location = new System.Drawing.Point(315, 161);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(373, 26);
            this.searchBox.TabIndex = 5;
            this.searchBox.Text = "Recipe Search";
            this.searchBox.Click += new System.EventHandler(this.SearchBox_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.AutoSize = true;
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchButton.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.Info;
            this.searchButton.Location = new System.Drawing.Point(344, 291);
            this.searchButton.MinimumSize = new System.Drawing.Size(100, 40);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 40);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountMenu,
            this.RecipesMenu,
            this.SettingsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 40);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1015, 40);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AccountMenu
            // 
            this.AccountMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogInMenuItem,
            this.LogOutMenuItem});
            this.AccountMenu.ForeColor = System.Drawing.SystemColors.Info;
            this.AccountMenu.Name = "AccountMenu";
            this.AccountMenu.Size = new System.Drawing.Size(96, 36);
            this.AccountMenu.Text = "Account";
            // 
            // LogInMenuItem
            // 
            this.LogInMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.LogInMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.LogInMenuItem.Name = "LogInMenuItem";
            this.LogInMenuItem.Size = new System.Drawing.Size(148, 26);
            this.LogInMenuItem.Text = "Log in";
            this.LogInMenuItem.Click += new System.EventHandler(this.Log_In_MenuItem_Click);
            // 
            // LogOutMenuItem
            // 
            this.LogOutMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.LogOutMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.LogOutMenuItem.Name = "LogOutMenuItem";
            this.LogOutMenuItem.Size = new System.Drawing.Size(148, 26);
            this.LogOutMenuItem.Text = "Log out";
            this.LogOutMenuItem.Click += new System.EventHandler(this.LogOutMenuItem_Click);
            // 
            // RecipesMenu
            // 
            this.RecipesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FavoritesMenuItem,
            this.AddRecipeMenuItem});
            this.RecipesMenu.ForeColor = System.Drawing.SystemColors.Info;
            this.RecipesMenu.Name = "RecipesMenu";
            this.RecipesMenu.Size = new System.Drawing.Size(86, 36);
            this.RecipesMenu.Text = "Recipes";
            // 
            // FavoritesMenuItem
            // 
            this.FavoritesMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.FavoritesMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.FavoritesMenuItem.Name = "FavoritesMenuItem";
            this.FavoritesMenuItem.Size = new System.Drawing.Size(185, 26);
            this.FavoritesMenuItem.Text = "Favorites";
            // 
            // AddRecipeMenuItem
            // 
            this.AddRecipeMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.AddRecipeMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.AddRecipeMenuItem.Name = "AddRecipeMenuItem";
            this.AddRecipeMenuItem.Size = new System.Drawing.Size(185, 26);
            this.AddRecipeMenuItem.Text = "Add  Recipe";
            this.AddRecipeMenuItem.Click += new System.EventHandler(this.AddRecipeMenuItem_Click);
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngredientBlacklistMenuItem,
            this.refreshAutocompleteListsMenuItem});
            this.SettingsMenu.ForeColor = System.Drawing.SystemColors.Info;
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.Size = new System.Drawing.Size(92, 36);
            this.SettingsMenu.Text = "Settings";
            // 
            // IngredientBlacklistMenuItem
            // 
            this.IngredientBlacklistMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.IngredientBlacklistMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.IngredientBlacklistMenuItem.Name = "IngredientBlacklistMenuItem";
            this.IngredientBlacklistMenuItem.Size = new System.Drawing.Size(315, 26);
            this.IngredientBlacklistMenuItem.Text = "Ingredient  Blacklist";
            // 
            // refreshAutocompleteListsMenuItem
            // 
            this.refreshAutocompleteListsMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.refreshAutocompleteListsMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.refreshAutocompleteListsMenuItem.Name = "refreshAutocompleteListsMenuItem";
            this.refreshAutocompleteListsMenuItem.Size = new System.Drawing.Size(315, 26);
            this.refreshAutocompleteListsMenuItem.Text = "Refresh Autocomplete Lists";
            this.refreshAutocompleteListsMenuItem.Click += new System.EventHandler(this.RefreshAutocompleteListsMenuItem_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.UsernameLabel.Location = new System.Drawing.Point(311, 145);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(381, 13);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "(Not signed in)";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FiltersButton
            // 
            this.FiltersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltersButton.AutoSize = true;
            this.FiltersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FiltersButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FiltersButton.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltersButton.ForeColor = System.Drawing.SystemColors.Info;
            this.FiltersButton.Location = new System.Drawing.Point(451, 197);
            this.FiltersButton.MaximumSize = new System.Drawing.Size(100, 40);
            this.FiltersButton.MinimumSize = new System.Drawing.Size(100, 40);
            this.FiltersButton.Name = "FiltersButton";
            this.FiltersButton.Size = new System.Drawing.Size(100, 40);
            this.FiltersButton.TabIndex = 11;
            this.FiltersButton.Text = "Filters";
            this.FiltersButton.UseVisualStyleBackColor = false;
            this.FiltersButton.Click += new System.EventHandler(this.FiltersButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButton.AutoSize = true;
            this.selectButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectButton.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.ForeColor = System.Drawing.SystemColors.Info;
            this.selectButton.Location = new System.Drawing.Point(451, 490);
            this.selectButton.MaximumSize = new System.Drawing.Size(100, 40);
            this.selectButton.MinimumSize = new System.Drawing.Size(100, 40);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(100, 40);
            this.selectButton.TabIndex = 13;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.AutoSize = true;
            this.clearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.clearButton.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.Info;
            this.clearButton.Location = new System.Drawing.Point(558, 291);
            this.clearButton.MinimumSize = new System.Drawing.Size(100, 40);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 40);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // recipeBox
            // 
            this.recipeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.recipeBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeBox.ForeColor = System.Drawing.SystemColors.Info;
            this.recipeBox.FormattingEnabled = true;
            this.recipeBox.HorizontalScrollbar = true;
            this.recipeBox.ItemHeight = 18;
            this.recipeBox.Location = new System.Drawing.Point(344, 337);
            this.recipeBox.Name = "recipeBox";
            this.recipeBox.Size = new System.Drawing.Size(314, 130);
            this.recipeBox.TabIndex = 16;
            // 
            // filterStatusLabel
            // 
            this.filterStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.filterStatusLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.filterStatusLabel.Location = new System.Drawing.Point(451, 240);
            this.filterStatusLabel.Name = "filterStatusLabel";
            this.filterStatusLabel.Size = new System.Drawing.Size(100, 13);
            this.filterStatusLabel.TabIndex = 17;
            this.filterStatusLabel.Text = "Filters Applied";
            this.filterStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.filterStatusLabel.Visible = false;
            // 
            // Mkv_Main
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 609);
            this.Controls.Add(this.filterStatusLabel);
            this.Controls.Add(this.recipeBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.FiltersButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1022, 597);
            this.Name = "Mkv_Main";
            this.Text = "My Kitchen Vault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mkv_Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AccountMenu;
        private System.Windows.Forms.ToolStripMenuItem LogInMenuItem;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.ToolStripMenuItem LogOutMenuItem;
        private System.Windows.Forms.Button FiltersButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.ToolStripMenuItem RecipesMenu;
        private System.Windows.Forms.ToolStripMenuItem FavoritesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddRecipeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem IngredientBlacklistMenuItem;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ToolStripMenuItem refreshAutocompleteListsMenuItem;
        private System.Windows.Forms.ListBox recipeBox;
        private System.Windows.Forms.Label filterStatusLabel;
    }
}

