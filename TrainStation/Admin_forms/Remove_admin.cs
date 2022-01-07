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
        string email;
        public Remove_admin(string Email)
        {
            InitializeComponent();
            control = new Controller();
            email = Email;
        }

        private void RemoveAdminButton_Click(object sender, EventArgs e)
        {
            DataTable dt = control.Get_Vacc_Serial_Email(Remove_Admin_comboBox.Text);
            int VaccSerial = Convert.ToInt32(dt.Rows[0][0]);
            int result = control.Remove_Admin(Remove_Admin_comboBox.Text);
            int result2 = control.Delete_vacc(VaccSerial);
            if (result == 1 && result2 == 1)
            {
                MessageBox.Show("Removed Admin Successfully");
                Remove_admin_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Couldn't remove admin");
            }
        }

        private void Remove_admin_Load(object sender, EventArgs e)
        {
            DataTable dtAdmin = control.Select_Admin_Emails();
            foreach (DataRow row in dtAdmin.Rows)
            {
                if (row["Email"].ToString() == email)
                {
                    row.Delete();
                }
            }
            Remove_Admin_comboBox.DataSource = dtAdmin;
            Remove_Admin_comboBox.DisplayMember = "Email";
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
