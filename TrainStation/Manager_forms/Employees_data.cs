using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainStation.Manager_s_forms
{
    public partial class Employees__data : Form
    {
        Controller con;
        public Employees__data()
        {
            InitializeComponent();
            con = new Controller();
        }

        private void Employees__data_Load(object sender, EventArgs e)
        {
            DataTable dt = con.Employee();
            data.DataSource = dt;
            data.Refresh();

            DataTable dt2 = con.SSN_Employee();
            SSN.DataSource = dt2;
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

        private void Get_phone_Click(object sender, EventArgs e)
        {
            if(SSN.SelectedIndex==-1)
            {
                MessageBox.Show("You should select SSN");
                return;
            }
            DataTable dt = con.get_tele_E(SSN.Text);
            if(dt==null)
            {
                MessageBox.Show("This employee hasn't phone number");
            }
            SSN_PHONE.DataSource = dt;
            SSN_PHONE.Refresh();
        }
    }
}
