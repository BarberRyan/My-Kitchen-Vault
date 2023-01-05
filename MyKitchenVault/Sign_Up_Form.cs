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
    public partial class Sign_Up_Form : Form
    {
        public Sign_Up_Form()
        {
            InitializeComponent();
        }

        private void su_cancel_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void su_sign_up_button_Click(object sender, EventArgs e)
        {
            if (su_username_box.TextLength > 0 && password1_box.TextLength > 0 && password1_box.Text == password2_box.Text)
            {
                if (DB_Interface.CheckUserExists(su_username_box.Text))
                {
                    UserExistsLabel.Visible = true;
                }
                else
                {
                    DB_Interface.CreateUser(su_username_box.Text, password1_box.Text);
                    MessageBox.Show("USER CREATED!");
                }
            }
        }

        private void Password2_Text_Changed(object sender, EventArgs e)
        {
            if(password1_box.Text != password2_box.Text)
            {
                passwordMatchLabel.Visible = true;
            }
            else
            {
                passwordMatchLabel.Visible = false;
            }
        }
    }
}
