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
    public partial class Hire_Emplotee : Form
    {
        public Hire_Emplotee()
        {
            InitializeComponent();
        }

        private void Hire_Emplotee_Load(object sender, EventArgs e)
        {
            for(int i=1;i<32;i++)
            {
                BD.Items.Add(i.ToString());
            }
            for (int i = 1; i < 13; i++)
            {
                BM.Items.Add(i.ToString());
            }
            for (int i = 2020; i >=1905; i--)
            {
                BY.Items.Add(i.ToString());
            }
        }
    }
}
