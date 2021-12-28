using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainStation.Manager_forms
{
    public partial class Passengers_data : Form
    {
        Controller con;
        public Passengers_data()
        {
            InitializeComponent();
            con = new Controller();
        }

        private void Passengers_data_Load(object sender, EventArgs e)
        {
            DataTable dt = con.Passenger();
            data.DataSource = dt;
            data.Refresh();
            
        }
    }
}
