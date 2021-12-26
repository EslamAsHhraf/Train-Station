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
            Fire_employee Fire = new Fire_employee();
            Fire.ShowDialog();
        }

        private void Change_Dep_Click(object sender, EventArgs e)
        {
            Change_Deb changeDeb = new Change_Deb();
            changeDeb.ShowDialog();
        }

        private void Change_Salary_Click(object sender, EventArgs e)
        {
            Change_Salary changeSalary = new Change_Salary();
            changeSalary.ShowDialog();
        }

        private void Change_rate_Click(object sender, EventArgs e)
        {
            Change_rate changeRate = new Change_rate();
            changeRate.ShowDialog();
        }

        private void view_passenger_Click_1(object sender, EventArgs e)
        {
            Passengers_data Data_view = new Passengers_data();
            Data_view.ShowDialog();
        }

        private void view_Employee_Click_1(object sender, EventArgs e)
        {
            Employees__data Data_view = new Employees__data();
            Data_view.ShowDialog();
        }

        private void Schedule_trips_Click_1(object sender, EventArgs e)
        {
            Schedule_trips Trip = new Schedule_trips();
            Trip.ShowDialog();
        }

        private void Hire_E_Click(object sender, EventArgs e)
        {
            Hire_Employee Hire = new Hire_Employee();
            Hire.ShowDialog();
        }

        private void sign_out_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
