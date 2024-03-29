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
    public partial class UserLog : Form
    {
        Handle hand;
        Controller control;
        public UserLog()
        {
            InitializeComponent();
            control = new Controller();
            hand = new Handle();

        }


        private void Create_acc_Click(object sender, EventArgs e)
        {
            Create_acc account = new Create_acc();
            account.ShowDialog();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void LogInButton_Click_1(object sender, EventArgs e)
        {
            bool check_empty = LogIn_Email_TextBox.Text.Length > 0 && LogIn_Pass_TextBox.Text.Length > 0;
            DataTable blocked = control.isBlocked(LogIn_Email_TextBox.Text);
            int isblocked = Convert.ToInt32(blocked.Rows[0][0]);
            if (isblocked == 1)
            {
                MessageBox.Show("This user is blocked");
                return;
            }
            if (!(hand.is_email(LogIn_Email_TextBox) && hand.is_valid(LogIn_Email_TextBox) && check_empty))
            {
                MessageBox.Show("Incorrect email or password");
            }
            else
            {
                if(control.Is_User_Login(LogIn_Email_TextBox.Text)==0)
                {
                    MessageBox.Show("There is no such email");
                    return;
                }
                DataTable dt = control.GetAuthority(hand.Trim(LogIn_Email_TextBox).Text.ToLower(), hand.Trim(LogIn_Pass_TextBox).Text);
                if(dt==null)
                {
                    MessageBox.Show("Incorrect Password");
                    return;
                }
                string auth = Convert.ToString(dt.Rows[0][0]);
                auth = auth.ToLower();
                if (auth == "admin")
                {
                    Form adminForm = new Admin(hand.Trim(LogIn_Email_TextBox).Text.ToLower());
                    adminForm.ShowDialog();
                }
                else if (auth == "employee")
                {
                    Form employeeForm = new Employee(hand.Trim(LogIn_Email_TextBox).Text.ToLower());
                    employeeForm.ShowDialog();
                }
                else if (auth == "manager")
                {
                    Form managerForm = new Manager();
                    managerForm.ShowDialog();
                }
                else if (auth == "passenger")
                {
                    Form passengerForm = new Passenger(hand.Trim(LogIn_Email_TextBox).Text.ToLower());
                    passengerForm.ShowDialog();
                }

            }
        }
    }
}
