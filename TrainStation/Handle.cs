using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TrainStation
{
    class Handle
    {
        public bool IS_Open(string name)  // if form is open or not
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == name)
                {
                    return true;
                }
            }
            return false;
        }
        public void Close()  // close all window and open log in
        {
             Environment.Exit(0);
        }
        //UserLog
        public void log_out()  // close all window and open log in
        {
            Application.Restart();
            //for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            //{
            //    if (Application.OpenForms[i].Name != "UserLog")
            //        Application.OpenForms[i].Close();
            //}

            // change text box to empty
        }
        public TextBox Trim(TextBox str)  // Trim Space
        {
            str.Text= str.Text.TrimStart();
            str.Text=str.Text.TrimEnd();
            return str;
        }
        public bool is_valid(TextBox str)  // Trim Space
        {
            for(int i=0;i<str.TextLength;i++)
            {
                if (str.Text[i] == ';')
                    return false;
            }
            return true;
        }
    }
}
