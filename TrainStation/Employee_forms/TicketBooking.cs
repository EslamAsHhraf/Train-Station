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
        public Ticket_booking()
        {
            InitializeComponent();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You succefully booked a ticket with Serial No. : ");
        }
    }
}
