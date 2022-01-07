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
    public partial class Add_PhoneNumber : Form
    {
        Controller controllerObj;
        int Passenger_SSN;
        Handle handleObj;
        public Add_PhoneNumber(int pssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            handleObj = new Handle();
            Passenger_SSN = pssn;
        }

        private void Add_PhoneNumber_Load(object sender, EventArgs e)
        {

        }

        private void Add_Phone_Number_Click(object sender, EventArgs e)
        {
            if (Add_Phone_Num_TB.Text.Length == 0)
            {
                MessageBox.Show("Please enter phone number");
                return;
            }
            if (Add_Phone_Num_TB.Text.Length != 11)
            {
                MessageBox.Show("Invalid phone number");
                return;
            }
            bool semo = true;
            semo = handleObj.is_valid(Add_Phone_Num_TB);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return;
            }
            bool val;
            int count = controllerObj.Check_If_PhoneNo_Exist(Add_Phone_Num_TB.Text, Passenger_SSN);
            if (count != 0)
            {
                MessageBox.Show("This phone number already exists");
                return;
            }
            val = Add_Phone_Num_TB.Text.All(char.IsDigit);
            if (val)
            {
                int r = controllerObj.Add_Phone_Number(Passenger_SSN, Add_Phone_Num_TB.Text);
                if (r == 0)
                {
                    MessageBox.Show("Failed to add phone number");
                }
                else
                {
                    MessageBox.Show("Phone number added successfully");
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
