namespace MyKitchenVault
{
    partial class MKV_IngredientSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MKV_IngredientSelectorForm));
            this.ingredientPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ingredientPanel
            // 
            this.ingredientPanel.AutoScroll = true;
            this.ingredientPanel.Location = new System.Drawing.Point(12, 34);
            this.ingredientPanel.Name = "ingredientPanel";
            this.ingredientPanel.Size = new System.Drawing.Size(776, 275);
            this.ingredientPanel.TabIndex = 0;
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addIngredientButton.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngredientButton.ForeColor = System.Drawing.SystemColors.Info;
            this.addIngredientButton.Location = new System.Drawing.Point(13, 5);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(134, 23);
            this.addIngredientButton.TabIndex = 1;
            this.addIngredientButton.Text = "Add Ingredient";
            this.addIngredientButton.UseVisualStyleBackColor = false;
            this.addIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.acceptButton.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.ForeColor = System.Drawing.SystemColors.Info;
            this.acceptButton.Location = new System.Drawing.Point(13, 315);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(69, 23);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelButton.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.cancelButton.Location = new System.Drawing.Point(88, 315);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(72, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MKV_IngredientSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.addIngredientButton);
            this.Controls.Add(this.ingredientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MKV_IngredientSelectorForm";
            this.Text = "Select Ingredients";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ingredientPanel;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
    }
}