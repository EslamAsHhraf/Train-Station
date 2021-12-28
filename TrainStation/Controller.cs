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
            string query = "SELECT ID FROM Station;";
            return dbMan.ExecuteReader(query);
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
            string query = "UPDATE Employee SET Dno=" + dno + " WHERE SSN=" + ssn + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Change_Rate(string ssn, string rate)
        {
            string query = "UPDATE Employee SET Rate=" + rate + " WHERE SSN=" + ssn + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Change_Salary(string ssn, string salary)
        {
            string query = "UPDATE Employee SET Salary=" + salary + " WHERE SSN=" + ssn + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Insert_Trip(string Trip_Code, string Arrival_Time, string Departure_Time, string Train_PlateNumber, string Come_Station, string Go_Station)
        {
            string query = "INSERT INTO Trip ( Trip_Code, Arrival_Time, Departure_Time,Train_PlateNumber,Come_Station,Go_Station)" +
                                    "Values ('" + Trip_Code + "','" + Arrival_Time + "','" + Departure_Time + "'," + Train_PlateNumber + "," + Come_Station + "," + Go_Station + "); ";
            return dbMan.ExecuteNonQuery(query);
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
            string Salary, string House_Num, string Street, string City, string Dno, string Emp_Email)
        {
            string query = "INSERT INTO Employee ( SSN,  Fname, Minit, Lname, Gender,  DOB,"
           + "Salary, House_Num, Street, City,  Dno,Emp_Email)"
            + "Values (" + SSN + ",'" + Fname + "','" + Minit + "','" + Lname + "','" + Gender + "','" + DOB + "'," + Salary + "," + House_Num + "','"
            + Street + "','" + City + "'," + Dno + ",'" + Emp_Email + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Set_Rate_Employee(string SSN, string Rate)
        {
            string query = "UPDATE Employee SET SSN=" + SSN + " WHERE Rate=" + Rate + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Set_Super_SSN_Employee(string SSN, string Super_SSN)
        {
            string query = "UPDATE Employee SET SSN=" + SSN + " WHERE Super_SSN=" + Super_SSN + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Set_CV_SerialNo_Employee(string SSN, string CV_SerialNo)
        {
            string query = "UPDATE Employee SET SSN=" + SSN + " WHERE CV_SerialNo=" + CV_SerialNo + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Set_Vacc_Date_Employee(string SSN, string Vacc_Date)
        {
            string query = "UPDATE Employee SET SSN=" + SSN + " WHERE Vacc_Date=" + Vacc_Date + ";";
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
            string query = "SELECT SSN FROM Employee where SSN =" + SSN + ";";
            return (int)dbMan.ExecuteScalar(query);
        }
        public string Is_User_Login(string Email)
        {
            string query = "SELECT Email FROM User_Login where Email ='" + Email + "';";
            return (string)dbMan.ExecuteScalar(query);
        }
        public int Is_CovidVaccination(string SerialNo)
        {
            string query = "SELECT SerialNo FROM CovidVaccination where SerialNo =" + SerialNo + ";";
            return (int)dbMan.ExecuteScalar(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
