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
            char[] arr = { 'A', 'B', 'C', 'D', 'E' };
            for (int i = 0; i < arr.Length; i++)
                 newClassComboBox.Items.Add(arr[i]); 
          
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
            if(tClass==newClassComboBox.Text)
            {
                MessageBox.Show("The ticket's class is already " + tClass + "!");
                return;
            }

            int x = controllerObj.updateTicketEmployee(newClassComboBox.Text[0], Int32.Parse(ticketSerialNoComboBox.Text));
            if(x==1)
            MessageBox.Show("You succefully upgraded a ticket with Serial No. : "+ticketSerialNoComboBox.Text+" \n " +
                "To class : "+newClassComboBox.Text);
        }

        
    }
}
