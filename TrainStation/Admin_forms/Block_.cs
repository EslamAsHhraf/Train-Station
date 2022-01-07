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
    public partial class Block_ : Form
    {
        Controller control;
        public Block_()
        {
            InitializeComponent();
            control = new Controller();
            DataTable dtPSSN = control.Select_Passenger_SSN();
            Pass_SSN_ComboBox.DataSource = dtPSSN;
            Pass_SSN_ComboBox.DisplayMember = "Pass_SSN";
        }

      

        private void Blockbutton_Click_1(object sender, EventArgs e)
        {
            int result = control.Add_BlackList(int.Parse(Pass_SSN_ComboBox.Text), dateTimePicker1.Value, BlackList_Reason_richTextBox.Text);
            if (result == 0)
            {
                MessageBox.Show("Couldn't block passenger");
            }
            else
            {
                MessageBox.Show("Blocked Passenger Successfully");

            }
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
