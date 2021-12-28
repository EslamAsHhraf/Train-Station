using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainStation.Manager_s_forms
{
    public partial class Employees__data : Form
    {
        Controller con;
        public Employees__data()
        {
            InitializeComponent();
            con = new Controller();
        }

        private void Employees__data_Load(object sender, EventArgs e)
        {
            DataTable dt = con.Employee();
            data.DataSource = dt;
            data.Refresh();
        }
    }
}
