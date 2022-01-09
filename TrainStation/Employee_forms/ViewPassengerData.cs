using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainStation
{
    public partial class ViewPassengerData : Form
    {
        Controller controllerObj;
        public ViewPassengerData()
        {
            InitializeComponent();
        }

        private void ViewPassengerData_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable x = controllerObj.viewPassengerSSNEmployee();
            foreach (DataRow row in x.Rows)
                passengerSSNComboBox.Items.Add(row[0].ToString());
        }

        private void viewDetialsBtn_Click(object sender, EventArgs e)
        {
            if (passengerSSNComboBox.Text == "")
            {
                MessageBox.Show("Please select a passenger's SSN!");
                return;

            }
            int ssn = Int32.Parse(passengerSSNComboBox.Text);
            DataTable dt = controllerObj.viewPassengerDataEmployee(ssn);
            dataGridView1.DataSource = dt;

            dataGridView1.Refresh();
            DataTable dt2 = controllerObj.getPassPhoneNumberEmpoloyee(ssn);
            dataGridView2.DataSource = dt2;

            dataGridView2.Refresh();

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
