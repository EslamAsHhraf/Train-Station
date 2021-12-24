using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TrainStation
{
    class Controller
    {
        DBManager dbMan;

    public Controller()
    {
        dbMan = new DBManager();
    }

    public void TerminateConnection()
    {
        dbMan.CloseConnection();
    }
    
    }
}
