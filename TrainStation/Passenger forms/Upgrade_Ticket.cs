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
    public partial class Upgrade_Ticket : Form
    {
        Controller controllerObj;
        int Passenger_SSN;
        public Upgrade_Ticket(int pssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Passenger_SSN = pssn;
            DataTable dt = controllerObj.Retrieve_Tickets_For_Passenger(Passenger_SSN);
            if (dt == null)
            {
                MessageBox.Show("You don't have any booked tickets to upgrade");
            }
            else
            {
                UpgradeTicket_CB.DataSource = dt;
                UpgradeTicket_CB.DisplayMember = "TicketNo";
            }
        }

        private void Upgrade_Ticket_Load(object sender, EventArgs e)
        {

        }

        private void Upgrade_Ticket_Button_Click(object sender, EventArgs e)
        {
            if (UpgradeTicket_CB.Text.Length == 0)
            {
                MessageBox.Show("Please insert ticket number");
                return;
            }

            char ticket_class = controllerObj.Get_Ticket_Class(Convert.ToInt32(UpgradeTicket_CB.Text));
            if (ticket_class == 'B')
            {
                MessageBox.Show("Ticket is already first class");
                return;
            }
            else
            {
                int r = controllerObj.Upgrade_Ticket(Convert.ToInt32(UpgradeTicket_CB.Text));
                if (r == 0)
                {
                    MessageBox.Show("Ticket upgrade failed!");
                }
                else
                {
                    MessageBox.Show("Ticket upgraded successfully");
                }

            }
        }
    }
}
