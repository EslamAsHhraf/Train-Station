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
    public partial class updatePassengerData : Form
    {
        Controller controllerObj;
        Handle handleObj;

        public updatePassengerData()
        {
            InitializeComponent();
        }
        private void updatePassengerData_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            handleObj = new Handle();
            DataTable x = controllerObj.viewPassengerSSNEmployee();
            foreach (DataRow row in x.Rows)
                passengerSSNComboBox.Items.Add(row[0].ToString());
        }
        private void changePhoneNumButton_Click(object sender, EventArgs e)
        {
            if (passengerSSNComboBox.Text == "")
            {
                MessageBox.Show("Please select a passenger's SSN!");
                return;
            }
            bool x = Int32.TryParse(newPhoneNumTextBox.Text, out int i);
            if (!x)
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }
            Int32 m = Int32.Parse(newPhoneNumTextBox.Text);
            int y = controllerObj.updatePassengerPhoneEmployee(m, Int32.Parse(passengerSSNComboBox.Text));
            if (y == 1)
                MessageBox.Show("You successfully added a new passenger's phone number");
            else
                MessageBox.Show("The phone number already exists for this passenger");


        }

        private void changeEmailButton_Click(object sender, EventArgs e)
        {
            if (passengerSSNComboBox.Text == "")
            {
                MessageBox.Show("Please select a passenger's SSN!");
                return;
            }
            bool x = handleObj.is_email(newEmailTextBox);
            if (!x)
            {
                MessageBox.Show("Please enter a valid Email.");
                return;
            }
            string oldEmial = controllerObj.getPassEmailEmployee(Int32.Parse(passengerSSNComboBox.Text));
            int y = controllerObj.updatePassengerEMailEmployee(newEmailTextBox.Text, Int32.Parse(passengerSSNComboBox.Text),oldEmial);
            if(y==2)
                MessageBox.Show("You successfully updated the passenger's Email");
            else
                MessageBox.Show("Failed to update the passenger's email");


        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if (passengerSSNComboBox.Text == "")
            {
                MessageBox.Show("Please select a passenger's SSN!");
                return;
            }
            string Email = controllerObj.getPassEmailEmployee(Int32.Parse(passengerSSNComboBox.Text));
            int y = controllerObj.updatePassengerPassowrdEmployee(newPasswordTextBox.Text, Email);
            if (y==1) 
                MessageBox.Show("You successfully updated the passenger's Password");
            else
                MessageBox.Show("Failed to update the passenger's password");

        }
    }
}
