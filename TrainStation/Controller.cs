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

        //Make Complaints
        public int Submit_Complaint(int code, string Description, int pssn)
        {
            string query = "INSERT INTO Complaints (C_Code, Descrip, P_SSN) " +
                                    "VALUES ('" + code + "','" + Description + "'," + pssn + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Generate_Code(string Code)
        {
            string query = "SELECT count(C_Code) FROM Complaints where C_Code = " + Code + ";";

            return (int)dbMan.ExecuteScalar(query);
        }

        //Gets ssn of current signed in passenger
        public int Get_SSN_Of_Email(string email)
        {
            string query = "SELECT Pass_SSN FROM Passenger WHERE Pass_Email = '" + email + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        //Book ticket functions
        //view available trips to book ticket
        public DataTable View_Available_Trips()
        {
            string query = "SELECT Trip_Code, Departure_Time, Arrival_Time, Come_Station, Go_Station FROM Trip;";
            return dbMan.ExecuteReader(query);
        }

        //Get available ticket
        public int Get_Next_Available_Ticket(int tripcode, char ticketclass)
        {
            string query = "SELECT TicketNo FROM Ticket WHERE ESSN IS NULL AND PSSN IS NULL AND TripCode = " + tripcode + " AND Class = '" + ticketclass + "';";
            return (int)dbMan.ExecuteNonQuery(query);
        }

        //Book ticket
        public int Book_Ticket_Passenger(int pssn, int ticketno)
        {
            string query = "UPDATE Ticket SET PSSN = " + pssn + " WHERE TicketNo = " + ticketno + ";";
            return dbMan.ExecuteNonQuery(query);
        }


        //View all ticket details of current passenger
        public DataTable View_Ticket_Details(int ssn)
        {
            string query = "SELECT * FROM Ticket WHERE PSSN = " + ssn + ";";
            return dbMan.ExecuteReader(query);
        }

        //Edit Profile

        //Change Phone Number
        public int Change_Phone_Number(string new_pnum, string old_pnum, int pssn)
        {
            string query = "UPDATE Pass_PhoneNumber SET P_PhoneNumber = '" + new_pnum + "' WHERE P_PhoneNumber = '" + old_pnum + "' AND PSSN = " + pssn + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        //Add phone number for current passenger
        public int Add_Phone_Number(int ssn, string pnum)
        {
            string query = "INSERT INTO Pass_PhoneNumber " +
                                    "VALUES (" + ssn + ",'" + pnum + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Check_If_PhoneNo_Exist(string pnum, int pssn)
        {
            string query = "SELECT COUNT(PSSN) FROM Pass_PhoneNumber WHERE PSSN = " + pssn + " AND P_PhoneNumber = '" + pnum + "';";

            return (int)dbMan.ExecuteScalar(query);
        }


        //change email
        public int Change_Email_Passenger(string new_email, string old_email)
        {
            string query = "UPDATE User_Login SET Email = '" + new_email + "' WHERE Email = '" + old_email + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        //Change password
        public int Change_Password_Passenger(string email, string password)
        {
            string query = "UPDATE User_Login SET Pass = '" + password + "' WHERE Email = '" + email + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public string Check_Old_Password(string email)
        {
            string query = "SELECT Pass FROM User_Login WHERE Email = '" + email + "';";
            return (string)dbMan.ExecuteScalar(query);
        }

        //Upgrade ticket
        public int Upgrade_Ticket(int ticketno)
        {
            string query = "UPDATE Ticket SET Class = 'V' WHERE TicketNo = " + ticketno + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public string Get_Ticket_Class(int ticketno)
        {
            string query = "SELECT Class FROM Ticket WHERE TicketNo = " + ticketno + ";";
            return (string)dbMan.ExecuteScalar(query);
        }

        //Cancel ticket
        public int Cancel_Ticket(int ticketno)
        {
            string query = "UPDATE Ticket SET PSSN = NULL, ESSN = NULL WHERE TicketNo = " + ticketno + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        //ComboBox queries
        public DataTable Retrieve_Tickets_For_Passenger(int pssn)
        {
            string query = "SELECT TicketNo FROM Ticket WHERE PSSN = " + pssn + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Retrieve_Available_Trips()
        {
            string query = "SELECT Trip_Code FROM Trip;";
            return dbMan.ExecuteReader(query);
        }



        /*Sarah Elzayat*/

        public DataTable ticketDetailEmployee(int ticketNo)
        {
            string query = $"select * from ticket where ticketno ={ticketNo}";
            return dbMan.ExecuteReader(query);
        }

        public DataTable viewTicketNumbers()
        {
            string query = "SELECT ticketno  FROM ticket";
            return dbMan.ExecuteReader(query);
        }

        public int updateTicketEmployee(char newclass, int ticketNo)
        {
            string query = $"update ticket set class = '{newclass}' where ticketno ={ticketNo}";
            return dbMan.ExecuteNonQuery(query);
        }
        public string getTicketClass(int ticketNo)
        {
            string query = $"SELECT class  FROM ticket where ticketno ={ticketNo}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int cancelTicketEmployee(int ticketNo)
        {
            string query = $"delete from ticket where ticketno ={ticketNo}";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable viewTrainNumbers()
        {
            string query = "SELECT PlateNumber  FROM train";
            return dbMan.ExecuteReader(query);
        }
        public bool checkTrainEmployee(int trainNo)
        {
            string query = $"select Maintenance from train where PlateNumber ={trainNo}";
            return (bool)dbMan.ExecuteScalar(query);
        }
        public DataTable viewTripNumbers()
        {
            string query = "SELECT Trip_Code  FROM trip";
            return dbMan.ExecuteReader(query);
        }

        public int getSeatsNumWithClass(char cls, int tripNo)
        {
            string query = $"SELECT count(*)  FROM ticket,trip where Trip_Code ={tripNo} and class='{cls}'";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int getNumOfBookedTickets(char cls, int tripNo)
        {
            string query = $"SELECT count(*)  FROM ticket,trip where Trip_Code ='{tripNo}' and class='{cls}' and pssn is not null";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable viewTrips()
        {
            string query = "SELECT *  FROM trip";
            return dbMan.ExecuteReader(query);
        }
        public DataTable viewPassengerSSNEmployee()
        {
            string query = $"SELECT Pass_SSN FROM passenger ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable viewPassengerDataEmployee(int ssn)
        {
            string query = $"SELECT * FROM passenger where Pass_SSN = { ssn}";
            return dbMan.ExecuteReader(query);
        }

        public int updatePassengerPhoneEmployee(Int32 newPhone, int ssn)
        {
            string query = $"insert into pass_phonenumber (pssn,p_phoneNumber) values ({ssn},'{newPhone}' )";
            return dbMan.ExecuteNonQuery(query);
        }
        public string getPassEmailEmployee(int ssn)
        {
            string query = $"select pass_email from passenger where pass_ssn={ssn}";
            return (string)dbMan.ExecuteScalar(query);
        }
        public int updatePassengerEMailEmployee(string email, int ssn, string oldemail)
        {
            string query = $@"update user_login set email = '{email}' where email = '{oldemail}';
                                update passenger set pass_email = '{email}' where pass_ssn = {ssn};
                            ";
            return dbMan.ExecuteNonQuery(query);

        }
        public int updatePassengerPassowrdEmployee(string pass, string email)
        {
            string query = $@"update user_login set pass = '{pass}' where email = '{email}'";
            return dbMan.ExecuteNonQuery(query);

        }
        public DataTable getPassPhoneNumberEmpoloyee(int ssn)
        {
            string query = $"SELECT P_PhoneNumber FROM Pass_PhoneNumber where PSSN = { ssn}";
            return dbMan.ExecuteReader(query);
        }
        public string getEmpEmailEmployee(int ssn)
        {
            string query = $"select emp_email from employee where ssn={ssn}";
            return (string)dbMan.ExecuteScalar(query);
        }
        public int updateEmployeePhoneEmployee(Int32 newPhone, int ssn)
        {
            string query = $"insert into E_PhoneNumber (essn,e_phoneNumber) values ({ssn},'{newPhone}' )";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updateEmpEmailEmployee(string email, int ssn, string oldemail)
        {
            string query = $@"update user_login set email = '{email}' where email = '{oldemail}';
                                update emplpyee set emp_email = '{email}' where ssn = {ssn};
                            ";
            return dbMan.ExecuteNonQuery(query);

        }
        public int updateEmpPassowrdEmployee(string pass, string email)
        {
            string query = $@"update user_login set pass = '{pass}' where email = '{email}'";
            return dbMan.ExecuteNonQuery(query);

        }
        public DataTable viewTripIdEmployee()
        {
            string query = $"SELECT Trip_Code FROM trip ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getFirstAvailableTicketID(int tripC, char cls)
        {
            string query = $@"SELECT TicketNo FROM ticket,trip where Trip_Code ='{tripC}' and class='{cls}' and pssn is null and essn is null";
            return dbMan.ExecuteReader(query);

        }

        public int BookTicketEmployee(int essn, int pssn, int ticketNo)
        {
            string query = $@"update ticket set essn = {essn},pssn={pssn} where ticketNO = {ticketNo}";
            return dbMan.ExecuteNonQuery(query);

        }
        public int Get_SSN_Of_EmailEmployee(string email)
        {
            string query = $"SELECT ssn FROM employee WHERE emp_Email = '{email}';";
            return (int)dbMan.ExecuteScalar(query);
        }

        /*Yasmine Elgendi*/
        public DataTable GetAuthority(string email, string password)
        {
            string query = "SELECT Authority FROM User_Login WHERE Email = '" + email + "' AND Pass = '" + password + "';";
            return dbMan.ExecuteReader(query);
        }
        public int Create_Vacc(int serialno, string Vacc_Type, string Organisation)
        {

            string query = "INSERT INTO CovidVaccination VALUES ( " + serialno + ", '" + Vacc_Type + "', '" + Organisation + "')";
            return dbMan.ExecuteNonQuery(query);
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
        
        public DataTable Select_Passenger_SSN()
        {
            string query = "SELECT Pass_SSN FROM Passenger WHERE Pass_SSN NOT IN (SELECT PSSN FROM Blacklist); ";
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

        public int Remove_Admin_Employee(string email)
        {
            string query = "UPDATE Employee SET Super_SSN = null WHERE Super_SSN = (SELECT SSN FROM Employee WHERE Emp_Email = '" + email +"');";
            dbMan.ExecuteNonQuery(query);

            string query2 = "DELETE FROM Employee WHERE SSN = (SELECT SSN FROM Employee WHERE Emp_Email = '" + email + "'); ";
            return dbMan.ExecuteNonQuery(query2);
        }


        public int Remove_Admin(string email)
        {
            if(Remove_Admin_Employee(email) == 1)
            {
                string query = "DELETE FROM User_Login WHERE Email = '" + email + "'; ";
                return dbMan.ExecuteNonQuery(query);
            }
            else
            {
                return 0;
            }
            
        }
        
        public DataTable Select_CovidVacs_Serial()
        {
            string query = "SELECT SerialNo FROM CovidVaccination;";
            return dbMan.ExecuteReader(query);
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
            String StoredProcedureName = StoredProcedures.Employee_data;
            return dbMan.ExecuteReader(StoredProcedureName, null);
            //string query = "SELECT * FROM Employee;";
            //return dbMan.ExecuteReader(query);
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
            //string query = "UPDATE Employee SET Rate=" + rate + " WHERE SSN=" + ssn + ";";
            //return dbMan.ExecuteNonQuery(query);
            String StoredProcedureName = StoredProcedures.Change_Rate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ssn", ssn);
            Parameters.Add("@rate", rate);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
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
            string Salary, string House_Num, string Street, string City, string Super_SSN, string Dno, string CV_SerialNo, string Vacc_Date, string Emp_Email)
        {
            string query = "INSERT INTO Employee ( SSN,  Fname, Minit, Lname, Gender,  DOB,"
           + "Salary, House_Num, Street, City, Super_SSN, Dno,CV_SerialNo,Vacc_Date,Emp_Email)"
            + "Values (" + SSN + ",'" + Fname + "','" + Minit + "','" + Lname + "','" + Gender + "','" + DOB + "'," + Salary + "," + House_Num + ",'"
            + Street + "','" + City + "'," + Super_SSN + "," + Dno + "," + CV_SerialNo + ",'" + Vacc_Date + "','" + Emp_Email + "');";
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
        public int Insetr_ticket(string TicketNo, string Class, string Price, string Ticket_Date, string TripCode)
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