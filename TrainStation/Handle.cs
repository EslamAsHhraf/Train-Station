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
        public TextBox Trim(TextBox str)  // Trim Space
        {
            str.Text= str.Text.TrimStart();
            str.Text=str.Text.TrimEnd();
            return str;
        }
        public bool is_valid(TextBox str)  // Can't inset ';'
        {
            for(int i=0;i<str.TextLength;i++)
            {
                if (str.Text[i] == ';')
                    return false;
            }
            return true;
        }
        public bool is_email(TextBox str)  // email should include @
        {
            for (int i = 0; i < str.TextLength; i++)
            {
                if (str.Text[i] == '@')
                    return true;
            }
            return false;
        }
    }
}
