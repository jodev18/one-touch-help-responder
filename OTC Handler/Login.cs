using MySql.Data.MySqlClient;
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
                    DatabaseManager dbman = new DatabaseManager();

                    dbman.DatabaseName = "otc_help";

                    if (dbman.IsConnect())
                    {
                        string query = "SELECT responder_username,responder_password " +
                            "from otc_responder where responder_username=@val1 AND "
                            + " responder_password=@val2";

                        var cmd = new MySqlCommand(query, dbman.Connection);

                        var auth = SHA512(lPassword);

                        cmd.Parameters.AddWithValue("@val1", lUsername);
                        cmd.Parameters.AddWithValue("@val2", auth);

                        cmd.Prepare();

                        var reader = cmd.ExecuteReader();

                        int retcount = 0;
                                                
                        //Because there's no getCount()....
                        while (reader.Read())
                        {
                            retcount++;
                        }

                        if(retcount > 0)
                        {
                            MessageBox.Show("Login successful.");
                            this.Hide();
                            MainMenu mn = new MainMenu();
                            mn.ShowDialog();
                            
                        }
                        else
                        {
                            MessageBox.Show("Incorrect login information.");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Error", "Database is offline.");
                    }
                   

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

        private string SHA512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }

    }
}
