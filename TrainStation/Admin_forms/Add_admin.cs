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
    public partial class Add_admin : Form
    {
        Controller control;

        public Add_admin()
        {
            InitializeComponent();
            control = new Controller();
            DataTable dtemails = control.Select_NonAdmin_Emails();
            AddAdminEmailComboBox.DataSource = dtemails;
            AddAdminEmailComboBox.DisplayMember = "Email";

        }
   

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            int result = control.Add_Admin(AddAdminEmailComboBox.Text);
            if(result == 1)
            {
                MessageBox.Show("Added admin successfully");
            }
            else
            {
                MessageBox.Show("Couldn't add admin");
            }
        }

        private void Add_admin_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
