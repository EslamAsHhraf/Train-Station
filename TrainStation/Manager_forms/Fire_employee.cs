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
            DataTable vacc = con.Get_Vacc_Serial_ESSN(SSN.Text);
            string no = vacc.Rows[0][0].ToString();
            DataTable email = con.Get_Email_from_ssn(SSN.Text);
            string no2 = email.Rows[0][0].ToString();
            int Man = con.get_Authority(no2);
            if (Man!=0)
            {
                MessageBox.Show("You can't fire Manager or Admin");
                return;
            }
            con.Super_Employee(SSN.Text);
            int r = con.Delete_Employee(SSN.Text);
         
            int r2=con.Delete_vacc(Convert.ToInt32(no));
         
            int r3=con.Delete_Email(no2);
            if (r==0|| r2==0||r3==0)
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
