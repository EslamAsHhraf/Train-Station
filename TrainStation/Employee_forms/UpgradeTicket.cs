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
    public partial class UpgradeTicket : Form
    {
        Controller controllerObj;

        public UpgradeTicket()
        {
            InitializeComponent();
        }
        private void UpgradeTicket_load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable x = controllerObj.viewTicketNumbers();
            foreach (DataRow row in x.Rows)
                ticketSerialNoComboBox.Items.Add(row[0].ToString());
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ticketSerialNoComboBox.Text == "")
            {
                MessageBox.Show("Please select a ticket!");
                return;

            }
            if (newClassComboBox.Text == "")
            {
                MessageBox.Show("Please select a class!");
                return;

            }
            string tClass = controllerObj.getTicketClass(Int32.Parse(ticketSerialNoComboBox.Text));
            if(tClass[0]==newClassComboBox.Text[0])
            {
                MessageBox.Show("The ticket's class is already " + tClass + "!");
                return;
            }
            string tripCode = controllerObj.getTripCodeOfTIcketEmployee(Int32.Parse(ticketSerialNoComboBox.Text));
            DataTable availableTickets = controllerObj.getFirstAvailableTicketID(tripCode, newClassComboBox.Text[0]);
            if (availableTickets == null)
            {
                MessageBox.Show("There are no available tickets in class "+newClassComboBox.Text);
                return;
            }
            string no = "00";

            foreach (DataRow row in availableTickets.Rows)
            {
                no = row[0].ToString();
                break;
            }
            controllerObj.changeTicketClass(tClass[0], Int32.Parse(no));
            int x = controllerObj.changeTicketClass(newClassComboBox.Text[0], Int32.Parse(ticketSerialNoComboBox.Text));
           
            if (x==1)
            MessageBox.Show("You succefully upgraded a ticket with Serial No. : "+ticketSerialNoComboBox.Text+" \n " +
                "To class : "+newClassComboBox.Text);
        }

        
    }
}
