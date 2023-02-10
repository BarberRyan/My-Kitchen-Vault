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
    public partial class MKV_SignUpForm : Form
    {
        private string errorMsg = "";
        public string Username { get; set; }

        public MKV_SignUpForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cancels and closes the sign up form (fired when the "cancel" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Attempts to enter user into the database and gives feedback to the user (fired when the "sign up" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.TextLength > 0 && passwordBox1.TextLength > 0 && passwordBox1.Text == passwordBox2.Text)
            {
                this.Username = usernameBox.Text;

                if (Util_DBInterface.CheckUserExists(this.Username))
                {
                    MessageBox.Show($"A user with the name \"{this.Username}\" already exists.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if(Util_DBInterface.CreateUser(this.Username, passwordBox1.Text))
                    { 
                        MessageBox.Show($"Welcome to My Kitchen Vault, {this.Username}!", "User Created!", MessageBoxButtons.OK);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Validates the text in the form's textboxes (fired when the text is changed in any textbox)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void Any_Text_Changed(object sender, EventArgs e)
        {
            ValidateInput();
        }

        /// <summary>
        /// Function to validate the input data and provide feedback to the user
        /// </summary>
        /// <returns>Boolean value representing if the form data passes validation</returns>
        private bool ValidateInput()
        {
            bool valid = true;
            if(usernameBox.TextLength < 5)
            {
                errorMsg = "Username must be\nat least 5 characters long.";
                valid = false;
            }
            else if (passwordBox1.TextLength > 0 && !Regex.IsMatch(passwordBox1.Text, @"(?=.{6,})(?=(.*\d){1,})(?=(.*\W){1,})"))
            {
                errorMsg = "Password must be\nat least 7 characters,\nhave at least 1 number,\nand at least 1 symbol.";
                valid = false;
            }
            else if (passwordBox2.TextLength > 0 && !Regex.IsMatch(passwordBox2.Text, @"(?=.{6,})(?=(.*\d){1,})(?=(.*\W){1,})"))
            {
                errorMsg = "Password must be\nat least 7 characters,\nhave at least 1 number,\nand at least 1 symbol.";
                valid = false;
            }
            else if (passwordBox1.Text != passwordBox2.Text)
            {
                errorMsg = "Passwords must match.";
                valid = false;
            }
            if (valid)
            {
                errorLabel.Visible = false;
            }
            else
            {
                errorLabel.Text = errorMsg;
                errorLabel.Visible = true;
            }
            return valid;
        }

    }
}
