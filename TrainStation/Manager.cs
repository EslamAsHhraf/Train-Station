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

        private void view_passenger_Click(object sender, EventArgs e)
        {
           Passengers_data Data_view = new Passengers_data();
            Data_view.Show();
        }

        private void view_Employee_Click(object sender, EventArgs e)
        {
            Employees__data Data_view = new Employees__data();
            Data_view.Show();
        }

        private void Schedule_trips_Click(object sender, EventArgs e)
        {
            Schedule_trips Trip = new Schedule_trips();
            Trip.Show();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
}
