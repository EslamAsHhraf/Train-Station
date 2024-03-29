﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainStation.Manager_forms
{
    public partial class Hire_Employee : Form
    {
        Controller con;
        Handle Hand;
        public Hire_Employee()
        {
            InitializeComponent();
            Hand = new Handle();
            con = new Controller();
        }

        private void Hire_Emplotee_Load(object sender, EventArgs e)
        {
            DataTable dt = con.SSN_Employee();
            Super_SSN.DataSource = dt;
            Super_SSN.DisplayMember = "SSN";

            DataTable dt2 = con.Dno_Department();
            foreach (DataRow row in dt2.Rows)
            {
                if (row["DepartmentNumber"].ToString() == "1")
                {
                    row.Delete();
                }
            }
            DNO.DataSource = dt2;
            DNO.DisplayMember = "DepartmentNumber";
        }

        private void New_Employee_Click(object sender, EventArgs e)
        {
            Trim_text();
            bool embty = is_embty();
            if (embty )
            {
                return;
            }
            bool Format = rightFormat();
            if (!Format)
            {
                return;
            }
            bool Semo = is_semo();
            if (Semo)
            {
                return;
            }
            int val;
            Int32.TryParse(Rate.Text, out val);
            if (!(val >= 0 && val <= 10))
            {
                MessageBox.Show("This Rate should be between 0 and 10");
                return;
            }
            bool emaill = Hand.is_email(Email);
            if (!emaill)
            {
                MessageBox.Show("Invaild email, it doesn't include @");
                return;
            }
            int s = con.Is_Employee(SSN.Text);
            if (s != 0)
            {
                MessageBox.Show("This SSN is alraedy exists");
                return;
            }

            int c = con.Is_CovidVaccination(Serial_num.Text);
            if (c != 0)
            {
                MessageBox.Show("This Serial number vaccination is alraedy exists");
                return;
            }
            int log = con.Is_User_Login(Email.Text);
            if (log != 0)
            {
                MessageBox.Show("This Email is alraedy exists");
                return;
            }
            int ins1 = con.Insert_CovidVaccination(Serial_num.Text, Type_of_vacc.Text, organis.Text);
            if (ins1 == 0)
            {
                MessageBox.Show("Hire new employee is failed");
                return;
            }
            int ins2 = con.Insert_User_Login(Email.Text, Password.Text, "employee", user_name.Text);
            if (ins2 == 0)
            {
                MessageBox.Show("Hire new employee is failed");
                return;
            }
            string temp_mid= Mname.Text;
            temp_mid = temp_mid.ToUpper();
            char m_char = temp_mid[0];
            string mname = m_char.ToString();
            int ins3 = con.Insert_Employee(SSN.Text, Fname.Text, mname, Lname.Text, Gender.Text, DOB.Text, Salary.Text, House_num.Text, Street.Text, City.Text, Super_SSN.Text, DNO.Text
                , Serial_num.Text, Date_Of_vacc.Text, Email.Text);
            if ( ins3 == 0)
            {
                MessageBox.Show("Hire new employee is failed");
            }
            else
            {
                if (Rate.Text.Length != 0)
                {
                    con.Set_Rate_Employee(SSN.Text, Rate.Text);
                }
                MessageBox.Show("Hire new employee is successfully");
               // Hire_Emplotee_Load(sender, e);
            }
        }
        private bool rightFormat()
        {
            if (!Fname.Text.All(Char.IsLetter))
            {
                MessageBox.Show("you can't insert number in first name!");
                return false;
            }
            if(!Mname.Text.All(Char.IsLetter))
            {
                MessageBox.Show("you can't insert number in Middle name!");
                return false;
            }
            if(!Lname.Text.All(Char.IsLetter))
            {
                MessageBox.Show("you can't insert number in last name!");
                return false;
            }
            if(SSN.Text.Length!=9)
            {
                MessageBox.Show("SSN should be 9 digits!");
                return false;
            } 
            if(Serial_num.Text.Length != 9)
            {
                MessageBox.Show("Serial Number of vaccination should be 9 digits!");
                return false;
            }
            if (Salary.Text.Length >= 7)
            {
                MessageBox.Show("Salary should be less than 7 digits!");
                return false;
            }
            if (House_num.Text.Length > 5)
            {
                MessageBox.Show("Salary should be less than 5 digits!");
                return false;
            }
            return true;
        }
        private bool is_embty()
        {
            if(Fname.Text.Length==0)
            {
                MessageBox.Show("you should insert first name!");
                return true;
            }
            if (Mname.Text.Length == 0)
            {
                MessageBox.Show("you should insert middle name!");
                return true;
            }
            if (Lname.Text.Length == 0)
            {
                MessageBox.Show("you should insert last name!");
                return true;
            }
            if (Gender.SelectedIndex == -1)
            {
                MessageBox.Show("you should select gender!");
                return true;
            }
            if (Salary.Text.Length == 0)
            {
                MessageBox.Show("you should insert Salary!");
                return true;
            }
            if (House_num.Text.Length == 0)
            {
                MessageBox.Show("you should insert House Number!");
                return true;
            }
            if (Street.Text.Length == 0)
            {
                MessageBox.Show("you should insert Street!");
                return true;
            }
            if (City.Text.Length == 0)
            {
                MessageBox.Show("you should insert Street!");
                return true;
            }
            if (Serial_num.Text.Length == 0)
            {
                MessageBox.Show("you should insert serial number of vaccination!");
                return true;
            }
            if (Type_of_vacc.Text.Length == 0)
            {
                MessageBox.Show("you should insert type of vaccination!");
                return true;
            }
            if (organis.Text.Length == 0)
            {
                MessageBox.Show("you should insert the organisation!");
                return true;
            }
            if (Email.Text.Length == 0)
            {
                MessageBox.Show("you should insert Email!");
                return true;
            }
            if (Password.Text.Length == 0)
            {
                MessageBox.Show("you should insert Password!");
                return true;
            }
            if (user_name.Text.Length == 0)
            {
                MessageBox.Show("you should insert user name !");
                return true;
            }
            return false;
        }
        private void Trim_text()
        {
            Fname = Hand.Trim(Fname);
            Mname = Hand.Trim(Mname);
            Lname = Hand.Trim(Lname);
            Street = Hand.Trim(Street);
            CITY_ = Hand.Trim(CITY_);
            Type_of_vacc = Hand.Trim(Type_of_vacc);
            organis = Hand.Trim(organis);
            Email = Hand.Trim(Email);
            user_name = Hand.Trim(user_name);
            
        }
        private bool is_semo()
        {
            bool semo = true;
            semo = Hand.is_valid(Fname);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return true;
            }
            semo = Hand.is_valid(Mname);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return true;
            }
            semo = Hand.is_valid(Lname);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return true;
            }
            semo = Hand.is_valid(Street);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return true;
            }
            semo = Hand.is_valid(CITY_);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return true;
            }
            semo = Hand.is_valid(Type_of_vacc);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return true;
            }
            semo = Hand.is_valid(organis);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return true;
            }
            semo = Hand.is_valid(Email);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return true;
            }
            semo = Hand.is_valid(Password);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return true;
            }
            semo = Hand.is_valid(user_name);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return true;
            }
            return false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}
