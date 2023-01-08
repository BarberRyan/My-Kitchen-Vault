using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace MyKitchenVault
{
    public partial class Sign_Up_Form : Form
    {
        private string errorMsg = "";

        public string username { get; set; }

        public Sign_Up_Form()
        {
            InitializeComponent();
        }

        private void su_cancel_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void su_sign_up_button_Click(object sender, EventArgs e)
        {
            if (su_username_box.TextLength > 0 && password1_box.TextLength > 0 && password1_box.Text == password2_box.Text)
            {
                this.username = su_username_box.Text;

                if (DB_Interface.CheckUserExists(this.username))
                {
                    MessageBox.Show($"A user with the name \"{this.username}\" already exists.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if(DB_Interface.CreateUser(this.username, password1_box.Text))
                    { 
                        MessageBox.Show($"Welcome to My Kitchen Vault, {this.username}!", "User Created!", MessageBoxButtons.OK);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }
        private void SU_Username_Text_Changed(object sender, EventArgs e)
        {
            SU_Validate();
        }

        private void Password1_Text_Changed(object sender, EventArgs e)
        {
            SU_Validate();
        }
        
        private void Password2_Text_Changed(object sender, EventArgs e)
        {
            SU_Validate();
        }

        private bool SU_Validate()
        {
            bool valid = true;
            if(su_username_box.TextLength < 5)
            {
                errorMsg = "Username must be\nat least 5 characters long.";
                valid = false;
            }
            else if (password1_box.TextLength > 0 && !Regex.IsMatch(password1_box.Text, @"(?=.{6,})(?=(.*\d){1,})(?=(.*\W){1,})"))
            {
                errorMsg = "Password must be\nat least 7 characters,\nhave at least 1 number,\nand at least 1 symbol.";
                valid = false;
            }
            else if (password2_box.TextLength > 0 && !Regex.IsMatch(password2_box.Text, @"(?=.{6,})(?=(.*\d){1,})(?=(.*\W){1,})"))
            {
                errorMsg = "Password must be\nat least 7 characters,\nhave at least 1 number,\nand at least 1 symbol.";
                valid = false;
            }
            else if (password1_box.Text != password2_box.Text)
            {
                errorMsg = "Passwords must match.";
                valid = false;
            }
            if (valid)
            {
                su_ErrorLabel.Visible = false;
            }
            else
            {
                su_ErrorLabel.Text = errorMsg;
                su_ErrorLabel.Visible = true;
            }
            return valid;
        }

    }
}
