# Train Station <img width=100px height=100px src="images/emoji/locomotive-joypixels.gif">

<p align="center">
  
   <img width=100% src="images/cover.png" alt="logo">
</p>
<p align="center"> 
    <br> 
</p>

## <img align= center width=50px height=50px src="images/emoji/to-do-list-checklist.gif"> Table of Contents

- <a href ="#about"> 📙 overview</a>
- <a href ="#Started"> 💻 Get Started</a>
- <a href ="#Built"> 🔨 Built Using</a>
- <a href ="#Screenshots"> 📷 Demo Screenshots</a>
- <a href ="#Structure"> 🧱 File Structure</a>
- <a href ="#Contributors"> ✨ Contributors</a>
<hr style="background-color: #4b4c60"></hr>

## <img align="center"  height =50px src="images/emoji/minions-cute.gif"> overview <a id = "about"></a>

<ul> 
<li > A windows application for a train station DBMS. A train station DBMS
that imitates a real transportation system. It is made to overcome
manual errors of booking and make it into a computerized system.
The train station manager can easily manage the station through the
system, manage employees and schedule trips.</li>
<li> It has all the schedules of the trains available. From which passengers,
who wish to travel, can go to the booking employee to book a ticket or
book it through the application. </li>
<li>
Passengers can also view, cancel or upgrade their ticket, address
complaints...etc.
</li>

<li>
The database system helps to maintain all the records of different
train trips, available seats and passengers in an easy way.
</li>
</ul>
<hr style="background-color: #4b4c60"></hr>

## <img align= center width=70px height=70px src="images/emoji/monitors-computer.gif"> Get Started <a id = "Started"></a>

<ol>
<li>Clone the repository

```
git clone https://github.com/EslamAsHhraf/Train-Station
```

</li>
<li> you will need to download <a href="https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017"> SQL Server Management Studio (SSMS)</a> </li>
<li>Excute <a href='https://github.com/EslamAsHhraf/Train-Station/blob/master/CreateDatabaseQuery.sql'> CreateDatabaseQuery </a> to create Data Base </li>
<li> Excute <a href='https://github.com/EslamAsHhraf/Train-Station/blob/master/InsertValues.sql'>InsertValues </a> to fill Data Base</li>
<li> Do steps<a href='https://github.com/EslamAsHhraf/Train-Station/blob/master/Accessing%20DB%20from%20C%23%20App.pdf'>Accessing DB from C# App</a> to link Data Base with application</li>
<li> Excute all files in <a href="https://github.com/EslamAsHhraf/Train-Station/tree/master/Stored%20Procedures">Stored Procedures</a></li>
<li> Read <a href='https://github.com/EslamAsHhraf/Train-Station/blob/master/Report%20.pdf'>Report</a>  to undertand well how to use application
</li>
</ol>
<hr style="background-color: #4b4c60"></hr>

## <img align= center width=50px height=50px src="images/emoji/building-construction-travel.gif"> Built Using <a id ="Built"></a>

<ul>
  <li>Windows form application</li>
  <li>my sql</li>
</ul>
<hr style="background-color: #4b4c60"></hr>

## <img align= center width=70px height=70px src="images/emoji/cute-penguin.gif"> Demo Screenshots <a id ="Screenshots"></a>

