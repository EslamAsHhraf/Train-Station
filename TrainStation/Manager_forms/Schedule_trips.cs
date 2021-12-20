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
        public Schedule_trips()
        {
            InitializeComponent();
        }

        private void Schedule_trips_Load(object sender, EventArgs e)
        {
            for(int i=0;i<60;i++)
            {
                SA.Items.Add(i.ToString());
                MA.Items.Add(i.ToString());
                SD.Items.Add(i.ToString());
                MD.Items.Add(i.ToString());
            } 
            for(int i=0;i<24;i++)
            {
                HA.Items.Add(i.ToString());
                HD.Items.Add(i.ToString());
            }
        }

       
    }
}
