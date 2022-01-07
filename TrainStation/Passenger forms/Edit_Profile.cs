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
        int Passenger_SSN;
        string Email;
        public Edit_Profile(int pssn, string email)
        {
            InitializeComponent();
            Passenger_SSN = pssn;
            Email = email;
        }

        private void Change_Phone_Number_Click(object sender, EventArgs e)
        {
            Change_PhoneNumber f = new Change_PhoneNumber(Passenger_SSN);
            f.ShowDialog();
        }

        private void Add_Phone_Number_Click(object sender, EventArgs e)
        {
            Add_PhoneNumber f = new Add_PhoneNumber(Passenger_SSN);
            f.ShowDialog();
        }

        private void Change_Email_Click(object sender, EventArgs e)
        {
            Change_Email f = new Change_Email(Email);
            f.ShowDialog();
        }

        private void Change_Password_Click(object sender, EventArgs e)
        {
            Change_Password f = new Change_Password(Email);
            f.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
