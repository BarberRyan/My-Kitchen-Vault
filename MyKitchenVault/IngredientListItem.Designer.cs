namespace MyKitchenVault
{
    partial class IngredientListItem
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
            this.ingredientNameBox = new System.Windows.Forms.TextBox();
            this.ingredientQtyBox = new System.Windows.Forms.TextBox();
            this.ingredientPNameBox = new System.Windows.Forms.TextBox();
            this.ingredientUnitBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ingredientNameBox
            // 
            this.ingredientNameBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ingredientNameBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientNameBox.ForeColor = System.Drawing.SystemColors.Info;
            this.ingredientNameBox.Location = new System.Drawing.Point(12, 22);
            this.ingredientNameBox.Name = "ingredientNameBox";
            this.ingredientNameBox.Size = new System.Drawing.Size(100, 23);
            this.ingredientNameBox.TabIndex = 0;
            this.ingredientNameBox.TextChanged += new System.EventHandler(this.TextBox_Text_Changed);
            // 
            // ingredientQtyBox
            // 
            this.ingredientQtyBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ingredientQtyBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientQtyBox.ForeColor = System.Drawing.SystemColors.Info;
            this.ingredientQtyBox.Location = new System.Drawing.Point(224, 22);
            this.ingredientQtyBox.Name = "ingredientQtyBox";
            this.ingredientQtyBox.Size = new System.Drawing.Size(100, 23);
            this.ingredientQtyBox.TabIndex = 1;
            this.ingredientQtyBox.TextChanged += new System.EventHandler(this.TextBox_Text_Changed);
            // 
            // ingredientPNameBox
            // 
            this.ingredientPNameBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ingredientPNameBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientPNameBox.ForeColor = System.Drawing.SystemColors.Info;
            this.ingredientPNameBox.Location = new System.Drawing.Point(118, 22);
            this.ingredientPNameBox.Name = "ingredientPNameBox";
            this.ingredientPNameBox.Size = new System.Drawing.Size(100, 23);
            this.ingredientPNameBox.TabIndex = 2;
            this.ingredientPNameBox.TextChanged += new System.EventHandler(this.TextBox_Text_Changed);
            // 
            // ingredientUnitBox
            // 
            this.ingredientUnitBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ingredientUnitBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientUnitBox.ForeColor = System.Drawing.SystemColors.Info;
            this.ingredientUnitBox.Location = new System.Drawing.Point(330, 22);
            this.ingredientUnitBox.Name = "ingredientUnitBox";
            this.ingredientUnitBox.Size = new System.Drawing.Size(100, 23);
            this.ingredientUnitBox.TabIndex = 3;
            this.ingredientUnitBox.TextChanged += new System.EventHandler(this.TextBox_Text_Changed);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.removeButton.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.removeButton.ForeColor = System.Drawing.SystemColors.Info;
            this.removeButton.Location = new System.Drawing.Point(437, 21);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(79, 24);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingredient Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(134, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Plural Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(247, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(321, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unit of Measurement";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IngredientListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(529, 55);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.ingredientUnitBox);
            this.Controls.Add(this.ingredientPNameBox);
            this.Controls.Add(this.ingredientQtyBox);
            this.Controls.Add(this.ingredientNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngredientListItem";
            this.Text = "IngredientListItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ingredientNameBox;
        private System.Windows.Forms.TextBox ingredientQtyBox;
        private System.Windows.Forms.TextBox ingredientPNameBox;
        private System.Windows.Forms.TextBox ingredientUnitBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}