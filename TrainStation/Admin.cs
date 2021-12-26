using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainStation.Admin_forms;

namespace TrainStation
{
    public partial class Admin : Form
    {
        Handle hand;
        public Admin()
        {
            InitializeComponent();
            hand = new Handle(); 
        }

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            Form addAdmin = new Add_admin();
            addAdmin.ShowDialog();

        }

        private void BlockUserbutton_Click(object sender, EventArgs e)
        {
            Form blockUser = new Block_();
            blockUser.ShowDialog();
        }

        private void RemoveAdminbutton_Click(object sender, EventArgs e)
        {
            Form RemAdmin = new Remove_admin();
            RemAdmin.ShowDialog();
        }

        private void BeManagerbutton_Click(object sender, EventArgs e)
        {
            Form manager = new Manager();
            manager.ShowDialog();
        }

        private void BeEmployeebutton_Click(object sender, EventArgs e)
        {
            Form employee = new Employee();
            employee.ShowDialog();
        }

        private void sign_out_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
