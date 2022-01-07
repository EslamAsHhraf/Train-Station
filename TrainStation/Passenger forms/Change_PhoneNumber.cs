using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainStation.Passenger_forms
{
    public partial class Change_PhoneNumber : Form
    {
        Controller controllerObj;
        int Passenger_SSN;
        Handle handleObj;
        public Change_PhoneNumber(int pssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            handleObj = new Handle();
            Passenger_SSN = pssn;
        }

        private void Change_PhoneNumber_Load(object sender, EventArgs e)
        {

        }

        private void Change_Phone_Click(object sender, EventArgs e)
        {
            if (New_Phone_Num_TB.Text.Length == 0)
            {
                MessageBox.Show("Please enter phone number");
                return;
            }
            if (New_Phone_Num_TB.Text.Length != 11)
            {
                MessageBox.Show("Invalid phone number");
                return;
            }
            bool semo = true;
            semo = handleObj.is_valid(New_Phone_Num_TB);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return;
            }
            bool val = New_Phone_Num_TB.Text.All(char.IsDigit);
            if (val)
            {
                int r = controllerObj.Change_Phone_Number(New_Phone_Num_TB.Text, Old_Phone_Num_TB.Text, Passenger_SSN);
                if (r == 0)
                {
                    MessageBox.Show("Failed to change phone number");
                }
                else
                {
                    MessageBox.Show("Phone changed added successfully");
                }
            }
            else
            {
                MessageBox.Show("Invalid phone number");
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
