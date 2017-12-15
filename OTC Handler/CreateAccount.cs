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

            }
            else
            {
                MessageBox.Show("Please complete all fields before saving.","Incomplete Fields");
            }

        }
    }
}
