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
            control = new Controller();
            DataTable dtAdmin = control.Select_Admin_Emails();
            Remove_Admin_comboBox.DataSource = dtAdmin;
            Remove_Admin_comboBox.DisplayMember = "Email";
        }

        private void RemoveAdminButton_Click(object sender, EventArgs e)
        {
            int result = control.Remove_Admin(Remove_Admin_comboBox.Text);
            if(result == 1)
            {
                MessageBox.Show("Removed Admin Successfully");
            }
            else
            {
                MessageBox.Show("Couldn't remove admin");
            }
        }
    }
}
