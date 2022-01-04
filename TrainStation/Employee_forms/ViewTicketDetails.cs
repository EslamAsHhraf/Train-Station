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
    public partial class ViewTicketDetails : Form
    {
        Controller controllerObj;

        public ViewTicketDetails()
        {
            InitializeComponent();

        }
        private void ViewTicketDetails_load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable x = controllerObj.viewTicketNumbers();
            foreach (DataRow row in x.Rows)
                ticketSerialNoComboBox.Items.Add(row[0].ToString());
        }


        private void viewTicketDetailsBtn_Click(object sender, EventArgs e)

        {
            if(ticketSerialNoComboBox.Text=="")
            {
                MessageBox.Show("Please select a ticket!");
                return;

            }
            int ticketSerialNo = Int32.Parse(ticketSerialNoComboBox.Text);
            DataTable dt = controllerObj.ticketDetailEmployee(ticketSerialNo);
            dataGridView1.DataSource = dt;

            dataGridView1.Refresh();


        }
    }
}
