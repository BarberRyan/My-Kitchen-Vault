﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKitchenVault
{
    public partial class MKV_LoginForm : Form
    {
        public string Username { get; set; }
        public int User_Id { get; set; }

        public MKV_LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cancels and closes login form (fired when the "cancel" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        /// <summary>
        /// Attempts to sign user in with given credentials (fired when the "sign in" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void SignInButton_Click(object sender, EventArgs e)
        {
            if(usernameBox.TextLength > 0 && passwordBox.TextLength > 0)
            {
                (string, int, LoginStatus) loginInfo;
                loginInfo = Util_DBInterface.CheckLogin(usernameBox.Text, passwordBox.Text);

                if(loginInfo.Item3 == LoginStatus.OK)
                {
                    this.Username = loginInfo.Item1;
                    this.User_Id = loginInfo.Item2;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        /// <summary>
        /// Opens "sign up" form (fired when the "sign up" button is clicked)
        /// </summary>
        /// <param name="sender">Object that fired the event</param>
        /// <param name="e">Event arguments</param>
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            using (var form = new MKV_SignUpForm())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    usernameBox.Text = form.Username;
                    passwordBox.Select();
                }
            }
        }
    }
}
