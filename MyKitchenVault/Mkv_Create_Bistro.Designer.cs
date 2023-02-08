namespace MyKitchenVault
{
    partial class CreateRecipeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRecipeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.instructionsBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ingredientBox = new System.Windows.Forms.TextBox();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.editIngredientsButton = new System.Windows.Forms.Button();
            this.editTagsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.prepTimeBox = new System.Windows.Forms.TextBox();
            this.cookTimeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(203, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a Recipe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Of Dish";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(626, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingredients";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.nameBox.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.SystemColors.Info;
            this.nameBox.Location = new System.Drawing.Point(56, 121);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(163, 30);
            this.nameBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(319, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 47);
            this.label4.TabIndex = 5;
            this.label4.Text = "Instructions";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Green;
            this.submitButton.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.Info;
            this.submitButton.Location = new System.Drawing.Point(11, 415);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(109, 37);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DarkRed;
            this.cancelButton.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.cancelButton.Location = new System.Drawing.Point(144, 415);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(109, 37);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // instructionsBox
            // 
            this.instructionsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.instructionsBox.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.instructionsBox.ForeColor = System.Drawing.SystemColors.Info;
            this.instructionsBox.Location = new System.Drawing.Point(275, 117);
            this.instructionsBox.Multiline = true;
            this.instructionsBox.Name = "instructionsBox";
            this.instructionsBox.Size = new System.Drawing.Size(286, 231);
            this.instructionsBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(39, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 47);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.descriptionBox.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.descriptionBox.ForeColor = System.Drawing.SystemColors.Info;
            this.descriptionBox.Location = new System.Drawing.Point(42, 238);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(191, 98);
            this.descriptionBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(626, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 47);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tags";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ingredientBox
            // 
            this.ingredientBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.ingredientBox.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.ingredientBox.ForeColor = System.Drawing.SystemColors.Info;
            this.ingredientBox.Location = new System.Drawing.Point(629, 151);
            this.ingredientBox.Multiline = true;
            this.ingredientBox.Name = "ingredientBox";
            this.ingredientBox.ReadOnly = true;
            this.ingredientBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ingredientBox.Size = new System.Drawing.Size(191, 102);
            this.ingredientBox.TabIndex = 13;
            // 
            // tagBox
            // 
            this.tagBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.tagBox.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.tagBox.ForeColor = System.Drawing.SystemColors.Info;
            this.tagBox.Location = new System.Drawing.Point(629, 354);
            this.tagBox.Multiline = true;
            this.tagBox.Name = "tagBox";
            this.tagBox.ReadOnly = true;
            this.tagBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagBox.Size = new System.Drawing.Size(191, 98);
            this.tagBox.TabIndex = 14;
            // 
            // editIngredientsButton
            // 
            this.editIngredientsButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editIngredientsButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editIngredientsButton.ForeColor = System.Drawing.SystemColors.Info;
            this.editIngredientsButton.Location = new System.Drawing.Point(667, 121);
            this.editIngredientsButton.Name = "editIngredientsButton";
            this.editIngredientsButton.Size = new System.Drawing.Size(114, 23);
            this.editIngredientsButton.TabIndex = 15;
            this.editIngredientsButton.Text = "Edit Ingredients";
            this.editIngredientsButton.UseVisualStyleBackColor = false;
            this.editIngredientsButton.Click += new System.EventHandler(this.EditIngredientsButton_Click);
            // 
            // editTagsButton
            // 
            this.editTagsButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editTagsButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTagsButton.ForeColor = System.Drawing.SystemColors.Info;
            this.editTagsButton.Location = new System.Drawing.Point(667, 325);
            this.editTagsButton.Name = "editTagsButton";
            this.editTagsButton.Size = new System.Drawing.Size(114, 23);
            this.editTagsButton.TabIndex = 16;
            this.editTagsButton.Text = "Edit Tags";
            this.editTagsButton.UseVisualStyleBackColor = false;
            this.editTagsButton.Click += new System.EventHandler(this.EditTagsButton_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(275, 354);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 47);
            this.label7.TabIndex = 17;
            this.label7.Text = "Prep Time";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(415, 354);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 47);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cook Time";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prepTimeBox
            // 
            this.prepTimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.prepTimeBox.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepTimeBox.ForeColor = System.Drawing.SystemColors.Info;
            this.prepTimeBox.Location = new System.Drawing.Point(275, 415);
            this.prepTimeBox.Margin = new System.Windows.Forms.Padding(2);
            this.prepTimeBox.Name = "prepTimeBox";
            this.prepTimeBox.Size = new System.Drawing.Size(136, 30);
            this.prepTimeBox.TabIndex = 19;
            // 
            // cookTimeBox
            // 
            this.cookTimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.cookTimeBox.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookTimeBox.ForeColor = System.Drawing.SystemColors.Info;
            this.cookTimeBox.Location = new System.Drawing.Point(415, 415);
            this.cookTimeBox.Margin = new System.Windows.Forms.Padding(2);
            this.cookTimeBox.Name = "cookTimeBox";
            this.cookTimeBox.Size = new System.Drawing.Size(146, 30);
            this.cookTimeBox.TabIndex = 20;
            // 
            // CreateRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 477);
            this.Controls.Add(this.cookTimeBox);
            this.Controls.Add(this.prepTimeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editTagsButton);
            this.Controls.Add(this.editIngredientsButton);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(this.ingredientBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.instructionsBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateRecipeForm";
            this.Text = "Create a Recipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox instructionsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ingredientBox;
        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.Button editIngredientsButton;
        private System.Windows.Forms.Button editTagsButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox prepTimeBox;
        private System.Windows.Forms.TextBox cookTimeBox;
    }
}