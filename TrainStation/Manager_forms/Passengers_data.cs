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
    public partial class Passengers_data : Form
    {
        Controller con;
        public Passengers_data()
        {
            InitializeComponent();
            con = new Controller();
        }

        private void Passengers_data_Load(object sender, EventArgs e)
        {
            DataTable dt = con.Passenger();
            data.DataSource = dt;
            data.Refresh();

            DataTable dt2 = con.SSN_Passenger();
            SSN.DataSource = dt2;
            SSN.DisplayMember = "Pass_SSN";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Get_phone_Click(object sender, EventArgs e)
        {
            if (SSN.SelectedIndex == -1)
            {
                MessageBox.Show("You should select SSN");
                return;
            }
            DataTable dt = con.get_tele_p(SSN.Text);
            if (dt == null)
            {
                MessageBox.Show("This passenger hasn't phone number");
            }
            SSN_PHONE.DataSource = dt;
            SSN_PHONE.Refresh();
        }
    }
}
