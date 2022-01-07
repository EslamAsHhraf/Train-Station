USE [master]
GO
/****** Object:  Database [TrainStation]    Script Date: 1/7/2022 10:25:53 AM ******/
CREATE DATABASE [TrainStation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TrainStation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TrainStation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TrainStation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TrainStation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TrainStation] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TrainStation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TrainStation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TrainStation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TrainStation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TrainStation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TrainStation] SET ARITHABORT OFF 
GO
ALTER DATABASE [TrainStation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TrainStation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TrainStation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TrainStation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TrainStation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TrainStation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TrainStation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TrainStation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TrainStation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TrainStation] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TrainStation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TrainStation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TrainStation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TrainStation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TrainStation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TrainStation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TrainStation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TrainStation] SET RECOVERY FULL 
GO
ALTER DATABASE [TrainStation] SET  MULTI_USER 
GO
ALTER DATABASE [TrainStation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TrainStation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TrainStation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TrainStation] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TrainStation] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TrainStation] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TrainStation', N'ON'
GO
ALTER DATABASE [TrainStation] SET QUERY_STORE = OFF
GO
USE [TrainStation]
GO
/****** Object:  Table [dbo].[Blacklist]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blacklist](
	[PSSN] [int] NOT NULL,
	[Date_Blacklisted] [date] NOT NULL,
	[Reason] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PSSN] ASC,
	[Date_Blacklisted] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Complaints]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Complaints](
	[C_Code] [varchar](20) NOT NULL,
	[Descrip] [varchar](200) NOT NULL,
	[P_SSN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[C_Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CovidVaccination]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CovidVaccination](
	[SerialNo] [int] NOT NULL,
	[Vacc_Type] [varchar](20) NOT NULL,
	[Organisation] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SerialNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmentNumber] [int] NOT NULL,
	[DepartmentName] [varchar](50) NOT NULL,
	[Mgr_SSN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drive]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drive](
	[ESSN] [int] NOT NULL,
	[TrainNum] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ESSN] ASC,
	[TrainNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[E_PhoneNumber]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[E_PhoneNumber](
	[ESSN] [int] NOT NULL,
	[PNumber] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ESSN] ASC,
	[PNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[SSN] [int] NOT NULL,
	[Fname] [varchar](20) NOT NULL,
	[Minit] [char](1) NOT NULL,
	[Lname] [varchar](20) NOT NULL,
	[Gender] [char](1) NOT NULL,
	[DOB] [date] NOT NULL,
	[Salary] [int] NOT NULL,
	[Rate] [int] NULL,
	[House_Num] [int] NOT NULL,
	[Street] [varchar](30) NOT NULL,
	[City] [varchar](20) NOT NULL,
	[Super_SSN] [int] NULL,
	[Dno] [int] NOT NULL,
	[CV_SerialNo] [int] NULL,
	[Vacc_Date] [date] NULL,
	[Emp_Email] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Handle]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Handle](
	[Code] [varchar](20) NOT NULL,
	[ESSN] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ESSN] ASC,
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pass_PhoneNumber]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pass_PhoneNumber](
	[PSSN] [int] NOT NULL,
	[P_PhoneNumber] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PSSN] ASC,
	[P_PhoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passenger]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passenger](
	[Pass_SSN] [int] NOT NULL,
	[Pass_Fname] [varchar](20) NOT NULL,
	[Pass_Minit] [char](1) NOT NULL,
	[Pass_Lname] [varchar](20) NOT NULL,
	[Pass_Gender] [char](1) NOT NULL,
	[Pass_Email] [varchar](50) NULL,
	[Pass_CV_SerialNo] [int] NOT NULL,
	[Pass_Vacc_Date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Pass_SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Station]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Station](
	[ID] [int] NOT NULL,
	[St_Location] [varchar](30) NOT NULL,
	[St_Name] [varchar](30) NOT NULL,
	[No_Of_Terminals] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[TicketNo] [int] NOT NULL,
	[Class] [char](1) NOT NULL,
	[Price] [int] NOT NULL,
	[Ticket_Date] [date] NOT NULL,
	[ESSN] [int] NULL,
	[PSSN] [int] NULL,
	[TripCode] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[TicketNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Train]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Train](
	[PlateNumber] [int] NOT NULL,
	[Maintenance] [bit] NOT NULL,
	[Colour] [varchar](10) NULL,
	[Capacity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PlateNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trip]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trip](
	[Trip_Code] [varchar](20) NOT NULL,
	[Arrival_Time] [time](7) NOT NULL,
	[Departure_Time] [time](7) NOT NULL,
	[Train_PlateNumber] [int] NULL,
	[Come_Station] [int] NULL,
	[Go_Station] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Trip_Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Login]    Script Date: 1/7/2022 10:25:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Login](
	[Email] [varchar](50) NOT NULL,
	[Pass] [varchar](50) NOT NULL,
	[Authority] [varchar](20) NOT NULL,
	[UserName] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Blacklist] ([PSSN], [Date_Blacklisted], [Reason]) VALUES (1212121212, CAST(N'2021-03-15' AS Date), N'Theft')
GO
INSERT [dbo].[Complaints] ([C_Code], [Descrip], [P_SSN]) VALUES (N'1', N'Uncomfortable seat', 1212121212)
INSERT [dbo].[Complaints] ([C_Code], [Descrip], [P_SSN]) VALUES (N'2', N'rude employee', 1313131313)
INSERT [dbo].[Complaints] ([C_Code], [Descrip], [P_SSN]) VALUES (N'cc111', N'Ticket is very expensive', 666655555)
INSERT [dbo].[Complaints] ([C_Code], [Descrip], [P_SSN]) VALUES (N'ee111', N'Wait too much to buy ticket', 333334444)
GO
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (12234, N'Pfizer', N'Hospital3')
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (12345, N'Pfizer', N'Hospital1')
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (12355, N'SinoPharm', N'Hospital2')
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (22345, N'AstraZeneca', N'Hospital1')
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (123789456, N'ASTRAZENECA', N'London Hospital')
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (223334444, N'CANSINO BIOLOGICS', N'London Hospital')
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (333444455, N'MODERNA', N'Manchester Hospital')
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (444433322, N'MODERNA', N'Liverpool Hospital')
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (444444444, N'CANSINO BIOLOGICS', N'Manchester Hospital')
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (666622222, N'JANSSEN', N'London Hospital')
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (777777777, N'MODERNA', N'Leicester Hospital')
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (888833322, N'JANSSEN', N'London Hospital')
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (888888888, N'ASTRAZENECA', N'Leicester Hospital')
INSERT [dbo].[CovidVaccination] ([SerialNo], [Vacc_Type], [Organisation]) VALUES (999999999, N'ASTRAZENECA', N'Liverpool Hospital')
GO
INSERT [dbo].[Department] ([DepartmentNumber], [DepartmentName], [Mgr_SSN]) VALUES (1, N'Driving', 1111111111)
INSERT [dbo].[Department] ([DepartmentNumber], [DepartmentName], [Mgr_SSN]) VALUES (2, N'Tickets', 1111111112)
INSERT [dbo].[Department] ([DepartmentNumber], [DepartmentName], [Mgr_SSN]) VALUES (5, N'Recepion', NULL)
INSERT [dbo].[Department] ([DepartmentNumber], [DepartmentName], [Mgr_SSN]) VALUES (6, N'Security', NULL)
INSERT [dbo].[Department] ([DepartmentNumber], [DepartmentName], [Mgr_SSN]) VALUES (7, N'Marketing', NULL)
GO
INSERT [dbo].[Drive] ([ESSN], [TrainNum]) VALUES (1111111111, 10101010)
INSERT [dbo].[Drive] ([ESSN], [TrainNum]) VALUES (1111111111, 12121212)
GO
INSERT [dbo].[E_PhoneNumber] ([ESSN], [PNumber]) VALUES (1111111112, N'01011112233')
INSERT [dbo].[E_PhoneNumber] ([ESSN], [PNumber]) VALUES (1111111112, N'01011112234')
INSERT [dbo].[E_PhoneNumber] ([ESSN], [PNumber]) VALUES (1111111111, N'01023456787')
INSERT [dbo].[E_PhoneNumber] ([ESSN], [PNumber]) VALUES (1111111111, N'01023456788')
INSERT [dbo].[E_PhoneNumber] ([ESSN], [PNumber]) VALUES (1111111111, N'01023456789')
INSERT [dbo].[E_PhoneNumber] ([ESSN], [PNumber]) VALUES (666664444, N'01111111111')
INSERT [dbo].[E_PhoneNumber] ([ESSN], [PNumber]) VALUES (123456789, N'1901955')
INSERT [dbo].[E_PhoneNumber] ([ESSN], [PNumber]) VALUES (777755555, N'1906655')
INSERT [dbo].[E_PhoneNumber] ([ESSN], [PNumber]) VALUES (777788888, N'1991455')
INSERT [dbo].[E_PhoneNumber] ([ESSN], [PNumber]) VALUES (123456789, N'1999155')
INSERT [dbo].[E_PhoneNumber] ([ESSN], [PNumber]) VALUES (666664444, N'5444')
GO
INSERT [dbo].[Employee] ([SSN], [Fname], [Minit], [Lname], [Gender], [DOB], [Salary], [Rate], [House_Num], [Street], [City], [Super_SSN], [Dno], [CV_SerialNo], [Vacc_Date], [Emp_Email]) VALUES (123456789, N'jonathon', N'M', N'taylor', N'M', CAST(N'1998-03-24' AS Date), 10000, 5, 6, N'Green Lane', N'London', NULL, 5, 123789456, CAST(N'2021-03-24' AS Date), N'jonathon.taylor@sqltutorial.org')
INSERT [dbo].[Employee] ([SSN], [Fname], [Minit], [Lname], [Gender], [DOB], [Salary], [Rate], [House_Num], [Street], [City], [Super_SSN], [Dno], [CV_SerialNo], [Vacc_Date], [Emp_Email]) VALUES (666664444, N'john', N'F', N'chen', N'M', CAST(N'1995-05-01' AS Date), 35000, 2, 5, N'Grove Road', N'Manchester', 999911111, 6, 999999999, CAST(N'2021-05-01' AS Date), N'ssss@')
INSERT [dbo].[Employee] ([SSN], [Fname], [Minit], [Lname], [Gender], [DOB], [Salary], [Rate], [House_Num], [Street], [City], [Super_SSN], [Dno], [CV_SerialNo], [Vacc_Date], [Emp_Email]) VALUES (777755555, N'diana', N'C', N'lorentz', N'F', CAST(N'1998-09-28' AS Date), 25000, 9, 2, N'Mill Lane', N'Liverpool', 999911111, 6, 888888888, CAST(N'2021-09-28' AS Date), N'diana.lorentz@sqltutorial.org')
INSERT [dbo].[Employee] ([SSN], [Fname], [Minit], [Lname], [Gender], [DOB], [Salary], [Rate], [House_Num], [Street], [City], [Super_SSN], [Dno], [CV_SerialNo], [Vacc_Date], [Emp_Email]) VALUES (777788888, N'steven', N'A', N'king', N'M', CAST(N'1997-01-05' AS Date), 20000, 8, 2, N'Manor Road', N'London', 123456789, 5, 333444455, CAST(N'2021-01-05' AS Date), N'steven.king@sqltutorial.org')
INSERT [dbo].[Employee] ([SSN], [Fname], [Minit], [Lname], [Gender], [DOB], [Salary], [Rate], [House_Num], [Street], [City], [Super_SSN], [Dno], [CV_SerialNo], [Vacc_Date], [Emp_Email]) VALUES (999911111, N'valli', N'B', N'pataballa', N'M', CAST(N'1996-10-01' AS Date), 30000, 8, 5, N'Kingsway', N'London', NULL, 6, 223334444, CAST(N'2021-10-01' AS Date), N'valli.pataballa@sqltutorial.org')
INSERT [dbo].[Employee] ([SSN], [Fname], [Minit], [Lname], [Gender], [DOB], [Salary], [Rate], [House_Num], [Street], [City], [Super_SSN], [Dno], [CV_SerialNo], [Vacc_Date], [Emp_Email]) VALUES (1111111111, N'Erica', N'J', N'Ross', N'F', CAST(N'1985-04-16' AS Date), 10000, 2, 4, N'street1', N'city1', 1111111112, 1, 12345, CAST(N'2021-08-24' AS Date), N'employeeuser1@trainstation.com')
INSERT [dbo].[Employee] ([SSN], [Fname], [Minit], [Lname], [Gender], [DOB], [Salary], [Rate], [House_Num], [Street], [City], [Super_SSN], [Dno], [CV_SerialNo], [Vacc_Date], [Emp_Email]) VALUES (1111111112, N'Harvey', N'R', N'Specter', N'M', CAST(N'1990-07-26' AS Date), 20000, 3, 6, N'street2', N'city2', 1111111111, 2, 22345, CAST(N'2021-06-16' AS Date), N'employeeuser2@trainstation.commm')
GO
INSERT [dbo].[Handle] ([Code], [ESSN]) VALUES (N'1', 1111111111)
INSERT [dbo].[Handle] ([Code], [ESSN]) VALUES (N'2', 1111111112)
GO
INSERT [dbo].[Pass_PhoneNumber] ([PSSN], [P_PhoneNumber]) VALUES (1212121212, N'01023421231')
INSERT [dbo].[Pass_PhoneNumber] ([PSSN], [P_PhoneNumber]) VALUES (1313131313, N'01029384756')
INSERT [dbo].[Pass_PhoneNumber] ([PSSN], [P_PhoneNumber]) VALUES (1212121212, N'01123456712')
INSERT [dbo].[Pass_PhoneNumber] ([PSSN], [P_PhoneNumber]) VALUES (1313131313, N'01156199904')
INSERT [dbo].[Pass_PhoneNumber] ([PSSN], [P_PhoneNumber]) VALUES (1212121212, N'1156199904')
INSERT [dbo].[Pass_PhoneNumber] ([PSSN], [P_PhoneNumber]) VALUES (1313131313, N'222555888')
INSERT [dbo].[Pass_PhoneNumber] ([PSSN], [P_PhoneNumber]) VALUES (333335555, N'3316194')
INSERT [dbo].[Pass_PhoneNumber] ([PSSN], [P_PhoneNumber]) VALUES (333335555, N'3319000')
INSERT [dbo].[Pass_PhoneNumber] ([PSSN], [P_PhoneNumber]) VALUES (333334444, N'3319491')
INSERT [dbo].[Pass_PhoneNumber] ([PSSN], [P_PhoneNumber]) VALUES (666655555, N'3319500')
GO
INSERT [dbo].[Passenger] ([Pass_SSN], [Pass_Fname], [Pass_Minit], [Pass_Lname], [Pass_Gender], [Pass_Email], [Pass_CV_SerialNo], [Pass_Vacc_Date]) VALUES (333334444, N'bruce', N'D', N'ernst', N'M', N'bruce.ernst@sqltutorial.org', 444433322, CAST(N'2021-01-06' AS Date))
INSERT [dbo].[Passenger] ([Pass_SSN], [Pass_Fname], [Pass_Minit], [Pass_Lname], [Pass_Gender], [Pass_Email], [Pass_CV_SerialNo], [Pass_Vacc_Date]) VALUES (333335555, N'neena', N'S', N'kochhar', N'F', N'neena.kochhar@sqltutorial.org', 777777777, CAST(N'2021-01-04' AS Date))
INSERT [dbo].[Passenger] ([Pass_SSN], [Pass_Fname], [Pass_Minit], [Pass_Lname], [Pass_Gender], [Pass_Email], [Pass_CV_SerialNo], [Pass_Vacc_Date]) VALUES (666655555, N'david', N'E', N'austin', N'M', N'david.austin@sqltutorial.org', 888833322, CAST(N'2021-02-26' AS Date))
INSERT [dbo].[Passenger] ([Pass_SSN], [Pass_Fname], [Pass_Minit], [Pass_Lname], [Pass_Gender], [Pass_Email], [Pass_CV_SerialNo], [Pass_Vacc_Date]) VALUES (666677777, N'payam', N'R', N'kaufling', N'M', N'payam.kaufling@sqltutorial.org', 666622222, CAST(N'2021-05-30' AS Date))
INSERT [dbo].[Passenger] ([Pass_SSN], [Pass_Fname], [Pass_Minit], [Pass_Lname], [Pass_Gender], [Pass_Email], [Pass_CV_SerialNo], [Pass_Vacc_Date]) VALUES (1212121212, N'Samantha', N'M', N'Jhonson', N'F', N'passengeruser1@trainstation.com', 12355, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[Passenger] ([Pass_SSN], [Pass_Fname], [Pass_Minit], [Pass_Lname], [Pass_Gender], [Pass_Email], [Pass_CV_SerialNo], [Pass_Vacc_Date]) VALUES (1313131313, N'Max', N'R', N'Goodwin', N'M', N's@', 12234, CAST(N'2021-02-04' AS Date))
GO
INSERT [dbo].[Station] ([ID], [St_Location], [St_Name], [No_Of_Terminals]) VALUES (1111, N'Cairo', N'Station1', 3)
INSERT [dbo].[Station] ([ID], [St_Location], [St_Name], [No_Of_Terminals]) VALUES (1221, N'Asyoot', N'Station3', 4)
INSERT [dbo].[Station] ([ID], [St_Location], [St_Name], [No_Of_Terminals]) VALUES (2112, N'Ismaileya', N'Station4', 5)
INSERT [dbo].[Station] ([ID], [St_Location], [St_Name], [No_Of_Terminals]) VALUES (2222, N'Alexandria', N'Station2', 2)
GO
INSERT [dbo].[Ticket] ([TicketNo], [Class], [Price], [Ticket_Date], [ESSN], [PSSN], [TripCode]) VALUES (12, N'V', 2000, CAST(N'2020-02-02' AS Date), 1111111112, 1313131313, N'2')
INSERT [dbo].[Ticket] ([TicketNo], [Class], [Price], [Ticket_Date], [ESSN], [PSSN], [TripCode]) VALUES (13, N'G', 2000, CAST(N'2020-02-03' AS Date), NULL, NULL, N'2')
GO
INSERT [dbo].[Train] ([PlateNumber], [Maintenance], [Colour], [Capacity]) VALUES (10101010, 1, N'Yellow', 100)
INSERT [dbo].[Train] ([PlateNumber], [Maintenance], [Colour], [Capacity]) VALUES (12121212, 0, N'Green', 50)
GO
INSERT [dbo].[Trip] ([Trip_Code], [Arrival_Time], [Departure_Time], [Train_PlateNumber], [Come_Station], [Go_Station]) VALUES (N'1', CAST(N'04:30:00' AS Time), CAST(N'02:30:00' AS Time), 10101010, 1111, 2222)
INSERT [dbo].[Trip] ([Trip_Code], [Arrival_Time], [Departure_Time], [Train_PlateNumber], [Come_Station], [Go_Station]) VALUES (N'2', CAST(N'10:00:00' AS Time), CAST(N'13:40:00' AS Time), 12121212, 1221, 2112)
GO
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'adminuser@trainstation.com', N'1234', N'admin', N'1')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'bruce.ernst@sqltutorial.org', N'123bruce', N'Passenger', N'bruce ernst')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'david.austin@sqltutorial.org', N'123david', N'Passenger', N'david austin')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'diana.lorentz@sqltutorial.org', N'123diana', N'Employee', N'diana lorentz')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'employeeuser1@trainstation.com', N'1234', N'employee', N'2')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'employeeuser2@trainstation.commm', N'12345', N'employee', N'3')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'ismael.sciarra@sqltutorial.org', N'123ismael', N'admin', N'ismael sciarra')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'jonathon.taylor@sqltutorial.org', N'123456789', N'Employee', N'jonathon taylor')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'luis.popp@sqltutorial.org', N'123luis', N'Admin', N'luis popp')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'manageruser1@trainstation.com', N'1234', N'manager', N'4')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'manageruser2@trainstation.com', N'1234', N'manager', N'5')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'neena.kochhar@sqltutorial.org', N'123neena', N'Passenger', N'neena kochhar')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'passengeruser1@trainstation.com', N'1234', N'passenger', N'6')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'payam.kaufling@sqltutorial.org', N'123payam', N'Passenger', N'payam kaufling')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N's@', N'444', N'passenger', N'7')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'ssss@', N'123john', N'Employee', N'john chen')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'steven.king@sqltutorial.org', N'abc@123456789', N'Employee', N'steven king')
INSERT [dbo].[User_Login] ([Email], [Pass], [Authority], [UserName]) VALUES (N'valli.pataballa@sqltutorial.org', N'123valli', N'Employee', N'valli pataballa')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Departme__D949CC34106447AA]    Script Date: 1/7/2022 10:25:53 AM ******/
ALTER TABLE [dbo].[Department] ADD UNIQUE NONCLUSTERED 
(
	[DepartmentName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__E_PhoneN__DDE0878CBDEB7F2E]    Script Date: 1/7/2022 10:25:53 AM ******/
ALTER TABLE [dbo].[E_PhoneNumber] ADD UNIQUE NONCLUSTERED 
(
	[PNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Employee__54DFB5F409CB6800]    Script Date: 1/7/2022 10:25:53 AM ******/
ALTER TABLE [dbo].[Employee] ADD UNIQUE NONCLUSTERED 
(
	[Emp_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__Employee__EB8D198BEBAB0C6B]    Script Date: 1/7/2022 10:25:53 AM ******/
ALTER TABLE [dbo].[Employee] ADD UNIQUE NONCLUSTERED 
(
	[CV_SerialNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Pass_Pho__72978967EAE59821]    Script Date: 1/7/2022 10:25:53 AM ******/
ALTER TABLE [dbo].[Pass_PhoneNumber] ADD UNIQUE NONCLUSTERED 
(
	[P_PhoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__Passenge__01D5661F85DFA937]    Script Date: 1/7/2022 10:25:53 AM ******/
ALTER TABLE [dbo].[Passenger] ADD UNIQUE NONCLUSTERED 
(
	[Pass_CV_SerialNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Passenge__FA8CEF3AC452FD0B]    Script Date: 1/7/2022 10:25:53 AM ******/
ALTER TABLE [dbo].[Passenger] ADD UNIQUE NONCLUSTERED 
(
	[Pass_Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Blacklist]  WITH CHECK ADD FOREIGN KEY([PSSN])
REFERENCES [dbo].[Passenger] ([Pass_SSN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD FOREIGN KEY([P_SSN])
REFERENCES [dbo].[Passenger] ([Pass_SSN])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Department]  WITH CHECK ADD FOREIGN KEY([Mgr_SSN])
REFERENCES [dbo].[Employee] ([SSN])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Drive]  WITH CHECK ADD FOREIGN KEY([ESSN])
REFERENCES [dbo].[Employee] ([SSN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Drive]  WITH CHECK ADD FOREIGN KEY([TrainNum])
REFERENCES [dbo].[Train] ([PlateNumber])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[E_PhoneNumber]  WITH CHECK ADD FOREIGN KEY([ESSN])
REFERENCES [dbo].[Employee] ([SSN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([CV_SerialNo])
REFERENCES [dbo].[CovidVaccination] ([SerialNo])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([Dno])
REFERENCES [dbo].[Department] ([DepartmentNumber])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([Emp_Email])
REFERENCES [dbo].[User_Login] ([Email])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([Super_SSN])
REFERENCES [dbo].[Employee] ([SSN])
GO
ALTER TABLE [dbo].[Handle]  WITH CHECK ADD FOREIGN KEY([Code])
REFERENCES [dbo].[Complaints] ([C_Code])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Handle]  WITH CHECK ADD FOREIGN KEY([ESSN])
REFERENCES [dbo].[Employee] ([SSN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pass_PhoneNumber]  WITH CHECK ADD FOREIGN KEY([PSSN])
REFERENCES [dbo].[Passenger] ([Pass_SSN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Passenger]  WITH CHECK ADD FOREIGN KEY([Pass_Email])
REFERENCES [dbo].[User_Login] ([Email])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Passenger]  WITH CHECK ADD FOREIGN KEY([Pass_CV_SerialNo])
REFERENCES [dbo].[CovidVaccination] ([SerialNo])
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD FOREIGN KEY([ESSN])
REFERENCES [dbo].[Employee] ([SSN])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD FOREIGN KEY([TripCode])
REFERENCES [dbo].[Trip] ([Trip_Code])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Trip]  WITH CHECK ADD FOREIGN KEY([Come_Station])
REFERENCES [dbo].[Station] ([ID])
GO
ALTER TABLE [dbo].[Trip]  WITH CHECK ADD FOREIGN KEY([Go_Station])
REFERENCES [dbo].[Station] ([ID])
GO
ALTER TABLE [dbo].[Trip]  WITH CHECK ADD FOREIGN KEY([Train_PlateNumber])
REFERENCES [dbo].[Train] ([PlateNumber])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD CHECK  (([Gender]='M' OR [Gender]='F'))
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD CHECK  (([Rate]>=(0) AND [Rate]<=(10)))
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD CHECK  (([Salary]>=(0)))
GO
ALTER TABLE [dbo].[Passenger]  WITH CHECK ADD CHECK  (([Pass_Gender]='M' OR [Pass_Gender]='F'))
GO
ALTER TABLE [dbo].[User_Login]  WITH CHECK ADD CHECK  (([Email] like '%@%'))
GO
USE [master]
GO
ALTER DATABASE [TrainStation] SET  READ_WRITE 
GO
