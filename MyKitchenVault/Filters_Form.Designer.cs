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
            this.includeOnlySelectedRadio = new System.Windows.Forms.RadioButton();
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
            this.SuspendLayout();
            // 
            // includeBox
            // 
            this.includeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.includeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.includeBox.Location = new System.Drawing.Point(12, 52);
            this.includeBox.Name = "includeBox";
            this.includeBox.Size = new System.Drawing.Size(212, 20);
            this.includeBox.TabIndex = 1;
            this.includeBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IncludeBoxEnter);
            // 
            // includeButton
            // 
            this.includeButton.Location = new System.Drawing.Point(81, 78);
            this.includeButton.Name = "includeButton";
            this.includeButton.Size = new System.Drawing.Size(75, 23);
            this.includeButton.TabIndex = 2;
            this.includeButton.Text = "Include Tag";
            this.includeButton.UseVisualStyleBackColor = true;
            this.includeButton.Click += new System.EventHandler(this.IncludeButton_Click);
            // 
            // excludeButton
            // 
            this.excludeButton.Location = new System.Drawing.Point(456, 78);
            this.excludeButton.Name = "excludeButton";
            this.excludeButton.Size = new System.Drawing.Size(75, 23);
            this.excludeButton.TabIndex = 5;
            this.excludeButton.Text = "Exclude Tag";
            this.excludeButton.UseVisualStyleBackColor = true;
            this.excludeButton.Click += new System.EventHandler(this.ExcludeButton_Click);
            // 
            // excludeBox
            // 
            this.excludeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.excludeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.excludeBox.Location = new System.Drawing.Point(387, 52);
            this.excludeBox.Name = "excludeBox";
            this.excludeBox.Size = new System.Drawing.Size(212, 20);
            this.excludeBox.TabIndex = 4;
            this.excludeBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ExcludeBoxEnter);
            // 
            // matchAnyRadio
            // 
            this.matchAnyRadio.AutoSize = true;
            this.matchAnyRadio.Enabled = false;
            this.matchAnyRadio.Location = new System.Drawing.Point(244, 107);
            this.matchAnyRadio.Name = "matchAnyRadio";
            this.matchAnyRadio.Size = new System.Drawing.Size(75, 17);
            this.matchAnyRadio.TabIndex = 6;
            this.matchAnyRadio.TabStop = true;
            this.matchAnyRadio.Text = "Match any";
            this.matchAnyRadio.UseVisualStyleBackColor = true;
            this.matchAnyRadio.CheckedChanged += new System.EventHandler(this.RadioButtonSelected);
            // 
            // matchAllRadio
            // 
            this.matchAllRadio.AutoSize = true;
            this.matchAllRadio.Enabled = false;
            this.matchAllRadio.Location = new System.Drawing.Point(244, 130);
            this.matchAllRadio.Name = "matchAllRadio";
            this.matchAllRadio.Size = new System.Drawing.Size(68, 17);
            this.matchAllRadio.TabIndex = 7;
            this.matchAllRadio.TabStop = true;
            this.matchAllRadio.Text = "Match all";
            this.matchAllRadio.UseVisualStyleBackColor = true;
            this.matchAllRadio.CheckedChanged += new System.EventHandler(this.RadioButtonSelected);
            // 
            // includeOnlySelectedRadio
            // 
            this.includeOnlySelectedRadio.AutoSize = true;
            this.includeOnlySelectedRadio.Enabled = false;
            this.includeOnlySelectedRadio.Location = new System.Drawing.Point(244, 153);
            this.includeOnlySelectedRadio.Name = "includeOnlySelectedRadio";
            this.includeOnlySelectedRadio.Size = new System.Drawing.Size(125, 17);
            this.includeOnlySelectedRadio.TabIndex = 8;
            this.includeOnlySelectedRadio.TabStop = true;
            this.includeOnlySelectedRadio.Text = "Include only selected";
            this.includeOnlySelectedRadio.UseVisualStyleBackColor = true;
            this.includeOnlySelectedRadio.CheckedChanged += new System.EventHandler(this.RadioButtonSelected);
            // 
            // includeRemoveButton
            // 
            this.includeRemoveButton.Location = new System.Drawing.Point(68, 364);
            this.includeRemoveButton.Name = "includeRemoveButton";
            this.includeRemoveButton.Size = new System.Drawing.Size(100, 23);
            this.includeRemoveButton.TabIndex = 9;
            this.includeRemoveButton.Text = "Remove Selected";
            this.includeRemoveButton.UseVisualStyleBackColor = true;
            this.includeRemoveButton.Click += new System.EventHandler(this.IncludeRemoveButton_Click);
            // 
            // excludeRemoveButton
            // 
            this.excludeRemoveButton.Location = new System.Drawing.Point(439, 364);
            this.excludeRemoveButton.Name = "excludeRemoveButton";
            this.excludeRemoveButton.Size = new System.Drawing.Size(101, 23);
            this.excludeRemoveButton.TabIndex = 10;
            this.excludeRemoveButton.Text = "Remove Selected";
            this.excludeRemoveButton.UseVisualStyleBackColor = true;
            this.excludeRemoveButton.Click += new System.EventHandler(this.ExcludeRemoveButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(222, 395);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 11;
            this.acceptButton.Text = "Apply Filters";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(313, 395);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // includeErrorLabel
            // 
            this.includeErrorLabel.AutoSize = true;
            this.includeErrorLabel.ForeColor = System.Drawing.Color.Red;
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
            this.excludeErrorLabel.ForeColor = System.Drawing.Color.Red;
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
            this.bothErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.bothErrorLabel.Location = new System.Drawing.Point(231, 56);
            this.bothErrorLabel.Name = "bothErrorLabel";
            this.bothErrorLabel.Size = new System.Drawing.Size(146, 13);
            this.bothErrorLabel.TabIndex = 17;
            this.bothErrorLabel.Text = "Tag cannot be in both boxes!";
            this.bothErrorLabel.Visible = false;
            // 
            // Filters_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 426);
            this.ControlBox = false;
            this.Controls.Add(this.bothErrorLabel);
            this.Controls.Add(this.excludeErrorLabel);
            this.Controls.Add(this.excludeList);
            this.Controls.Add(this.includeList);
            this.Controls.Add(this.includeErrorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.excludeRemoveButton);
            this.Controls.Add(this.includeRemoveButton);
            this.Controls.Add(this.includeOnlySelectedRadio);
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
        private System.Windows.Forms.RadioButton includeOnlySelectedRadio;
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
    }
}