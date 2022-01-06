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
    public partial class Change_Email : Form
    {
        Controller controllerObj;
        Handle handleObj;
        string Email;

        public Change_Email(string email)
        {
            InitializeComponent();
            controllerObj = new Controller();
            handleObj = new Handle();
            Email = email;
        }

        private void Change_Email_Load(object sender, EventArgs e)
        {

        }

        private void Change_Email_Button_Click(object sender, EventArgs e)
        {
            handleObj.Trim(New_Email_TB);
            if (New_Email_TB.Text.Length == 0)
            {
                MessageBox.Show("Please insert email");
                return;
            }
            bool email_val = handleObj.is_email(New_Email_TB);
            bool semi_val = handleObj.is_valid(New_Email_TB);
            if (!email_val)
            {
                MessageBox.Show("Invalid email");
                return;
            }
            if(!semi_val)
            {
                MessageBox.Show("You can't insert ;");
                return;
            }
            else
            {
                int r = controllerObj.Change_Email_Passenger(New_Email_TB.Text, Email);
                if (r == 0)
                {
                    MessageBox.Show("Failed to change email");
                }
                else
                {
                    MessageBox.Show("Email changed successfully");
                }
            }
        }
    }
}
