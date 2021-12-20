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

    public int Insertemployee(string Fname, string Minit, string Lname, string SSN, string Dno)
    {
        string query = "INSERT INTO Employee (Fname, Minit, Lname, SSN, Dno) " +
                        "Values ('" + Fname + "','" + Minit + "','" + Lname + "'," + SSN + "," + Dno + ");";
        return dbMan.ExecuteNonQuery(query);
    }

    public void TerminateConnection()
    {
        dbMan.CloseConnection();
    }
    
    }
}
