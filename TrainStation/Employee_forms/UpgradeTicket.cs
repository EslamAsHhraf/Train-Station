﻿using System;
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
    public partial class UpgradeTicket : Form
    {
        public UpgradeTicket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You succefully upgraded a ticket with Serial No. : "+ticketSerialNoComboBox.Text+" \n " +
                "To class : "+newClassComboBox.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void newClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ticketSerialNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
