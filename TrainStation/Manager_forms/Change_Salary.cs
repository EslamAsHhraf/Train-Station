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
    public partial class Change_Salary : Form
    {
        Controller con;
        public Change_Salary()
        {
            InitializeComponent();
            con = new Controller();
            DataTable dt = con.SSN_Employee();
            SSN.DataSource = dt;
            SSN.DisplayMember = "SSN";
        }

        private void ChangeSalary_Click(object sender, EventArgs e)
        {
            if (Salary.Text.Length == 0)
            {
                MessageBox.Show("please insert Salary");
                return;
            }
            int val;
            Int32.TryParse(Salary.Text, out val);
            if (val < 0)
            {
                MessageBox.Show("Salary should be large than 0");
                return;
            }
            int r = con.Change_Salary(SSN.Text, Salary.Text);
            MessageBox.Show("change salary of employee is successfully!");
        }
    }
}
