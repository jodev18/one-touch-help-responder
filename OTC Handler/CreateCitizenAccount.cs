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
    public partial class CreateCitizenAccount : Form
    {
        public CreateCitizenAccount()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMale.Checked)
            {
                rdFemale.Checked = false;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CreateCitizenAccount_Load(object sender, EventArgs e)
        {
            populateComboBox();

            mcDOB.MaxSelectionCount = 1;
        }

        private void populateComboBox()
        {
            cbCivilStat.Items.Add("Single");
            cbCivilStat.Items.Add("Married");
            cbCivilStat.Items.Add("Divorced");
            cbCivilStat.Items.Add("Widowed");
        }

        private void tbCitFN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string input = tbPhoneNumber.Text;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                Char x = input.ElementAt(i);

                if (Char.IsDigit(x))
                {
                    sb.Append(x);
                }
            }

            tbPhoneNumber.Text = sb.ToString();
            sb.Clear();
        }

        private void tbEmergencyContactNo_TextChanged(object sender, EventArgs e)
        {
            string input = tbEmergencyContactNo.Text;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                Char x = input.ElementAt(i);

                if (Char.IsDigit(x))
                {
                    sb.Append(x);
                }
            }

            tbEmergencyContactNo.Text = sb.ToString();
            sb.Clear();
        }

        private void btnCancelSave_Click(object sender, EventArgs e)
        {

            DialogResult dgCancel = MessageBox.Show("Are you sure you want to cancel adding citizen?", "Cancel", MessageBoxButtons.YesNo);

            if(dgCancel == DialogResult.Yes)
            {
                this.Hide();
            }

        }

        private void btnSaveCitizen_Click(object sender, EventArgs e)
        {
            string cFirstName = tbCitFN.Text;
            string cLastName = tbCitLN.Text;

            string cGender = rdMale.Checked ? "Male" : "Female";
            
            Decimal cAge = numAge.Value; // age

            string dateInfo = mcDOB.SelectionRange.Start.Date.ToString();

            Console.WriteLine(dateInfo);

            string phoneNumber = tbPhoneNumber.Text;
            string civilStatus = cbCivilStat.GetItemText(cbCivilStat.SelectedItem);
            string address = tbAddress.Text;


            string emName = tbEmergencyContactName.Text;
            string emPhone = tbEmergencyContactNo.Text;
            string emAddress = tbEmergencyContactAddr.Text;

            if(cFirstName.Length > 0 && cLastName.Length > 0 && cGender.Length > 0 
                                && cAge > 0 && dateInfo.Length > 0 && phoneNumber.Length > 0 &&
                                civilStatus.Length > 0 && address.Length > 0 && emName.Length > 0 &&
                                emPhone.Length > 0 && emAddress.Length > 0)
            {
                DatabaseManager dbman = new DatabaseManager();
                dbman.DatabaseName = "otc_help";

                if (dbman.IsConnect())
                {
                    //Save to database
                    string insertQuery = "INSERT INTO otc_citizen (cit_fn,cit_ln,cit_gender,cit_age,cit_dob,cit_phone," +
                        "cit_civil_stat,cit_address,emg_contact_name,emg_contact_no,emg_contact_addr) "
                        + " values (@fn,@ln,@gender,@age,@date,@phone,@civstat,@addr,@ename,@ephone,@eaddress)";

                    var cmd = new MySqlCommand(insertQuery, dbman.Connection);
                    
                    cmd.Parameters.AddWithValue("@fn", cFirstName);
                    cmd.Parameters.AddWithValue("@ln", cLastName);
                    cmd.Parameters.AddWithValue("@gender", cGender);
                    cmd.Parameters.AddWithValue("@age", cAge);
                    cmd.Parameters.AddWithValue("@date", dateInfo);
                    cmd.Parameters.AddWithValue("@phone", phoneNumber);
                    cmd.Parameters.AddWithValue("@civstat", civilStatus);
                    cmd.Parameters.AddWithValue("@addr", address);
                    cmd.Parameters.AddWithValue("@ename", emName);
                    cmd.Parameters.AddWithValue("@ephone", emPhone);
                    cmd.Parameters.AddWithValue("@eaddress", emAddress);

                    cmd.Prepare();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Citizen information saved!", "Citizen Saved");
                        tbCitFN.Text = "";
                        tbCitLN.Text = "";
                        numAge.Value = 0;
                        tbPhoneNumber.Text = "";
                        tbAddress.Text = "";
                        tbEmergencyContactName.Text = "";
                        tbEmergencyContactNo.Text = "";
                        tbEmergencyContactAddr.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Saving to database failed.", "Database Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete Fields First", "The fields are incomplete. Please complete the fields before saving.");
            }

        }

    }
}
