namespace MyKitchenVault
{
    partial class Filters_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filters_Form));
            this.includeBox = new System.Windows.Forms.TextBox();
            this.includeButton = new System.Windows.Forms.Button();
            this.excludeButton = new System.Windows.Forms.Button();
            this.excludeBox = new System.Windows.Forms.TextBox();
            this.matchAnyRadio = new System.Windows.Forms.RadioButton();
            this.matchAllRadio = new System.Windows.Forms.RadioButton();
            this.includeRemoveButton = new System.Windows.Forms.Button();
            this.excludeRemoveButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.includeErrorLabel = new System.Windows.Forms.Label();
            this.includeList = new System.Windows.Forms.ListView();
            this.IncludeTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.excludeList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.excludeErrorLabel = new System.Windows.Forms.Label();
            this.bothErrorLabel = new System.Windows.Forms.Label();
            this.ratingBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // includeBox
            // 
            this.includeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.includeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.includeBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.includeBox.ForeColor = System.Drawing.SystemColors.Info;
            this.includeBox.Location = new System.Drawing.Point(12, 52);
            this.includeBox.Name = "includeBox";
            this.includeBox.Size = new System.Drawing.Size(212, 20);
            this.includeBox.TabIndex = 1;
            this.includeBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IncludeBoxEnter);
            // 
            // includeButton
            // 
            this.includeButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.includeButton.ForeColor = System.Drawing.SystemColors.Info;
            this.includeButton.Location = new System.Drawing.Point(81, 78);
            this.includeButton.Name = "includeButton";
            this.includeButton.Size = new System.Drawing.Size(75, 23);
            this.includeButton.TabIndex = 2;
            this.includeButton.Text = "Include Tag";
            this.includeButton.UseVisualStyleBackColor = false;
            this.includeButton.Click += new System.EventHandler(this.IncludeButton_Click);
            // 
            // excludeButton
            // 
            this.excludeButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.excludeButton.ForeColor = System.Drawing.SystemColors.Info;
            this.excludeButton.Location = new System.Drawing.Point(456, 78);
            this.excludeButton.Name = "excludeButton";
            this.excludeButton.Size = new System.Drawing.Size(75, 23);
            this.excludeButton.TabIndex = 5;
            this.excludeButton.Text = "Exclude Tag";
            this.excludeButton.UseVisualStyleBackColor = false;
            this.excludeButton.Click += new System.EventHandler(this.ExcludeButton_Click);
            // 
            // excludeBox
            // 
            this.excludeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.excludeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.excludeBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.excludeBox.ForeColor = System.Drawing.SystemColors.Info;
            this.excludeBox.Location = new System.Drawing.Point(387, 52);
            this.excludeBox.Name = "excludeBox";
            this.excludeBox.Size = new System.Drawing.Size(212, 20);
            this.excludeBox.TabIndex = 4;
            this.excludeBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ExcludeBoxEnter);
            // 
            // matchAnyRadio
            // 
            this.matchAnyRadio.AutoSize = true;
            this.matchAnyRadio.BackColor = System.Drawing.Color.Transparent;
            this.matchAnyRadio.Enabled = false;
            this.matchAnyRadio.ForeColor = System.Drawing.SystemColors.Info;
            this.matchAnyRadio.Location = new System.Drawing.Point(267, 107);
            this.matchAnyRadio.Name = "matchAnyRadio";
            this.matchAnyRadio.Size = new System.Drawing.Size(75, 17);
            this.matchAnyRadio.TabIndex = 6;
            this.matchAnyRadio.TabStop = true;
            this.matchAnyRadio.Text = "Match any";
            this.matchAnyRadio.UseVisualStyleBackColor = false;
            this.matchAnyRadio.CheckedChanged += new System.EventHandler(this.RadioButtonSelected);
            // 
            // matchAllRadio
            // 
            this.matchAllRadio.AutoSize = true;
            this.matchAllRadio.BackColor = System.Drawing.Color.Transparent;
            this.matchAllRadio.Enabled = false;
            this.matchAllRadio.ForeColor = System.Drawing.SystemColors.Info;
            this.matchAllRadio.Location = new System.Drawing.Point(267, 130);
            this.matchAllRadio.Name = "matchAllRadio";
            this.matchAllRadio.Size = new System.Drawing.Size(71, 17);
            this.matchAllRadio.TabIndex = 7;
            this.matchAllRadio.TabStop = true;
            this.matchAllRadio.Text = " Match all";
            this.matchAllRadio.UseVisualStyleBackColor = false;
            this.matchAllRadio.CheckedChanged += new System.EventHandler(this.RadioButtonSelected);
            // 
            // includeRemoveButton
            // 
            this.includeRemoveButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.includeRemoveButton.ForeColor = System.Drawing.SystemColors.Info;
            this.includeRemoveButton.Location = new System.Drawing.Point(68, 364);
            this.includeRemoveButton.Name = "includeRemoveButton";
            this.includeRemoveButton.Size = new System.Drawing.Size(100, 23);
            this.includeRemoveButton.TabIndex = 9;
            this.includeRemoveButton.Text = "Remove Selected";
            this.includeRemoveButton.UseVisualStyleBackColor = false;
            this.includeRemoveButton.Click += new System.EventHandler(this.IncludeRemoveButton_Click);
            // 
            // excludeRemoveButton
            // 
            this.excludeRemoveButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.excludeRemoveButton.ForeColor = System.Drawing.SystemColors.Info;
            this.excludeRemoveButton.Location = new System.Drawing.Point(439, 364);
            this.excludeRemoveButton.Name = "excludeRemoveButton";
            this.excludeRemoveButton.Size = new System.Drawing.Size(101, 23);
            this.excludeRemoveButton.TabIndex = 10;
            this.excludeRemoveButton.Text = "Remove Selected";
            this.excludeRemoveButton.UseVisualStyleBackColor = false;
            this.excludeRemoveButton.Click += new System.EventHandler(this.ExcludeRemoveButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.acceptButton.ForeColor = System.Drawing.SystemColors.Info;
            this.acceptButton.Location = new System.Drawing.Point(222, 395);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 11;
            this.acceptButton.Text = "Apply Filters";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.cancelButton.Location = new System.Drawing.Point(313, 395);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // includeErrorLabel
            // 
            this.includeErrorLabel.AutoSize = true;
            this.includeErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.includeErrorLabel.ForeColor = System.Drawing.Color.LightPink;
            this.includeErrorLabel.Location = new System.Drawing.Point(72, 390);
            this.includeErrorLabel.Name = "includeErrorLabel";
            this.includeErrorLabel.Size = new System.Drawing.Size(92, 13);
            this.includeErrorLabel.TabIndex = 13;
            this.includeErrorLabel.Text = "No Item Selected!";
            this.includeErrorLabel.Visible = false;
            // 
            // includeList
            // 
            this.includeList.BackColor = System.Drawing.Color.PaleGreen;
            this.includeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IncludeTag});
            this.includeList.HideSelection = false;
            this.includeList.Location = new System.Drawing.Point(12, 107);
            this.includeList.Name = "includeList";
            this.includeList.ShowItemToolTips = true;
            this.includeList.Size = new System.Drawing.Size(212, 251);
            this.includeList.TabIndex = 14;
            this.includeList.UseCompatibleStateImageBehavior = false;
            this.includeList.View = System.Windows.Forms.View.List;
            this.includeList.SelectedIndexChanged += new System.EventHandler(this.IncludeList_SelectedIndexChanged);
            // 
            // IncludeTag
            // 
            this.IncludeTag.Text = "Include Tag";
            // 
            // excludeList
            // 
            this.excludeList.BackColor = System.Drawing.Color.LightPink;
            this.excludeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.excludeList.HideSelection = false;
            this.excludeList.Location = new System.Drawing.Point(383, 107);
            this.excludeList.Name = "excludeList";
            this.excludeList.ShowItemToolTips = true;
            this.excludeList.Size = new System.Drawing.Size(212, 251);
            this.excludeList.TabIndex = 15;
            this.excludeList.UseCompatibleStateImageBehavior = false;
            this.excludeList.View = System.Windows.Forms.View.List;
            this.excludeList.SelectedIndexChanged += new System.EventHandler(this.ExcludeList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Include Tag";
            // 
            // excludeErrorLabel
            // 
            this.excludeErrorLabel.AutoSize = true;
            this.excludeErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.excludeErrorLabel.ForeColor = System.Drawing.Color.LightPink;
            this.excludeErrorLabel.Location = new System.Drawing.Point(443, 390);
            this.excludeErrorLabel.Name = "excludeErrorLabel";
            this.excludeErrorLabel.Size = new System.Drawing.Size(92, 13);
            this.excludeErrorLabel.TabIndex = 16;
            this.excludeErrorLabel.Text = "No Item Selected!";
            this.excludeErrorLabel.Visible = false;
            // 
            // bothErrorLabel
            // 
            this.bothErrorLabel.AutoSize = true;
            this.bothErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.bothErrorLabel.ForeColor = System.Drawing.Color.LightPink;
            this.bothErrorLabel.Location = new System.Drawing.Point(231, 56);
            this.bothErrorLabel.Name = "bothErrorLabel";
            this.bothErrorLabel.Size = new System.Drawing.Size(146, 13);
            this.bothErrorLabel.TabIndex = 17;
            this.bothErrorLabel.Text = "Tag cannot be in both boxes!";
            this.bothErrorLabel.Visible = false;
            // 
            // ratingBox
            // 
            this.ratingBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ratingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingBox.FormattingEnabled = true;
            this.ratingBox.Items.AddRange(new object[] {
            "☆☆☆☆☆",
            "★☆☆☆☆",
            "★★☆☆☆",
            "★★★☆☆",
            "★★★★☆",
            "★★★★★"});
            this.ratingBox.Location = new System.Drawing.Point(267, 176);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(75, 28);
            this.ratingBox.TabIndex = 18;
            this.ratingBox.SelectedIndexChanged += new System.EventHandler(this.RatingBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(263, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Minimum Rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 41);
            this.label2.TabIndex = 20;
            this.label2.Text = "Filters";
            // 
            // Filters_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 426);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.bothErrorLabel);
            this.Controls.Add(this.excludeErrorLabel);
            this.Controls.Add(this.excludeList);
            this.Controls.Add(this.includeList);
            this.Controls.Add(this.includeErrorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.excludeRemoveButton);
            this.Controls.Add(this.includeRemoveButton);
            this.Controls.Add(this.matchAllRadio);
            this.Controls.Add(this.matchAnyRadio);
            this.Controls.Add(this.excludeButton);
            this.Controls.Add(this.excludeBox);
            this.Controls.Add(this.includeButton);
            this.Controls.Add(this.includeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Filters_Form";
            this.Text = "Apply Filters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox includeBox;
        private System.Windows.Forms.Button includeButton;
        private System.Windows.Forms.Button excludeButton;
        private System.Windows.Forms.TextBox excludeBox;
        private System.Windows.Forms.RadioButton matchAnyRadio;
        private System.Windows.Forms.RadioButton matchAllRadio;
        private System.Windows.Forms.Button includeRemoveButton;
        private System.Windows.Forms.Button excludeRemoveButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label includeErrorLabel;
        private System.Windows.Forms.ListView includeList;
        private System.Windows.Forms.ColumnHeader IncludeTag;
        private System.Windows.Forms.ListView excludeList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label excludeErrorLabel;
        private System.Windows.Forms.Label bothErrorLabel;
        private System.Windows.Forms.ComboBox ratingBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}