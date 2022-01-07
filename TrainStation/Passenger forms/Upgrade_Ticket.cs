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
        }

        private void Upgrade_Ticket_Button_Click(object sender, EventArgs e)
        {
            if (UpgradeTicket_CB.Text.Length == 0)
            {
                MessageBox.Show("Please insert ticket number");
                return;
            }
            string ticket_class = controllerObj.Get_Ticket_Class(Convert.ToInt32(UpgradeTicket_CB.Text));
            if (ticket_class == "V")
            {
                MessageBox.Show("Ticket is already first class");
                return;
            }
            int vip_count = controllerObj.Get_Available_VIP_Tickets();
            if (vip_count == 0)
            {
                MessageBox.Show("There are no available first class tickets");
                return;
            }
            else
            {
                DataTable tripcode = controllerObj.Get_Trip_Code(Convert.ToInt32(UpgradeTicket_CB.Text));
                string no2 = "";
                foreach (DataRow row in tripcode.Rows)
                {
                    no2 = row[0].ToString();
                    break;
                }
                DataTable get_vip_ticket = controllerObj.Get_Next_Available_Ticket(Int32.Parse(no2), 'V');
                string no = "";
                foreach (DataRow row in get_vip_ticket.Rows)
                {
                    no = row[0].ToString();
                    break;
                }
                int cancel = controllerObj.Cancel_Ticket(Convert.ToInt32(UpgradeTicket_CB.Text));
                if (cancel == 0)
                {
                    MessageBox.Show("Ticket upgrade failed!");
                }
                else
                {
                    int book = controllerObj.Book_Ticket_Passenger(Passenger_SSN, Int32.Parse(no));
                    if (book == 0)
                    {
                        MessageBox.Show("Ticket upgrade failed!");
                    }
                    else
                    {
                        MessageBox.Show("Ticket upgraded successfully");
                        Upgrade_Ticket_Load(sender, e);
                    }
                }

            }
        }

        private void Upgrade_Ticket_Load(object sender, EventArgs e)
        {
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
