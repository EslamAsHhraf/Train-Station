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
    public partial class ViewTrips : Form
    {
        Controller controllerObj;
        public ViewTrips()
        {
            InitializeComponent();
        }
        private void ViewTrips_load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.viewTrips();
            dataGridView1.DataSource = dt;

            dataGridView1.Refresh();
        }
    }
}
