using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTC_Handler
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string lUsername = tbUsername.Text;
            string lPassword = mtbPassword.Text;

            if(lUsername.Length > 0 && lPassword.Length > 0)
            {
                if(lUsername.Length >= 8 && lPassword.Length >= 8)
                {

                }
                else
                {
                    MessageBox.Show("Username and password must be at least 8 characters in length.", "Insufficient Entry");
                }
            }
            else
            {
                MessageBox.Show("Please enter your username and password.", "Login");
                
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            CreateAccount nResponder = new CreateAccount();
            nResponder.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            
            if(dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
