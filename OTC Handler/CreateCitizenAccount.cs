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
    }
}
