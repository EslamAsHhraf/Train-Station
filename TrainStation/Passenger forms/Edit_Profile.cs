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
    public partial class Edit_Profile : Form
    {
        public Edit_Profile()
        {
            InitializeComponent();
        }

        private void Change_Phone_Number_Click(object sender, EventArgs e)
        {
            Change_PhoneNumber f = new Change_PhoneNumber();
            f.ShowDialog();
        }

        private void Add_Phone_Number_Click(object sender, EventArgs e)
        {
            Add_PhoneNumber f = new Add_PhoneNumber();
            f.ShowDialog();
        }

        private void Change_Email_Click(object sender, EventArgs e)
        {
            Change_Email f = new Change_Email();
            f.ShowDialog();
        }

        private void Change_Password_Click(object sender, EventArgs e)
        {
            Change_Password f = new Change_Password();
            f.ShowDialog();
        }
    }
}
