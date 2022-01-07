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
    public partial class Make_Complaint : Form
    {
        Controller controllerObj;
        Handle handleObj;
        Random Code;
        int Passenger_SSN;
        public Make_Complaint(int ssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            handleObj = new Handle();
            Code = new Random();
            Passenger_SSN = ssn;
        }

        private void Make_Complaint_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Complaint_Click(object sender, EventArgs e)
        {
            int num;
            string temp;
            Complaint_Description = handleObj.Trim(Complaint_Description);
            if (Complaint_Description.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Description!");
                return;
            }
            bool semo = true;
            semo = handleObj.is_valid(Complaint_Description);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return;
            }
            int r;
            while (true)
            {
                num = Code.Next(1, 1000000);
                temp = num.ToString();
                int count = controllerObj.Generate_Code(temp);
                if (count == 0)
                {
                    r = controllerObj.Submit_Complaint(num, Complaint_Description.Text, Passenger_SSN);
                    break;
                }
            }
            if (r == 0)
            {
                MessageBox.Show("Complaint submission failed!");
            }
            else
            {
                MessageBox.Show("Complaint submitted successfully");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
