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
    public partial class Ticket_Details : Form
    {
        Controller controllerObj;
        int Passenger_SSN;
        public Ticket_Details(int pssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Passenger_SSN = pssn;
        }

        private void Ticket_Details_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.View_Ticket_Details(Passenger_SSN);
            TicketDetailsGridView.DataSource = dt;
            TicketDetailsGridView.Refresh();
        }
    }
}
