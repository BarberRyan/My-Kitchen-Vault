
using System;
using System.Drawing;

namespace MyKitchenVault
{
    partial class SearchBox
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

        protected void Mkv_Main_Load(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(100, 0, 0, 0);
            panel1.BackColor = color;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBox));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AccountMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LogInMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecipesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FavoritesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRecipeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.IngredientBlacklistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.FiltersButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(250, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Kitchen Vault";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(315, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 30);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Recipe Search";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.AutoSize = true;
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchButton.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.Info;
            this.SearchButton.Location = new System.Drawing.Point(446, 291);
            this.SearchButton.MinimumSize = new System.Drawing.Size(100, 40);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 40);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
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
            this.LogInMenuItem.Size = new System.Drawing.Size(180, 26);
            this.LogInMenuItem.Text = "Log in";
            this.LogInMenuItem.Click += new System.EventHandler(this.Log_In_MenuItem_Click);
            // 
            // LogOutMenuItem
            // 
            this.LogOutMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.LogOutMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.LogOutMenuItem.Name = "LogOutMenuItem";
            this.LogOutMenuItem.Size = new System.Drawing.Size(180, 26);
            this.LogOutMenuItem.Text = "Log out";
            this.LogOutMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
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
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngredientBlacklistMenuItem});
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
            this.IngredientBlacklistMenuItem.Size = new System.Drawing.Size(269, 26);
            this.IngredientBlacklistMenuItem.Text = "Ingredient  Blacklist";
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
            this.FiltersButton.Location = new System.Drawing.Point(446, 223);
            this.FiltersButton.MaximumSize = new System.Drawing.Size(100, 40);
            this.FiltersButton.MinimumSize = new System.Drawing.Size(100, 40);
            this.FiltersButton.Name = "FiltersButton";
            this.FiltersButton.Size = new System.Drawing.Size(100, 40);
            this.FiltersButton.TabIndex = 11;
            this.FiltersButton.Text = "Filters";
            this.FiltersButton.UseVisualStyleBackColor = false;
            // 
            // SelectButton
            // 
            this.SelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectButton.AutoSize = true;
            this.SelectButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SelectButton.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.ForeColor = System.Drawing.SystemColors.Info;
            this.SelectButton.Location = new System.Drawing.Point(446, 485);
            this.SelectButton.MaximumSize = new System.Drawing.Size(100, 40);
            this.SelectButton.MinimumSize = new System.Drawing.Size(100, 40);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(100, 40);
            this.SelectButton.TabIndex = 13;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(315, 359);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.MinimumSize = new System.Drawing.Size(372, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 106);
            this.panel1.TabIndex = 14;
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.FiltersButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1031, 648);
            this.Name = "SearchBox";
            this.Text = "My Kitchen Vault";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AccountMenu;
        private System.Windows.Forms.ToolStripMenuItem LogInMenuItem;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.ToolStripMenuItem LogOutMenuItem;
        private System.Windows.Forms.Button FiltersButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem RecipesMenu;
        private System.Windows.Forms.ToolStripMenuItem FavoritesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddRecipeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem IngredientBlacklistMenuItem;
    }
}

