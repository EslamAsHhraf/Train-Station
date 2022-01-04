using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainStation.Manager_forms
{
    public partial class Change_rate : Form
    {
        Controller con;
        public Change_rate()
        {
            InitializeComponent();
            con = new Controller();
            DataTable dt = con.SSN_Employee();
            SSN.DataSource = dt;
            SSN.DisplayMember = "SSN";
        }

        private void Rate_employee_Click(object sender, EventArgs e)
        {
            if(Rate.Text.Length ==0)
            {
                MessageBox.Show("please insert Rate");
                return;
            }
            int val;
            Int32.TryParse(Rate.Text, out val);
            if(val<0 || val>10)
            {
                MessageBox.Show("Rate should be between 0 and 10");
                return;
            }
            int r = con.Change_Rate(SSN.Text, Rate.Text);
            if (r == 0)
            {
                 MessageBox.Show("change rate of employee is failed!");
            }
            else
            {
                MessageBox.Show("change rate of employee is successfully!");
            }
         
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_rate_Load(object sender, EventArgs e)
        {

        }
    }
}
