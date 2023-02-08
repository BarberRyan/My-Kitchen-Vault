namespace MyKitchenVault
{
    partial class TagSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagSelector));
            this.tagList = new System.Windows.Forms.ListView();
            this.IncludeTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorLabel = new System.Windows.Forms.Label();
            this.removeTagButton = new System.Windows.Forms.Button();
            this.addTagButton = new System.Windows.Forms.Button();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tagList
            // 
            this.tagList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tagList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IncludeTag});
            this.tagList.HideSelection = false;
            this.tagList.Location = new System.Drawing.Point(12, 66);
            this.tagList.Name = "tagList";
            this.tagList.ShowItemToolTips = true;
            this.tagList.Size = new System.Drawing.Size(212, 251);
            this.tagList.TabIndex = 19;
            this.tagList.UseCompatibleStateImageBehavior = false;
            this.tagList.View = System.Windows.Forms.View.List;
            this.tagList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TagList_Key_Up);
            // 
            // IncludeTag
            // 
            this.IncludeTag.Text = "Include Tag";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.LightPink;
            this.errorLabel.Location = new System.Drawing.Point(72, 349);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(92, 13);
            this.errorLabel.TabIndex = 18;
            this.errorLabel.Text = "No Item Selected!";
            this.errorLabel.Visible = false;
            // 
            // removeTagButton
            // 
            this.removeTagButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.removeTagButton.ForeColor = System.Drawing.SystemColors.Info;
            this.removeTagButton.Location = new System.Drawing.Point(68, 323);
            this.removeTagButton.Name = "removeTagButton";
            this.removeTagButton.Size = new System.Drawing.Size(100, 23);
            this.removeTagButton.TabIndex = 17;
            this.removeTagButton.Text = "Remove Selected";
            this.removeTagButton.UseVisualStyleBackColor = false;
            this.removeTagButton.Click += new System.EventHandler(this.RemoveTagButton_Click);
            // 
            // addTagButton
            // 
            this.addTagButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addTagButton.ForeColor = System.Drawing.SystemColors.Info;
            this.addTagButton.Location = new System.Drawing.Point(81, 37);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Size = new System.Drawing.Size(75, 23);
            this.addTagButton.TabIndex = 16;
            this.addTagButton.Text = "Add Tag";
            this.addTagButton.UseVisualStyleBackColor = false;
            this.addTagButton.Click += new System.EventHandler(this.AddTagButton_Click);
            // 
            // tagBox
            // 
            this.tagBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tagBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tagBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tagBox.ForeColor = System.Drawing.SystemColors.Info;
            this.tagBox.Location = new System.Drawing.Point(12, 11);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(212, 20);
            this.tagBox.TabIndex = 15;
            this.tagBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TagBoxEnter);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.acceptButton.ForeColor = System.Drawing.SystemColors.Info;
            this.acceptButton.Location = new System.Drawing.Point(12, 377);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 20;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.cancelButton.Location = new System.Drawing.Point(149, 377);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TagSelector
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(239, 412);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.tagList);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.removeTagButton);
            this.Controls.Add(this.addTagButton);
            this.Controls.Add(this.tagBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TagSelector";
            this.Text = "Select Tags";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView tagList;
        private System.Windows.Forms.ColumnHeader IncludeTag;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button removeTagButton;
        private System.Windows.Forms.Button addTagButton;
        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
    }
}