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
    public partial class CancelTicket : Form
    {
        Controller controllerObj;
        public CancelTicket()
        {
            InitializeComponent();
        }
        private void CancelTicket_load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable x = controllerObj.viewTicketNumbers();
            foreach (DataRow row in x.Rows)
                ticketSerialNoComboBox.Items.Add(row[0].ToString());
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (ticketSerialNoComboBox.Text == "")
            {
                MessageBox.Show("Please select a ticket!");
                return;

            }
            int ticketSerialNo = Int32.Parse(ticketSerialNoComboBox.Text);
            int m = controllerObj.cancelTicketEmployee(ticketSerialNo);

            if(m==1)
                MessageBox.Show("You succefully cancelled a ticket with Serial No. : "+ticketSerialNo);
            this.Close();

        }
    }
}
