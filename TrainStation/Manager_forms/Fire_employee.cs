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
    public partial class Fire_employee : Form
    {
        Controller con;
        public Fire_employee()
        {
            InitializeComponent();
            con = new Controller();
          
        }

        private void Fireemployee_Click(object sender, EventArgs e)
        {
            if (SSN.Text == "666664445")
            {
                MessageBox.Show("You can't fire manager");
                return;
            }
            con.Super_Employee(SSN.Text);
            int r = con.Delete_Employee(SSN.Text);
            if(r==0)
            {
                MessageBox.Show("Delete employee is failed!");
            }
            else
            {
                MessageBox.Show("Delete employee is successfully!");
                Fire_employee_Load(sender,e);
            }

        }

        private void Fire_employee_Load(object sender, EventArgs e)
        {
            DataTable dt = con.SSN_Employee();
            SSN.DataSource = dt;
            SSN.DisplayMember = "SSN";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
