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
    public partial class ViewSeats : Form
    {
        Controller controllerObj;
        public ViewSeats()
        {
            InitializeComponent();
        }
        private void ViewSeats_load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable x = controllerObj.viewTripNumbers();
            foreach (DataRow row in x.Rows)
                comboBox1.Items.Add(row[0].ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select a trip!");
                return;

            }
            char[] arr = { 'V','G' };
            int[] num = {0,0};
            for (int i = 0; i < arr.Length; i++)
                num[i] = controllerObj.getSeatsNumWithClass(arr[i], comboBox1.Text);
            for (int i = 0; i < arr.Length; i++)
                num[i] -= controllerObj.getNumOfBookedTickets(arr[i], comboBox1.Text);
            MessageBox.Show("Number of availabe VIP class seats: "+num[0]+ "\n Number of availabe General class seats: "+num[1]);


        }
    }
}
