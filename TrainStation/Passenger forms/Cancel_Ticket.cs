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
    public partial class Cancel_Ticket : Form
    {
        Controller controllerObj;
        int Passenger_SSN;
        public Cancel_Ticket(int pssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Passenger_SSN = pssn;
        }

        private void Cancel_Ticket_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Retrieve_Tickets_For_Passenger(Passenger_SSN);
            if (dt == null)
            {
                MessageBox.Show("You don't have any booked tickets to cancel");
                return;
            }
            else
            {
                CancelTicket_CB.DataSource = dt;
                CancelTicket_CB.DisplayMember = "TicketNo";
            }
        }

        private void Cancel_Ticket_Button_Click(object sender, EventArgs e)
        {
            if (CancelTicket_CB.Text.Length == 0)
            {
                MessageBox.Show("Please insert ticket number");
                return;
            }
            else
            {
                int r = controllerObj.Cancel_Ticket(Convert.ToInt32(CancelTicket_CB.Text));
                if (r == 0)
                {
                    MessageBox.Show("Ticket cancellation failed!");
                }
                else
                {
                    MessageBox.Show("Ticket cancelled successfully");
                    Cancel_Ticket_Load(sender, e);
                }

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
