using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainStation.Manager_s_forms;
using TrainStation.Manager_forms;
using System.Configuration;
using TrainStation.Admin_forms;
namespace TrainStation
{
    public partial class Manager : Form
    {
        Controller controll;
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load_1(object sender, EventArgs e)
        {
            controll = new Controller();
        }

        private void Fire_Employee_Click(object sender, EventArgs e)
        {
            bool Isopene = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Fire_employee")
                {
                    Isopene = true;
                    break;
                }
            }
            if (!Isopene)
            {
                Fire_employee Fire = new Fire_employee();
                Fire.Show();
            }
            else
            {
                MessageBox.Show("Window of Fire Employee Is open already!");
            }
        }

        private void Change_Dep_Click(object sender, EventArgs e)
        {
            bool Isopene = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Change_Deb")
                {
                    Isopene = true;
                    break;
                }
            }
            if (!Isopene)
            {
                Change_Deb changeDeb = new Change_Deb();
                changeDeb.Show();
            }
            else
            {
                MessageBox.Show("Window of Change Debartment Is open already!");
            }
        }

        private void Change_Salary_Click(object sender, EventArgs e)
        {
            bool Isopene = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Change_Salary")
                {
                    Isopene = true;
                    break;
                }
            }
            if (!Isopene)
            {
                Change_Salary changeSalary = new Change_Salary();
                changeSalary.Show();
            }
            else
            {
                MessageBox.Show("Window of Change Salary Is open already!");
            }
        }

        private void Change_rate_Click(object sender, EventArgs e)
        {
            bool Isopene = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Change_rate")
                {
                    Isopene = true;
                    break;
                }
            }
            if (!Isopene)
            {
                Change_rate changeRate = new Change_rate();
                changeRate.Show();
            }
            else
            {
                MessageBox.Show("Window of Change Rate Is open already!");
            }
        }

        private void view_passenger_Click_1(object sender, EventArgs e)
        {
            bool Isopene = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Passengers_data")
                {
                    Isopene = true;
                    break;
                }
            }
            if (!Isopene)
            {
                Passengers_data Data_view = new Passengers_data();
                Data_view.Show();
            }
            else
            {
                MessageBox.Show("Window of Passengers Data Is open already!");
            }
        }

        private void view_Employee_Click_1(object sender, EventArgs e)
        {
            bool Isopene = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Employees__data")
                {
                    Isopene = true;
                    break;
                }
            }
            if (!Isopene)
            {
                Employees__data Data_view = new Employees__data();
                Data_view.Show();
            }
            else
            {
                MessageBox.Show("Window of Employees Data Is open already!");
            }
        }

        private void Schedule_trips_Click_1(object sender, EventArgs e)
        {
            bool Isopene = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Schedule_trips")
                {
                    Isopene = true;
                    break;
                }
            }
            if (!Isopene)
            {
                Schedule_trips Trip = new Schedule_trips();
                Trip.Show();
            }
            else
            {
                MessageBox.Show("Window of Schedule Trips Is open already!");
            }
        }

        private void Hire_E_Click(object sender, EventArgs e)
        {
            bool Isopene = false ;
            foreach(Form f in Application.OpenForms)
            {
                if(f.Text== "Hire_Emplotee")
                {
                    Isopene = true;
                    break;
                }
            }
            if (!Isopene)
            {
                Hire_Employee Hire = new Hire_Employee();
                Hire.Show();
            }
            else
            {
                MessageBox.Show("Window of Hire Employee Is open already!");
            }
        }
    }
}
