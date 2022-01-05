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
        /*  Yasmine Ghanem*/



        /*Sarah Elzayat*/



        /*Yasmine Elgendi*/
        public DataTable GetAuthority(string email, string password)
        {
            string query = "SELECT Authority FROM User_Login WHERE Email = '" + email + "' AND Pass = '" + password + "';";
            return dbMan.ExecuteReader(query);
        }
        public int Create_Pass_Account(string email, string password, string username)
        {

            string query = "INSERT INTO User_Login VALUES ('" + email + "', '" + password + "', 'passenger', '" + username + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Insert_Pass(int ssn, string Fname, char Minit, string Lname, char Gender, string email, int CV_SerialNo, DateTime Vacc_Date)
        {
            string query = "INSERT INTO Passenger VALUES ( " + ssn + ", '" + Fname + "', '" + Minit + "', '" + Lname + "', '" + Gender + "', '" + email + "', " + CV_SerialNo + ", '" + Vacc_Date + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Select_NonAdmin_Emails()
        {
            string query = "SELECT Email FROM User_Login WHERE Authority = 'passenger' OR Authority = 'manager'  ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Select_Passenger_Emails()
        {
            string query = "SELECT Email FROM User_Login WHERE Authority = 'passenger';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Select_Admin_Emails()
        {
            string query = "SELECT Email FROM User_Login WHERE Authority = 'admin';";
            return dbMan.ExecuteReader(query);
        }
        public int Add_Admin(string email)
        {
            string query = "UPDATE User_Login SET Authority = 'admin' WHERE Email = '" + email + "'; ";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Add_BlackList(int PSSN, DateTime Date_Blacklisted, string reason)
        {
            string query = "INSERT INTO Blacklist VALUES(" + PSSN + ", '" + Date_Blacklisted.Date + "', '" + reason + "'); ";
            return dbMan.ExecuteNonQuery(query);
        }

        /* Eslam Ashraf*/
        public DataTable SSN_Employee()
        {
            string query = "SELECT SSN FROM Employee;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Dno_Department()
        {
            string query = "SELECT DepartmentNumber FROM Department order by DepartmentNumber ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Employee()
        {
            string query = "SELECT * FROM Employee;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Passenger()
        {
            string query = "SELECT * FROM Passenger;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ID_Station()
        {
            String StoredProcedureName = StoredProcedures.ID_Station;
            return dbMan.ExecuteReader(StoredProcedureName, null);
            //string query = "SELECT ID FROM Station;";
            //return dbMan.ExecuteReader(query);
        }
        public DataTable Trip_Code_Trip()
        {
            string query = "SELECT Trip_Code FROM Trip;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable PlateNumber_Train()
        {
            string query = "SELECT PlateNumber FROM Train;";
            return dbMan.ExecuteReader(query);
        }

        public int Change_Department(string ssn, string dno)
        {
            //string query = "UPDATE Employee SET Dno=" + dno + " WHERE SSN=" + ssn + ";";
            //return dbMan.ExecuteNonQuery(query);
            String StoredProcedureName = StoredProcedures.Change_Department;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ssn_e", ssn);
            Parameters.Add("@dep_e", dno);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int Change_Rate(string ssn, string rate)
        {
            string query = "UPDATE Employee SET Rate=" + rate + " WHERE SSN=" + ssn + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Change_Salary(string ssn, string salary)
        {
            //string query = "UPDATE Employee SET Salary=" + salary + " WHERE SSN=" + ssn + ";";
            //return dbMan.ExecuteNonQuery(query);
            String StoredProcedureName = StoredProcedures.Change_Salary;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ssn", ssn);
            Parameters.Add("@salary", salary);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int Insert_Trip(string Trip_Code, string Arrival_Time, string Departure_Time, string Train_PlateNumber, string Come_Station, string Go_Station)
        {
            //string query = "INSERT INTO Trip ( Trip_Code, Arrival_Time, Departure_Time,Train_PlateNumber,Come_Station,Go_Station)" +
            //                        "Values ('" + Trip_Code + "','" + Arrival_Time + "','" + Departure_Time + "'," + Train_PlateNumber + "," + Come_Station + "," + Go_Station + "); ";
            //return dbMan.ExecuteNonQuery(query);
            String StoredProcedureName = StoredProcedures.Insert_Trip;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TripCode", Trip_Code);
            Parameters.Add("@Arrival_Time", Arrival_Time);
            Parameters.Add("@Departure_Time", Departure_Time);
            Parameters.Add("@Train_PlateNumber", Train_PlateNumber);
            Parameters.Add("@Come_Station", Come_Station);
            Parameters.Add("@Go_Station", Go_Station);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int Set_Train_PlateNumber_Trip(string Trip_Code, string Train_PlateNumber)
        {
            string query = "UPDATE Trip SET Train_PlateNumber=" + Train_PlateNumber + " WHERE Trip_Code='" + Trip_Code + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Set_Come_Station_Trip(string Trip_Code, string Come_Station)
        {
            string query = "UPDATE Trip SET Come_Station=" + Come_Station + " WHERE Trip_Code='" + Trip_Code + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Set_Go_Station_Trip(string Trip_Code, string Go_Station)
        {
            string query = "UPDATE Trip SET Go_Station=" + Go_Station + " WHERE Trip_Code='" + Trip_Code + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Delete_Employee(string SSN)
        {
            string query = "DELETE FROM Employee WHERE SSN=" + SSN + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Super_Employee(string SSN)
        {
            string query = "UPDATE Employee set Super_SSN= NULL WHERE Super_SSN=" + SSN + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Insert_Employee(string SSN, string Fname, string Minit, string Lname, string Gender, string DOB,
            string Salary, string House_Num, string Street, string City,string Super_SSN, string Dno,string CV_SerialNo,string Vacc_Date, string Emp_Email)
        {
            string query = "INSERT INTO Employee ( SSN,  Fname, Minit, Lname, Gender,  DOB,"
           + "Salary, House_Num, Street, City, Super_SSN, Dno,CV_SerialNo,Vacc_Date,Emp_Email)"
            + "Values (" + SSN + ",'" + Fname + "','" + Minit + "','" + Lname + "','" + Gender + "','" + DOB + "'," + Salary + "," + House_Num + ",'"
            + Street + "','" + City + "'," + Super_SSN + "," + Dno+ "," + CV_SerialNo + ",'" + Vacc_Date + "','" + Emp_Email + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Set_Rate_Employee(string SSN, string Rate)
        {
            string query = "UPDATE Employee SET Rate=" + Rate + " WHERE SSN=" + SSN + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Insert_User_Login(string Email, string Pass, string Authority, string UserName)
        {
            string query = "INSERT INTO User_Login ( Email, Pass, Authority,UserName)" +
                            "Values ('" + Email + "','" + Pass + "','" + Authority + "','" + UserName + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Insert_CovidVaccination(string SerialNo, string Vacc_Type, string Organisation)
        {
            string query = "INSERT INTO CovidVaccination ( SerialNo, Vacc_Type, Organisation)" +
                            "Values (" + SerialNo + ",'" + Vacc_Type + "','" + Organisation + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public string Is_Trip(string Trip_Code)
        {
            string query = "SELECT Trip_Code FROM Trip where Trip_Code ='" + Trip_Code + "';";
            return (string)dbMan.ExecuteScalar(query);
        }
        public int Is_Employee(string SSN)
        {
            string query = "SELECT count(SSN) FROM Employee where SSN =" + SSN + ";";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int Is_User_Login(string Email)
        {
            string query = "SELECT count(Email) FROM User_Login where Email ='" + Email + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int Is_CovidVaccination(string SerialNo)
        {
            string query = "SELECT count(SerialNo) FROM CovidVaccination where SerialNo =" + SerialNo + ";";

            return (int)dbMan.ExecuteScalar(query);
        }
        public int Is_ticket(string TicketNo)
        {
            string query = "SELECT count(TicketNo) FROM Ticket where TicketNo =" + TicketNo + ";";

            return (int)dbMan.ExecuteScalar(query);
        }
        public int Insetr_ticket(string TicketNo, string Class,string Price, string Ticket_Date,string TripCode)
        {
            //string query = "INSERT INTO Ticket ( TicketNo, Class, Price,Ticket_Date,TripCode)" +
            //               "Values (" + TicketNo + ",'" + Class + "'," + Price + ",'" + Ticket_Date + "','" + TripCode + "');";
            //return dbMan.ExecuteNonQuery(query);
            String StoredProcedureName = StoredProcedures.Insert_ticket;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TicketNo", TicketNo);
            Parameters.Add("@Class", Class);
            Parameters.Add("@Price", Price);
            Parameters.Add("@Ticket_Date", Ticket_Date);
            Parameters.Add("@TripCode", TripCode);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
