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
        Handle hand;
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load_1(object sender, EventArgs e)
        {
            controll = new Controller();
            hand = new Handle();
        }

        private void Fire_Employee_Click(object sender, EventArgs e)
        {
            bool Isopene = hand.IS_Open("Fire_employee");
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
            bool Isopene = hand.IS_Open("Change_Deb");
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
            bool Isopene = hand.IS_Open("Change_Salary");
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
            bool Isopene = hand.IS_Open("Change_rate");
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
            bool Isopene = hand.IS_Open("Passengers_data");
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
            bool Isopene = hand.IS_Open("Employees__data");
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
            bool Isopene = hand.IS_Open("Schedule_trips");
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
            bool Isopene = hand.IS_Open("Hire_Employee");
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
