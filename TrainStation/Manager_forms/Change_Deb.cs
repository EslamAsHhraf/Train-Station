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
    public partial class Change_Deb : Form
    {
        Controller con;
        public Change_Deb()
        {
            InitializeComponent();
            con = new Controller();
            DataTable dt = con.SSN_Employee();
            SSN.DataSource = dt;
            SSN.DisplayMember = "SSN";

            DataTable dt2 = con.Dno_Department();
            foreach (DataRow row in dt2.Rows)
            {
                if (row["DepartmentNumber"].ToString() == "1")
                {
                    row.Delete();
                }
            }
            Department_num.DataSource = dt2;
            Department_num.DisplayMember = "DepartmentNumber";
        }

        private void Change_department_Click(object sender, EventArgs e)
        {
            int r = con.Change_Department(SSN.Text, Department_num.Text);
            if (r == 0)
            {
                MessageBox.Show("Change department of employee is failed!");
            }
            else
            {
                MessageBox.Show("Change department of employee is successfully!");
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

        private void Change_Deb_Load(object sender, EventArgs e)
        {

        }
    }
}
