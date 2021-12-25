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
