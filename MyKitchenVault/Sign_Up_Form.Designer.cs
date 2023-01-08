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
            this.su_username_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password1_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password2_box = new System.Windows.Forms.TextBox();
            this.su_sign_up_button = new System.Windows.Forms.Button();
            this.su_cancel_button = new System.Windows.Forms.Button();
            this.su_ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // su_username_box
            // 
            this.su_username_box.Location = new System.Drawing.Point(12, 24);
            this.su_username_box.Name = "su_username_box";
            this.su_username_box.Size = new System.Drawing.Size(156, 20);
            this.su_username_box.TabIndex = 0;
            this.su_username_box.TextChanged += new System.EventHandler(this.SU_Username_Text_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // password1_box
            // 
            this.password1_box.Location = new System.Drawing.Point(12, 63);
            this.password1_box.Name = "password1_box";
            this.password1_box.PasswordChar = '●';
            this.password1_box.Size = new System.Drawing.Size(156, 20);
            this.password1_box.TabIndex = 2;
            this.password1_box.TextChanged += new System.EventHandler(this.Password1_Text_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Repeat Password:";
            // 
            // password2_box
            // 
            this.password2_box.Location = new System.Drawing.Point(12, 104);
            this.password2_box.Name = "password2_box";
            this.password2_box.PasswordChar = '●';
            this.password2_box.Size = new System.Drawing.Size(156, 20);
            this.password2_box.TabIndex = 4;
            this.password2_box.TextChanged += new System.EventHandler(this.Password2_Text_Changed);
            // 
            // su_sign_up_button
            // 
            this.su_sign_up_button.Location = new System.Drawing.Point(48, 207);
            this.su_sign_up_button.Name = "su_sign_up_button";
            this.su_sign_up_button.Size = new System.Drawing.Size(75, 23);
            this.su_sign_up_button.TabIndex = 6;
            this.su_sign_up_button.Text = "Sign Up";
            this.su_sign_up_button.UseVisualStyleBackColor = true;
            this.su_sign_up_button.Click += new System.EventHandler(this.su_sign_up_button_Click);
            // 
            // su_cancel_button
            // 
            this.su_cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.su_cancel_button.Location = new System.Drawing.Point(48, 236);
            this.su_cancel_button.Name = "su_cancel_button";
            this.su_cancel_button.Size = new System.Drawing.Size(75, 23);
            this.su_cancel_button.TabIndex = 7;
            this.su_cancel_button.Text = "Cancel";
            this.su_cancel_button.UseVisualStyleBackColor = true;
            this.su_cancel_button.Click += new System.EventHandler(this.su_cancel_button_Click);
            // 
            // su_ErrorLabel
            // 
            this.su_ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.su_ErrorLabel.Location = new System.Drawing.Point(12, 127);
            this.su_ErrorLabel.Name = "su_ErrorLabel";
            this.su_ErrorLabel.Size = new System.Drawing.Size(156, 77);
            this.su_ErrorLabel.TabIndex = 8;
            this.su_ErrorLabel.Text = "Passwords must match.";
            this.su_ErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.su_ErrorLabel.Visible = false;
            // 
            // Sign_Up_Form
            // 
            this.AcceptButton = this.su_sign_up_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.su_cancel_button;
            this.ClientSize = new System.Drawing.Size(182, 276);
            this.ControlBox = false;
            this.Controls.Add(this.su_ErrorLabel);
            this.Controls.Add(this.su_cancel_button);
            this.Controls.Add(this.su_sign_up_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password2_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password1_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.su_username_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Sign_Up_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sign Up for My Kitchen Vault";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox su_username_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password1_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password2_box;
        private System.Windows.Forms.Button su_sign_up_button;
        private System.Windows.Forms.Button su_cancel_button;
        private System.Windows.Forms.Label su_ErrorLabel;
    }
}