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
    public partial class Schedule_trips : Form
    {
        Controller con;
        Handle hand;
        Random random;
        public Schedule_trips()
        {
            InitializeComponent();
            con = new Controller();
            hand = new Handle();
            random = new Random();
        }

        private void Schedule_trips_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                MA.Items.Add(i.ToString());
                MD.Items.Add(i.ToString());
            }
            for (int i = 8; i < 20; i++)
            {
                HA.Items.Add(i.ToString());
                HD.Items.Add(i.ToString());
            }
            DataTable dt = con.PlateNumber_Train();
            trainNum.DataSource = dt;
            trainNum.DisplayMember = "PlateNumber";
            DataTable dt2 = con.ID_Station();
            comestation.DataSource = dt2;
            comestation.DisplayMember = "ID";
            DataTable dt3 = con.ID_Station();
            Gostation.DataSource = dt3;
            Gostation.DisplayMember = "ID";
        }

        private void Insert_trip_Click(object sender, EventArgs e)
        {
            Trip_code = hand.Trim(Trip_code);
            if (Trip_code.Text.Length == 0)
            {
                MessageBox.Show("Please Insert Trip Code!");
                return;
            }
            bool semo = true;
            semo = hand.is_valid(Trip_code);
            if (!semo)
            {
                MessageBox.Show("you can't insert ;");
                return;
            }
            if (VIP.Text.Length == 0)
            {
                MessageBox.Show("Please Insert Price of VIP!");
                return;
            }
            if (GENERAL.Text.Length == 0)
            {
                MessageBox.Show("Please Insert Price of General!");
                return;
            }
            if (Num_VIP.Text.Length == 0)
            {
                MessageBox.Show("Please Insert Number of VIP Tickets!");
                return;
            }
            if (NUM_G.Text.Length == 0)
            {
                MessageBox.Show("Please Insert Number of General Tickets!");
                return;
            }
            if (HA.SelectedIndex == -1 || MA.SelectedIndex == -1)
            {
                MessageBox.Show("Please Insert Arrival Time!");
                return;
            }
            if (HD.SelectedIndex == -1 || MD.SelectedIndex == -1)
            {
                MessageBox.Show("Please Insert Departure Time!");
                return;
            }
            if (VIP.Text.Length >= 5 || GENERAL.Text.Length >= 5)
            {
                MessageBox.Show("Price of Vip and General should be less than 5 digits!");
                return;
            }
            if (Num_VIP.Text.Length >= 5 || NUM_G.Text.Length >= 5)
            {
                MessageBox.Show("Number of Vip and General tickets should be less than 5 digits!");
                return;
            }
            string arrivel = HA.Text + ':' + MA.Text;
            string departure = HD.Text + ':' + MD.Text;
            String r1 = con.Is_Trip(Trip_code.Text);
            if (r1 != null)
            {
                MessageBox.Show("This Trip is already exists!");
                return;
            }
            int h1, h2, m1, m2;
            Int32.TryParse(HA.Text, out h1);
            Int32.TryParse(HD.Text, out h2);
            Int32.TryParse(MA.Text, out m1);
            Int32.TryParse(MD.Text, out m2);
            bool check = false;
            if (h1 > h2)
            {
                check = true;
            }
            else if (h1 == h2)
            {
                if (m1 > m2)
                {
                    check = true;
                }
            }
            if (check)
            {
                MessageBox.Show("Departure Time should be longer than Arrival Time!");
                return;
            }
            int r2 = con.Insert_Trip(Trip_code.Text, arrivel, departure, trainNum.Text, comestation.Text, Gostation.Text);
            if (r2 == 0)
            {
                MessageBox.Show("Trip insert failed!");
            }
            else
            {
                MessageBox.Show("Trip inserted successfully");
                /*for vip*/
                int vnum, gnum;
                Int32.TryParse(Num_VIP.Text, out vnum);
                Int32.TryParse(NUM_G.Text, out gnum);
                int num_ticke = 0;
                for (int i = 0; i < vnum; i++)
                {
                    string temp;
                    int num;
                    while (true)
                    {
                        num = random.Next(10, 1000000);
                        temp = num.ToString();
                        int ti = con.Is_ticket(temp);
                        if (ti == 0)
                        {
                            num_ticke += con.Insetr_ticket(temp, "V", VIP.Text, Date_Of_trip.Text, Trip_code.Text);
                            break;
                        }
                    }
                }
                /* for General*/
                for (int i = 0; i < gnum; i++)
                {
                    string temp;
                    int num;
                    while (true)
                    {
                        num = random.Next(10, 1000000);
                        temp = num.ToString();
                        int ti = con.Is_ticket(temp);
                        if (ti == 0)
                        {
                            num_ticke += con.Insetr_ticket(temp, "G", GENERAL.Text, Date_Of_trip.Text, Trip_code.Text);
                            break;
                        }
                    }
                }
            }
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
