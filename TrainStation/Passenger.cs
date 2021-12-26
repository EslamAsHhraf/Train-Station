using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainStation.Passenger_forms;
namespace TrainStation
{
    public partial class Passenger : Form
    {
        public Passenger()
        {
            InitializeComponent();
        }

        private void Make_Complaint_Click(object sender, EventArgs e)
        {
            Make_Complaint f = new Make_Complaint();
            f.ShowDialog();
        }

        private void Edit_Profile_Click(object sender, EventArgs e)
        {
            Edit_Profile f = new Edit_Profile();
            f.ShowDialog();
        }

        private void Book_ticket_Click(object sender, EventArgs e)
        {
            Book_Ticket f = new Book_Ticket();
            f.ShowDialog();
        }

        private void Ticket_Details_Click(object sender, EventArgs e)
        {
            Ticket_Details f = new Ticket_Details();
            f.ShowDialog();
        }

        private void Upgrade_Ticket_Click(object sender, EventArgs e)
        {
            Upgrade_Ticket f = new Upgrade_Ticket();
            f.ShowDialog();
        }

        private void Cancel_Ticket_Click(object sender, EventArgs e)
        {
            Cancel_Ticket f = new Cancel_Ticket();
            f.ShowDialog();
        }

        private void Sign_out_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
