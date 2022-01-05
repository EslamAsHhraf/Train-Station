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
    public partial class TrainStatus : Form
    {
        Controller controllerObj;
        public TrainStatus()
        {
            InitializeComponent();
        }
        private void TrainStatus_load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable x = controllerObj.viewTrainNumbers();
            foreach (DataRow row in x.Rows)
                trainPlateNumberComboBox.Items.Add(row[0].ToString());
        }
        private void ShowMaintenanceStatusButton_Click(object sender, EventArgs e)
        {
            if (trainPlateNumberComboBox.Text == "")
            {
                MessageBox.Show("Please select a train!");
                return;


            }
            int PlateNumber = Int32.Parse(trainPlateNumberComboBox.Text);
            bool m = controllerObj.checkTrainEmployee(PlateNumber);
            if (m == true)
                MessageBox.Show("The train is in maintenance.");
            else
                MessageBox.Show("The train is not in maintenance.");

        }
    }
}
