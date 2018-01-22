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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otc_databaseDataSet.otc_responder' table. You can move, or remove it, as needed.
            //this.otc_responderTableAdapter.Fill(this.otc_databaseDataSet.otc_responder);

            DatabaseManager dbman = new DatabaseManager();
            dbman.DatabaseName = "otc_help";

            if (dbman.IsConnect())
            {
                string querydata = "SELECT * FROM otc_citizen";

                var cmd = new MySqlCommand(querydata, dbman.Connection);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dataTable);

                //MessageBox.Show("Loaded data", "Database loaded");

                BindingSource bs = new BindingSource();
                bs.DataSource = da;

                dataGridView1.DataSource = bs;

            }
            else
            {
                MessageBox.Show("Failed to load data", "Database Error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateCitizenAccount creAcc = new CreateCitizenAccount();
            creAcc.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dres = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);

            if(dres == DialogResult.Yes)
            {
                this.Hide();
                Login nLogin = new Login();
                nLogin.ShowDialog();
            }
            
        }
    }
}
