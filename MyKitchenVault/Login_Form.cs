using System;
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
    public partial class Login_Form : Form
    {
        public string Username { get; set; }
        public int User_Id { get; set; }

        public Login_Form()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void sign_in_button_Click(object sender, EventArgs e)
        {
            if(username_box.TextLength > 0 && password_box.TextLength > 0)
            {
                (string, int, LoginStatus) loginInfo;
                loginInfo = DB_Interface.CheckLogin(username_box.Text, password_box.Text);

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

        private void sign_up_button_Click(object sender, EventArgs e)
        {
            using (var form = new Sign_Up_Form())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    username_box.Text = form.username;
                    password_box.Select();
                }
            }
        }
    }
}
