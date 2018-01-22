using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTC_Handler
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveResponderAcct_Click(object sender, EventArgs e)
        {

            string nUsername = tbNewUsername.Text;
            string nPassword = mtbNewPassword.Text;
            string nConfPassword = mtbConfNewPassword.Text;
            string nName = tbResponderName.Text;
            string nContact = tbNewContactNo.Text;
            string nAddress = tbResponderAddress.Text;

            if(nUsername.Length >= 8  && nPassword.Length >= 8 && nConfPassword.Length >=8 &&
                nName.Length > 0 && nContact.Length > 0 && nAddress.Length > 0)
            {

                if (nPassword.Equals(nConfPassword))
                {
                    DatabaseManager dbman = new DatabaseManager();

                    dbman.DatabaseName = "otc_help";

                    if (dbman.IsConnect())
                    {
                        string insert_query = "INSERT INTO otc_responder (responder_username,responder_password,responder_contact,responder_name,responder_address) VALUES (@nuser,@npass,@rname,@rcontact,@raddress);";

                        var ins_cmd = new MySqlCommand(insert_query, dbman.Connection);

                        var pass = SHA512(nPassword);
                       
                        ins_cmd.Parameters.AddWithValue("@nuser", nUsername);
                        ins_cmd.Parameters.AddWithValue("@npass", pass);
                        ins_cmd.Parameters.AddWithValue("@rname", nName);
                        ins_cmd.Parameters.AddWithValue("@rcontact", nContact);
                        ins_cmd.Parameters.AddWithValue("@raddress", nAddress);

                        ins_cmd.Prepare();

                        if (ins_cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Responder saved to database!");
                            tbNewUsername.Text = "";
                            mtbNewPassword.Text = "";
                            mtbConfNewPassword.Text = "";
                            tbResponderName.Text = "";
                            tbNewContactNo.Text = "";
                            tbResponderAddress.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Responder failed to be saved to database.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to connect to database.");
                    }
                }
                else
                {
                    MessageBox.Show("Password and confirm password must be equal!");
                }
                
            }
            else
            {
                MessageBox.Show("Please complete all fields before saving.","Incomplete Fields");
            }

        }

        private void btnRespBack_Click(object sender, EventArgs e)
        {
            string nUsername = tbNewUsername.Text;
            string nPassword = mtbNewPassword.Text;
            string nConfPassword = mtbConfNewPassword.Text;
            string nName = tbResponderName.Text;
            string nContact = tbNewContactNo.Text;
            string nAddress = tbResponderAddress.Text;

            if (nUsername.Length >= 8 || nPassword.Length >= 8 || nConfPassword.Length >= 8 ||
                 nName.Length > 0 || nContact.Length > 0 || nAddress.Length > 0)
            {
                DialogResult exit = MessageBox.Show("Are you sure you want to go back to main menu? Any changes will not be saved.", "Return to Menu",MessageBoxButtons.YesNo);

                if(exit == DialogResult.Yes)
                {
                    this.Close();
                }

            }
            else
            {
                this.Close(); 
            }
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
