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
    public partial class Book_Ticket : Form
    {
        Controller controllerObj;
        int Passenger_SSN;
        public Book_Ticket(int pssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Passenger_SSN = pssn;
            DataTable dt = controllerObj.Retrieve_Available_Trips();
            if (dt == null)
            {
                MessageBox.Show("There are no available trips");
            }
            else
            {
                Trip_Code_CB.DataSource = dt;
                Trip_Code_CB.DisplayMember = "Trip_Code";
            }
        }

        private void Vew_Trips_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.View_Available_Trips();
            View_Trips_Grid.DataSource = dt;
            View_Trips_Grid.Refresh();
        }

        private void Book_Ticket2_Click(object sender, EventArgs e)
        {
            int available_ticket = controllerObj.Get_Next_Available_Ticket(Convert.ToInt32(Trip_Code_CB.Text), Convert.ToChar(Class_CB.Text));
            if (available_ticket == -1)
            {
                MessageBox.Show("There are no available tickets");
                return;
            }
            if (Trip_Code_CB.Text.Length == 0)
            {
                MessageBox.Show("Please select a trip code");
                return;
            }
            if (Class_CB.Text.Length == 0)
            {
                MessageBox.Show("Please select ticket class");
                return;
            }
            int r = controllerObj.Book_Ticket_Passenger(Passenger_SSN, available_ticket);
            if (r == 0)
            {
                MessageBox.Show("Failed to book ticket");
            }
            else
            {
                MessageBox.Show("Ticket booked successfully");
            }
        }
    }
}
