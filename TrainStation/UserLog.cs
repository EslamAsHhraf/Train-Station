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
    public partial class UserLog : Form
    {
        Handle hand;
        public UserLog()
        {
            InitializeComponent();
            hand = new Handle();
        }

        private void Create_acc_Click(object sender, EventArgs e)
        {
            Create_acc account = new Create_acc();
            account.ShowDialog();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
