--------------CREATE DATABASE-------------
CREATE DATABASE TrainStation
GO

USE TrainStation
-------------CREATE TABLES----------------
CREATE TABLE User_Login
(
Email varchar(50) NOT NULL,
Pass varchar(50) NOT NULL,
Authority varchar(20) NOT NULL,
UserID varchar(30) NOT NULL,

PRIMARY KEY (Email),
)

CREATE TABLE CovidVaccination
(
SerialNo int NOT NULL,
Vacc_Type varchar(20) NOT NULL, 
Organisation varchar(30),

PRIMARY KEY (SerialNo),
)

CREATE TABLE Employee
(
SSN int NOT NULL,
Fname varchar(20) NOT NULL,
Minit char NOT NULL,
Lname varchar(20) NOT NULL,
Gender char,
DOB date,
Salary int NOT NULL,
Rate int,
House_Num int,
Street varchar(30),
City varchar(20),
Super_SSN int,
Dno int NOT NULL,
CV_SerialNo int,
Vacc_Date date,
Emp_Email varchar(50) NOT NULL,

PRIMARY KEY (SSN),
FOREIGN KEY (Super_SSN) REFERENCES Employee
--ON DELETE SET NULL
--ON UPDATE CASCADE
,
FOREIGN KEY (Emp_Email) REFERENCES User_Login
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (CV_SerialNo) REFERENCES CovidVaccination,
)

CREATE TABLE E_PhoneNumber
(
ESSN int NOT NULL, 
PNumber varchar(20)NOT NULL,

PRIMARY KEY (ESSN,PNumber),
FOREIGN KEY (ESSN) REFERENCES Employee
ON DELETE CASCADE
ON UPDATE CASCADE,
)

CREATE TABLE Department
(
DepartmentNumber int NOT NULL,
DepartmentName varchar(50) NOT NULL,
Mgr_SSN int,

PRIMARY KEY (DepartmentNumber),
FOREIGN KEY (Mgr_SSN) REFERENCES Employee
ON DELETE SET NULL
ON UPDATE CASCADE,
)

CREATE TABLE Passenger
(
Pass_SSN int NOT NULL,
Pass_Fname varchar(20) NOT NULL,
Pass_Minit char NOT NULL,
Pass_Lname varchar(20) NOT NULL,
Pass_Gender char,
Pass_Email varchar(50),
Pass_CV_SerialNo int NOT NULL,
Pass_Vacc_Date date NOT NULL,

PRIMARY KEY (Pass_SSN),
FOREIGN KEY (Pass_Email) REFERENCES User_Login
ON DELETE SET NULL
ON UPDATE CASCADE,
FOREIGN KEY (Pass_CV_SerialNo) REFERENCES CovidVaccination,
)

CREATE TABLE Complaints
(
C_Code varchar(20) NOT NULL,
Descrip varchar(200) NOT NULL,
P_SSN int,

PRIMARY KEY (C_Code),
FOREIGN KEY (P_SSN) REFERENCES Passenger
ON DELETE SET NULL,
)

CREATE TABLE Handle
(
Code varchar(20) NOT NULL,
ESSN int NOT NULL,

PRIMARY KEY (ESSN,Code),
FOREIGN KEY (ESSN) REFERENCES Employee
ON DELETE CASCADE 
ON UPDATE CASCADE,
FOREIGN KEY (Code) REFERENCES Complaints
ON DELETE CASCADE,
)

CREATE TABLE Blacklist
(
PSSN int NOT NULL,
Date_Blacklisted date NOT NULL,
Reason varchar(20),

PRIMARY KEY (PSSN,Date_Blacklisted),
FOREIGN KEY (PSSN) REFERENCES Passenger 
ON UPDATE CASCADE,
)

CREATE TABLE Pass_PhoneNumber
(
PSSN int NOT NULL,
P_PhoneNumber varchar(20) NOT NULL,

PRIMARY KEY (PSSN, P_PhoneNumber),
FOREIGN KEY (PSSN) REFERENCES Passenger
ON DELETE CASCADE
ON UPDATE CASCADE,
)

CREATE TABLE Train
(
PlateNumber int  NOT NULL,
Maintenance bit,
Colour varchar(10),
Capacity int,

PRIMARY KEY (PlateNumber),
)

CREATE TABLE Drive
(
ESSN int NOT NULL,
TrainNum int NOT NULL,

PRIMARY KEY (ESSN, TrainNum),
FOREIGN KEY (ESSN) REFERENCES Employee
ON DELETE CASCADE
ON UPDATE CASCADE,
FOREIGN KEY (TrainNum) REFERENCES Train
ON DELETE CASCADE
ON UPDATE CASCADE,
)

CREATE TABLE Station
(
ID int NOT NULL,
St_Location varchar(30) NOT NULL,
St_Name varchar(30) NOT NULL,
No_Of_Terminals int NOT NULL,

PRIMARY KEY (ID),
)

CREATE TABLE Trip
(
Trip_Code varchar(20) NOT NULL,
Arrival_Time time NOT NULL,
Departure_Time time NOT NULL,
Train_PlateNumber int,
Come_Station int,
Go_Station int,

PRIMARY KEY (Trip_Code),
FOREIGN KEY (Train_PlateNumber) REFERENCES Train
ON DELETE SET NULL
ON UPDATE CASCADE,
FOREIGN KEY (Come_Station) REFERENCES Station
--ON DELETE CASCADE
--ON UPDATE CASCADE
,
FOREIGN KEY (Go_Station) REFERENCES Station
--ON DELETE CASCADE
--ON UPDATE CASCADE,
)

CREATE TABLE Ticket
(
TicketNo int NOT NULL,
Class char NOT NULL,
Price int NOT NULL,
Ticket_Date date NOT NULL,
ESSN int,
TripCode varchar(20),

PRIMARY KEY (TicketNo),
FOREIGN KEY (ESSN) REFERENCES Employee
ON DELETE SET NULL,
FOREIGN KEY (TripCode) REFERENCES Trip
ON DELETE CASCADE
ON UPDATE CASCADE,
)

ALTER TABLE Employee ADD FOREIGN KEY (Dno) REFERENCES Department
