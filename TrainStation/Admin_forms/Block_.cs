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
            DataTable dtPSSN = control.Select_Passenger_Emails();
            Pass_SSN_ComboBox.DataSource = dtPSSN;
            Pass_SSN_ComboBox.DisplayMember = "PSSN";
        }

        private void Blockbutton_Click(object sender, EventArgs e)
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
    }
}
