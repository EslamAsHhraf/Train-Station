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
    public partial class Create_acc : Form
    {
        Handle handle;
        Controller control;
        public Create_acc()
        {
            InitializeComponent();

        }



        private void Return_to_log_in_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Create_account_Click(object sender, EventArgs e)
        {

            if (false)
            {

            }
            else
            {
                int result1 = control.Create_Pass_Account(handle.Trim(Create_Email_TextBox).Text, handle.Trim(Create_Pass_TextBox).Text,
                                                Create_Username_TextBox.Text);

                int result2 = control.Insert_Pass(Convert.ToInt32(Create_SSN_Serial_NumericUpDown.Value),
                                                Create_Fname_TextBox.Text, char.Parse(Create_Minit_TextBox.Text),
                                                Create_Lname_TextBox.Text, Convert.ToChar(Create_Gender_ComboBox.SelectedItem),
                                                handle.Trim(Create_Email_TextBox).Text, Convert.ToInt32(Create_CV_Serial_NumericUpDown.Value),
                                                Create_VaccDate_DateTimePicker.Value.Date);
                if (result1 == 0 || result2 == 0)
                {

                }
                else
                {

                }
            }

        }
    }
}
