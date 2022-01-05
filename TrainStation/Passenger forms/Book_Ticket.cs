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
        }

        private void Vew_Trips_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.View_Available_Trips();
            View_Trips_Grid.DataSource = dt;
            View_Trips_Grid.Refresh();
        }

        private void Book_Ticket2_Click(object sender, EventArgs e)
        {
            if (Trip_Code_CB.Text.Length == 0)
            {
                MessageBox.Show("Please Choose a Trip Code!");
                return;
            }
            int r2 = 0;//= controllerObj.Book_Ticket();
            if (r2 == 0)
            {
                MessageBox.Show("trip insert failed!");
            }
            else
            {
                MessageBox.Show("trip inserted successfully");
            }
        }

        private void Book_Ticket_Load(object sender, EventArgs e)
        {

        }
    }
}
