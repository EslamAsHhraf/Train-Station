using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainStation.Admin_forms
{
    public partial class Remove_admin : Form
    {
        Controller control;
        public Remove_admin()
        {
            InitializeComponent();
            DataTable dtPSSN = control.Select_Admin_Emails();
            Remove_Admin_comboBox.DataSource = dtPSSN;
            Remove_Admin_comboBox.DisplayMember = "PSSN";
        }

        private void RemoveAdminButton_Click(object sender, EventArgs e)
        {

        }
    }
}
