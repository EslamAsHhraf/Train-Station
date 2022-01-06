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
    public partial class Ticket_booking : Form
    {
        string Email; Controller controllerObj; Handle handleObj;

        public Ticket_booking(string e)
        {
            InitializeComponent();
            Email = e;
        }
        private void Ticket_booking_load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            handleObj = new Handle();
          
            DataTable dt = controllerObj.viewTrips();
            View_Trips_Grid.DataSource = dt;
            View_Trips_Grid.Refresh();
            
            DataTable y = controllerObj.viewTripIdEmployee();
            foreach (DataRow row in y.Rows)
                Trip_Code_CB.Items.Add(row[0].ToString());

            DataTable x = controllerObj.viewPassengerSSNEmployee();
            foreach (DataRow row in x.Rows)
                SSN_CB.Items.Add(row[0].ToString());
           
        }

        private void bookButton_Click(object sender, EventArgs e)

        {
            if(Trip_Code_CB.Text=="")
            {
                MessageBox.Show("Please pick a trip code! ");
                return;
            }
            if (Class_CB.Text == "")
            {
                MessageBox.Show("Please pick a class! ");
                return;
            }
            if (SSN_CB.Text == "")
            {
                MessageBox.Show("Please pick an SSN! ");
                return;
            }
            DataTable dt = controllerObj.getFirstAvailableTicketID(Int32.Parse(Trip_Code_CB.Text), Class_CB.Text[0]);
           

            if (dt==null)
            {
                MessageBox.Show("Unfortunatly this trip is fully booked! :( \n You can go to -View available seats- to view available seats in your desired trip");
                return;
            }
            string no="00";
           
            foreach (DataRow row in dt.Rows)
            {   
                no=row[0].ToString();
                break;
            }
            
            int essn = controllerObj.Get_SSN_Of_EmailEmployee(Email);
            int i = controllerObj.BookTicketEmployee(essn, Int32.Parse(SSN_CB.Text), Int32.Parse(no));
            if (i == 1)
            {
                MessageBox.Show("You succefully booked a ticket with Serial No. : " + no);
                this.Refresh();
            }
            else
                MessageBox.Show("Failed to book the ticket :(");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
