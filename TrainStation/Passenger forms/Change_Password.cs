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
    public partial class Change_Password : Form
    {
        Controller controllerObj;
        Handle handleObj;
        string Email;
        public Change_Password(string email)
        {
            InitializeComponent();
            controllerObj = new Controller();
            handleObj = new Handle();
            Email = email;
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {

        }

        private void Change_Pass_Button_Click(object sender, EventArgs e)
        {
            if (Old_Pass_TB.Text.Length == 0 || New_Pass_TB.Text.Length == 0)
            {
                MessageBox.Show("Please enter passwords");
                return;
            }
            string old_password = controllerObj.Check_Old_Password(Email);
            if (old_password != Old_Pass_TB.Text)
            {
                MessageBox.Show("Incorrect Password");
                return;
            }
            bool semi_val = handleObj.is_valid(New_Pass_TB);
            if (semi_val)
            {
                int r = controllerObj.Change_Password_Passenger(Email, New_Pass_TB.Text);
                if (r == 0)
                {
                    MessageBox.Show("Failed to change password");
                }
                else
                {
                    MessageBox.Show("Password changed successfully");
                }
            }
            else
            {
                MessageBox.Show("You can't insert ;");
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