![image](https://user-images.githubusercontent.com/71986226/152590582-56b12986-57b6-4685-881c-2471ddf917c8.png)

<hr></hr>

![image](https://user-images.githubusercontent.com/71986226/152595291-9620172c-1269-4065-91ca-d3bd3b8a7897.png)

<hr></hr>

![image](https://user-images.githubusercontent.com/71986226/152595391-daee792e-79ee-430d-8aa1-65871834db30.png)

<hr></hr>

![image](https://user-images.githubusercontent.com/71986226/152595482-f931c3b8-9340-4e58-a8b0-729cb113e327.png)

<hr></hr>

![image](https://user-images.githubusercontent.com/71986226/152595633-d7d64ccd-162a-4987-af51-b5c0acae61f0.png)

<hr></hr>

![image](https://user-images.githubusercontent.com/71986226/152596490-2e174c9f-748a-416e-ab99-e203293bebdc.png)

<hr></hr>

![image](https://user-images.githubusercontent.com/71986226/152596595-201cc206-27b7-4a6d-b23f-ae45b16b8a35.png)

<hr></hr>

![image](https://user-images.githubusercontent.com/71986226/152596751-06bc6240-6446-4cac-b9c5-96e432d714e5.png)

<hr></hr>

![image](https://user-images.githubusercontent.com/71986226/152596803-9a0b0a7e-69e7-4b7f-bbee-4ef64d7578da.png)

<hr style="background-color: #4b4c60"></hr>

## <img align= center width=50px height=50px src="images/emoji/folder-walk.gif"> File Structure <a id="Structure"> </a>

```
Train-Station
├── Stored Procedures
│   ├── Change_Department.sql
│   ├── Change_Rate.sql
│   ├── Change_Salary.sql
│   ├── Dno_Department.sql
│   ├── Employee_data.sql
│   ├── ID_Station.sql
│   ├── Insert_Trip.sql
│   ├── SSN_Employee.sql
│   ├── SSN_Passenger.sql
│   ├── get_tele_E.sql
│   └── get_tele_psql.sql
├── images
│   ├── cover.jpg
│   └── cover.png
├── TrainStation
│   ├── Admin_forms
│   │   ├── Add_admin.Designer.cs
│   │   ├── Add_admin.cs
│   │   ├── Add_admin.resx
│   │   ├── Block_.Designer.cs
│   │   ├── Block_.cs
│   │   ├── Block_.resx
│   │   ├── Remove_admin.Designer.cs
│   │   ├── Remove_admin.cs
│   │   └── Remove_admin.resx
│   ├── Employee_forms
│   │   ├── CancelTicket.Designer.cs
│   │   ├── CancelTicket.cs
│   │   ├── CancelTicket.resx
│   │   ├── TicketBooking.Designer.cs
│   │   ├── TicketBooking.cs
│   │   ├── TicketBooking.resx
│   │   ├── TrainStatus.Designer.cs
│   │   ├── TrainStatus.cs
│   │   ├── TrainStatus.resx
│   │   ├── UpdateMyData.Designer.cs
│   │   ├── UpdateMyData.cs
│   │   ├── UpdateMyData.resx
│   │   ├── UpgradeTicket.Designer.cs
│   │   ├── UpgradeTicket.cs
│   │   ├── UpgradeTicket.resx
│   │   ├── ViewPassengerData.Designer.cs
│   │   ├── ViewPassengerData.cs
│   │   ├── ViewPassengerData.resx
│   │   ├── ViewSeats.Designer.cs
│   │   ├── ViewSeats.cs
│   │   ├── ViewSeats.resx
│   │   ├── ViewTicketDetails.Designer.cs
│   │   ├── ViewTicketDetails.cs
│   │   ├── ViewTicketDetails.resx
│   │   ├── ViewTrips.Designer.cs
│   │   ├── ViewTrips.cs
│   │   ├── ViewTrips.resx
│   │   ├── updatePassengerData.Designer.cs
│   │   ├── updatePassengerData.cs
│   │   └── updatePassengerData.resx
│   ├── Manager_forms
│   │   ├── Change_Deb.Designer.cs
│   │   ├── Change_Deb.cs
│   │   ├── Change_Deb.resx
│   │   ├── Change_Salary.Designer.cs
│   │   ├── Change_Salary.cs
│   │   ├── Change_Salary.resx
│   │   ├── Change_rate.Designer.cs
│   │   ├── Change_rate.cs
│   │   ├── Change_rate.resx
│   │   ├── Employees_data.Designer.cs
│   │   ├── Employees_data.cs
│   │   ├── Employees_data.resx
│   │   ├── Fire_employee.Designer.cs
│   │   ├── Fire_employee.cs
│   │   ├── Fire_employee.resx
│   │   ├── Hire_Employee.Designer.cs
│   │   ├── Hire_Employee.cs
│   │   ├── Hire_Employee.resx
│   │   ├── Passengers_data.Designer.cs
│   │   ├── Passengers_data.cs
│   │   ├── Passengers_data.resx
│   │   ├── Schedule_trips.Designer.cs
│   │   ├── Schedule_trips.cs
│   │   └── Schedule_trips.resx
│   ├── Passenger forms
│   │   ├── Add_PhoneNumber.Designer.cs
│   │   ├── Add_PhoneNumber.cs
│   │   ├── Add_PhoneNumber.resx
│   │   ├── Book_Ticket.Designer.cs
│   │   ├── Book_Ticket.cs
│   │   ├── Book_Ticket.resx
│   │   ├── Cancel_Ticket.Designer.cs
│   │   ├── Cancel_Ticket.cs
│   │   ├── Cancel_Ticket.resx
│   │   ├── Change_Email.Designer.cs
│   │   ├── Change_Email.cs
│   │   ├── Change_Email.resx
│   │   ├── Change_Password.Designer.cs
│   │   ├── Change_Password.cs
│   │   ├── Change_Password.resx
│   │   ├── Change_PhoneNumber.Designer.cs
│   │   ├── Change_PhoneNumber.cs
│   │   ├── Change_PhoneNumber.resx
│   │   ├── Edit_Profile.Designer.cs
│   │   ├── Edit_Profile.cs
│   │   ├── Edit_Profile.resx
│   │   ├── Make_Complaint.Designer.cs
│   │   ├── Make_Complaint.cs
│   │   ├── Make_Complaint.resx
│   │   ├── Ticket_Details.Designer.cs
│   │   ├── Ticket_Details.cs
│   │   ├── Ticket_Details.resx
│   │   ├── Upgrade_Ticket.Designer.cs
│   │   ├── Upgrade_Ticket.cs
│   │   └── Upgrade_Ticket.resx
│   ├── Properties
│   │   ├── AssemblyInfo.cs
│   │   ├── Resources.Designer.cs
│   │   ├── Resources.resx
│   │   ├── Settings.Designer.cs
│   │   └── Settings.settings
│   ├── Resources
│   │   ├── 1419767.jpg
│   │   ├── Back-Ground.jpg
│   │   ├── 6108b580.jpg
│   │   ├── michal-parzuchowski-dmH3NWhYTHQ-unsplash.jpg
│   │   ├── michal-parzuchowski-dmH3NWhYTHQ-unsplash1.jpg
│   │   └─railway-station-platform-with-modern-high-speed-trains-clock_273525-355.jpg
│   ├── Admin.Designer.cs
│   ├── Admin.cs
│   ├── Admin.resx
│   ├── App.config
│   ├── Controller.cs
│   ├── Create_acc.Designer.cs
│   ├── Create_acc.cs
│   ├── Create_acc.resx
│   ├── DBManager.cs
│   ├── Employee.Designer.cs
│   ├── Employee.cs
│   ├── Employee.resx
│   ├── Handle.cs
│   ├── Manager.Designer.cs
│   ├── Manager.cs
│   ├── Manager.resx
│   ├── Passenger.Designer.cs
│   ├── Passenger.cs
│   ├── Passenger.resx /9/1419767
│   ├── Program.cs
│   ├── StoredProcedures.cs
│   ├── TrainStation.csproj
│   ├── TrainStation.csproj.user
│   ├── TrainStation.sln
│   ├── UserLog.Designer.cs
│   ├── UserLog.cs
│   └── UserLog.resx
├── Accessing DB from C# App.pdf
├── CreateDatabaseQuery.sql
├──  InsertValues.sql
├── Lincense
├── README.md
├── Report .pdf
└── Schema.png
```

<hr style="background-color: #4b4c60"></hr>

## <img  width= 70px height =70px src="images/emoji/husky-and-shiba-二哈萌柴微信表情.gif"> Contributors <a id ="Contributors"></a>

<table align="center" >
  <tr>
    <td align="center"><a href="https://github.com/SarahElzayat" ><img src="https://avatars.githubusercontent.com/u/76779284?v=4" width="150px;" alt=""/><br /><sub><b>Sarah Elzayat</b></sub></a><br /></td>
    <td align="center"><a href="https://github.com/yasmineghanem"><img src="https://avatars.githubusercontent.com/u/74925701?v=4" width="150px;" alt=""/><br /><sub><b>Yasmine Ghanem</b></sub></a><br /></td>
     <td align="center"><a href="https://github.com/YasminElgendi"><img src="https://avatars.githubusercontent.com/u/54359829?v=4" width="150px;" alt=""/><br /><sub><b>Yasmin Elgendi</b></sub></a><br /></td>
     <td align="center"><a href="https://github.com/EslamAsHhraf"><img src="https://avatars.githubusercontent.com/u/71986226?v=4" width="150px;" alt=""/><br /><sub><b>Eslam Ashraf</b></sub></a><br /></td>
  </tr>
</table>
