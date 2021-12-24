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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

      
        private void bookTicketBtn_Click(object sender, EventArgs e)
        {
            Form f = new Ticket_booking();
            f.ShowDialog();
        }

        private void upgradeTicketBtn_Click(object sender, EventArgs e)
        {
            Form f = new UpgradeTicket();
            f.ShowDialog();
        }

        private void viewTicketDetailsBtn_Click(object sender, EventArgs e)
        {
            Form f = new ViewTicketDetails();
            f.ShowDialog();

        }

        private void cancelTicketBtn_Click(object sender, EventArgs e)
        {

            Form f = new CancelTicket();
            f.ShowDialog();

        }

        private void viewPassengersDataBtn_Click(object sender, EventArgs e)
        {
            Form f = new ViewPassengerData();
            f.ShowDialog();
        }

        private void viewAvailableTripsBtn_Click(object sender, EventArgs e)
        {
            Form f = new ViewTrips();
            f.ShowDialog();
        }

        private void upgradePassengerDataBtn_Click(object sender, EventArgs e)
        {
            Form f = new updatePassengerData();
            f.ShowDialog();
        }

        private void viewAvailableSeatsBtn_Click(object sender, EventArgs e)
        {
            Form f = new ViewSeats();
            f.ShowDialog();
        }

        private void checkTrainStatusBtn_Click(object sender, EventArgs e)
        {
            Form f = new TrainStatus();
            f.ShowDialog();
        }
    }
}
