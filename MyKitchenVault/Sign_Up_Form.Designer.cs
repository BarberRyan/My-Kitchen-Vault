namespace MyKitchenVault
{
    partial class Sign_Up_Form
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
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordBox2 = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernameBox.ForeColor = System.Drawing.SystemColors.Info;
            this.usernameBox.Location = new System.Drawing.Point(12, 24);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(156, 20);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.TextChanged += new System.EventHandler(this.Any_Text_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // passwordBox1
            // 
            this.passwordBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.passwordBox1.Location = new System.Drawing.Point(12, 63);
            this.passwordBox1.Name = "passwordBox1";
            this.passwordBox1.PasswordChar = '●';
            this.passwordBox1.Size = new System.Drawing.Size(156, 20);
            this.passwordBox1.TabIndex = 2;
            this.passwordBox1.TextChanged += new System.EventHandler(this.Any_Text_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Repeat Password:";
            // 
            // passwordBox2
            // 
            this.passwordBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.passwordBox2.Location = new System.Drawing.Point(12, 104);
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.PasswordChar = '●';
            this.passwordBox2.Size = new System.Drawing.Size(156, 20);
            this.passwordBox2.TabIndex = 4;
            this.passwordBox2.TextChanged += new System.EventHandler(this.Any_Text_Changed);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signUpButton.ForeColor = System.Drawing.SystemColors.Info;
            this.signUpButton.Location = new System.Drawing.Point(48, 207);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 6;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.cancelButton.Location = new System.Drawing.Point(48, 236);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabel.Location = new System.Drawing.Point(12, 127);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(156, 77);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "Passwords must match.";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errorLabel.Visible = false;
            // 
            // Sign_Up_Form
            // 
            this.AcceptButton = this.signUpButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(10)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(182, 276);
            this.ControlBox = false;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Sign_Up_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sign Up for My Kitchen Vault";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordBox2;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label errorLabel;
    }
}