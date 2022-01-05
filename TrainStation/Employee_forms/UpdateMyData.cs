using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainStation.Employee_forms
{
    public partial class UpdateMyData : Form
    {
        Controller controllerObj;
        Handle handleObj;

        public UpdateMyData()
        {
            InitializeComponent();
            
        }
        private void UpdateMyData_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            handleObj = new Handle();
            
        }

        private void changePhoneNumButton_Click(object sender, EventArgs e)
        {
            if (newPhoneNumTextBox.Text == "")
            {
                MessageBox.Show("Please enter a phone number!");
                return;
            }


            bool x = Int32.TryParse(newPhoneNumTextBox.Text, out int i);
            if (!x)
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }
            Int32 m = Int32.Parse(newPhoneNumTextBox.Text);
            //int y = controllerObj.updatePassengerPhoneEmployee(m, Int32.Parse(ssn));
            //if (y == 1)
            //    MessageBox.Show("You successfully added a phone number");
            //else
            //    MessageBox.Show("The phone number already exists for this user");
        }

        private void changeEmailButton_Click(object sender, EventArgs e)
        {
          
            if (newEmailTextBox.Text == "")
            {
                MessageBox.Show("Please enter an email");
                return;
            }
            bool x = handleObj.is_email(newEmailTextBox);
            if (!x)
            {
                MessageBox.Show("Please enter a valid Email.");
                return;
            }
            //string oldEmial;//= controllerObj.getEmpEmailEmployee(Int32.Parse(passengerSSNComboBox.Text));
            //int y;//= controllerObj.updateEmpEmailEmployee(newEmailTextBox.Text, Int32.Parse(passengerSSNComboBox.Text), oldEmial);
            //if (y == 2)
            //    MessageBox.Show("You successfully updated your Email");
            //else
            //    MessageBox.Show("Failed to update your email");

        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please enter a password");
                return;
            }
            //string Email;// = controllerObj.getEmpEmailEmployee();
            //int y;//= controllerObj.updatePassengerPassowrdEmployee(newPasswordTextBox.Text, Email);
            //if (y == 1)
            //    MessageBox.Show("You successfully updated your password");
            //else
            //    MessageBox.Show("Failed to update your password");
        }
    }
}
