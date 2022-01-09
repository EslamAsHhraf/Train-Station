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
        string Email;

        public UpdateMyData(string e)
        {
            InitializeComponent();
            Email = e;
            
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
            bool semi_val = handleObj.is_valid(newPhoneNumTextBox);
            if (!semi_val)
            {
                MessageBox.Show("You can't insert ;");
                return;
            }

            bool x = Int32.TryParse(newPhoneNumTextBox.Text, out int i);
            if (!x||newPhoneNumTextBox.Text.Length!=11)
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }
            int m = Int32.Parse(newPhoneNumTextBox.Text);
            int essn = controllerObj.Get_SSN_Of_EmailEmployee(Email);
            int y = controllerObj.updateEmployeePhoneEmployee(newPhoneNumTextBox.Text, essn);
            if (y == 1)
                MessageBox.Show("You successfully added a phone number");
            else
                MessageBox.Show("The phone number already exists for this user");
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
            bool semi_val = handleObj.is_valid(newEmailTextBox);
            if (!semi_val)
            {
                MessageBox.Show("You can't insert ;");
                return;
            }
            int ssn = controllerObj.Get_SSN_Of_EmailEmployee(Email);

            int y= controllerObj.updateEmpEmailEmployee(newEmailTextBox.Text,ssn, Email);
            if (y == 2)
            {
                MessageBox.Show("You successfully updated your Email");
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name != "UserLog")
                        f.Close();
                }
                Form passengerForm = new Employee(newEmailTextBox.Text);
                passengerForm.ShowDialog();
            }
            else
                MessageBox.Show("Failed to update your email");

        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please enter a password");
                return;
            }
            bool semi_val = handleObj.is_valid(newPasswordTextBox);
            if (!semi_val)
            {
                MessageBox.Show("You can't insert ;");
                return;
            }
            string oldP = controllerObj.getEmpPasswordEmployee(Email);
            if (oldP != oldPasswordTxt.Text)
            {
                MessageBox.Show("Incorrect old passowrd!");
                return;
            }
            int y= controllerObj.updateEmpPassowrdEmployee(newPasswordTextBox.Text, Email);
            if (y == 1)
                MessageBox.Show("You successfully updated your password");
            else
                MessageBox.Show("Failed to update your password");
        }
    }
}
