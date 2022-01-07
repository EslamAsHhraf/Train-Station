﻿using System;
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
            control = new Controller();
            handle = new Handle();
            
        }



        private void Return_to_log_in_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void Create_account_Click_1(object sender, EventArgs e)
        {
            Trim_text();
            bool rightFormat = Create_Fname_TextBox.Text.All(Char.IsLetter) && Create_Minit_TextBox.Text.All(Char.IsLetter)
                            && Create_Lname_TextBox.Text.All(Char.IsLetter) && Serial_Covid_TextBox.Text.All(Char.IsDigit)
                            && handle.is_email(Create_Email_TextBox);
            bool isEmpty = Create_Pass_TextBox.Text.Length > 0 && Create_Username_TextBox.Text.Length > 0 &&
                        Create_Fname_TextBox.Text.Length > 0 && Create_Lname_TextBox.Text.Length > 0
                        && Create_VaccType_TextBox.Text.Length > 0 && Create_VaccOrg_TextBox.Text.Length > 0
                        && Create_Minit_TextBox.Text.Length == 1 && Serial_Covid_TextBox.Text.Length > 0
                        && Create_Gender_ComboBox.SelectedIndex != -1 && Create_Email_TextBox.Text.Length > 0;

            if (isEmpty == false || rightFormat == true)
            {
                if (Create_SSN_Serial_NumericUpDown.Text.Length != 9)
                {
                    MessageBox.Show("SSN should be 9 digits!");
                    return ;
                }
                if (Serial_Covid_TextBox.Text.Length != 9)
                {
                    MessageBox.Show("Serial Number of vaccination should be 9 digits!");
                    return ;
                }
                int result1 = control.Create_Vacc(Convert.ToInt32(Serial_Covid_TextBox.Text), Create_VaccType_TextBox.Text, Create_VaccOrg_TextBox.Text);
                int result2 = control.Create_Pass_Account(handle.Trim(Create_Email_TextBox).Text, handle.Trim(Create_Pass_TextBox).Text,
                                                Create_Username_TextBox.Text);

                int result3 = control.Insert_Pass(Convert.ToInt32(Create_SSN_Serial_NumericUpDown.Value),
                                                Create_Fname_TextBox.Text, char.Parse(Create_Minit_TextBox.Text),
                                                Create_Lname_TextBox.Text, Convert.ToChar(Create_Gender_ComboBox.SelectedItem),
                                                handle.Trim(Create_Email_TextBox).Text, Convert.ToInt32(Serial_Covid_TextBox.Text),
                                                Create_VaccDate_DateTimePicker.Value.Date);
                if (result1 == 0 || result2 == 0 || result3 ==0)
                {
                    MessageBox.Show("An error occurred during creating a new account");
                }
                else
                {
                    MessageBox.Show("An error occurred during creating a new account");
                }

            }
            else
            {
                MessageBox.Show("Make sure you entered valid inputs");
            }
        }
        private void Trim_text()
        {
            Create_Pass_TextBox = handle.Trim(Create_Pass_TextBox);
            Create_Username_TextBox = handle.Trim(Create_Username_TextBox);
            Create_Fname_TextBox = handle.Trim(Create_Fname_TextBox);
            Create_Lname_TextBox = handle.Trim(Create_Lname_TextBox);
            Create_VaccType_TextBox = handle.Trim(Create_VaccType_TextBox);
            Create_VaccOrg_TextBox = handle.Trim(Create_VaccOrg_TextBox);
            Create_Minit_TextBox = handle.Trim(Create_Minit_TextBox);
            Create_Email_TextBox = handle.Trim(Create_Email_TextBox);
        }
    }
}
