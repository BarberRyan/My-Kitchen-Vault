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
    public partial class Mkv_Main : Form
    {
        public static User user;

        public Mkv_Main()
        {
            InitializeComponent();
            foreach (Control item in this.Controls)
            {
                if (!(item is MenuStrip))
                {
                    item.Enabled = false;
                }
            }
        }


        private void Log_In_MenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Login_Form())
            {
                var results = form.ShowDialog();
                if(results == DialogResult.OK)
                {
                    user = new User(form.Username, form.User_Id);
                    MessageBox.Show($"Successfully signed in as {user.GetUsername()}.");
                    UsernameLabel.Text = ($"Signed in as {user.GetUsername()} (user id # {user.GetUserID()}).");
                    foreach (Control item in this.Controls)
                    {
                        if(!(item is MenuStrip))
                        {
                            item.Enabled = true;
                        }
                    }
                }
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                var confirmLogout = MessageBox.Show("Are you sure you want to log out?\nUnsaved changes will be lost!", "Confirm", MessageBoxButtons.YesNo);
                if (confirmLogout == DialogResult.Yes)
                {
                    user = null;
                    UsernameLabel.Text = "(Not signed in)";
                    foreach (Control item in this.Controls)
                    {
                        if (!(item is MenuStrip))
                        {
                            item.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No user signed in.", "Error", MessageBoxButtons.OK);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Are you sure you want to clear "," Clear Screen ",MessageBoxButtons.YesNo);
        }
    }
}
