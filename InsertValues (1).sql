USE TrainStation
----------------------INSERT VALUES INTO TABLES-----------------------
INSERT INTO User_Login
VALUES ('adminuser@trainstation.com','1234','admin','1'),
	   ('employeeuser1@trainstation.com','1234','employee','2'),
	   ('employeeuser2@trainstation.com','1234','employee','3'),
	   ('manageruser1@trainstation.com','1234','manager','4'),
	   ('manageruser2@trainstation.com','1234','manager','5'),
	   ('passengeruser1@trainstation.com','1234','passenger','6'),
	   ('passengeruser2@trainstation.com','1234','passenger','7')
	   --('EMAIL','PASS','AUTHORITY','USERID')

INSERT INTO CovidVaccination
VALUES (12345, 'Pfizer','Hospital1' ),
	   (22345,'AstraZeneca','Hospital1'),
	   (12355,'SinoPharm','Hospital2'),
	   (12234,'Pfizer','Hospital3')
       --('SERIALNO','VACC_TYPE','ORGANISATION')

INSERT INTO Department
VALUES (1,'Driving',NULL),
	   (2,'Tickets',NULL)
	   --('DEPARTMENTNUMBER','DEPARTMENTNAME','MGR_SSN')

INSERT INTO Employee
VALUES (1111111111,'Erica','J','Ross','F','1985-04-16',10000,2,4,'street1','city1','1111111112',1,12345,'2021-08-24','employeeuser1@trainstation.com'),
	   (1111111112,'Harvey','R','Specter','M','1990-07-26',20000,3,6,'street2','city2','1111111111',2,22345,'2021-06-16','employeeuser2@trainstation.com')
	   --('SSN','FNAME','MINIT','LNAME','GENDER','DOB','SALARY','RATE','HOUSE_NUM','STREET', 'CITY', 'SUPERSSN','DNO','CV_SERIALNO','VACC_DATE','EMP_EMAIL')

UPDATE  Department
SET MGR_SSN = 1111111111
WHERE DepartmentNumber = 1


UPDATE  Department
SET MGR_SSN = 1111111112
WHERE DepartmentNumber = 2


INSERT INTO E_PhoneNumber
VALUES (1111111111,'01023456787'),
	   (1111111111,'01023456788'),
	   (1111111111,'01023456789'),
	   (1111111112,'01011112233'),
	   (1111111112,'01011112234')
	   --('ESSN','PHONENUMBER')

INSERT INTO Passenger
VALUES (1212121212,'Samantha','M','Jhonson', 'F','passengeruser1@trainstation.com',12355,'2020-12-12'),
	   (1313131313,'Max','R','Goodwin','M','passengeruser2@trainstation.com',12234,'2021-02-04')
	   --('PASS_SSN','PASS_FNAME', 'PASS_MINIT', 'PASS_LNAME', 'PASS_GENDER','PASS_EMAIL','PASS_CV_SERIALNO','PASS_VACC_DATE')

INSERT INTO Pass_PhoneNumber
VALUES (1212121212,'01023421231'),
	   (1212121212,'01123456712'),
	   (1313131313,'01234245876'),
	   (1313131313,'01029384756')
	   --('PASS_SSN','PASS_PHONENUMBER')

INSERT INTO Complaints
VALUES (1,'Uncomfortable seat',1212121212),
       (2,'rude employee',1313131313)
       --('CCODE','DESCRIP','P_SSN')

INSERT INTO Handle
VALUES (1,1111111111),
	   (2,1111111112)
	   --('CODE','ESSN')



INSERT INTO Blacklist
VALUES (1212121212,'2021-03-15','Theft')
       --('PSSN','DATE_BLACKLISTED','REASON')

INSERT INTO Train
VALUES (10101010,0,'Yellow',100), 
	   (12121212,0,'Green',50)
	   --('PLATENUMBER','MAINTENANCE','COLOUR','CAPACITY')

INSERT INTO Station
VALUES (1111,'Cairo','Station1',3),
       (2222,'Alexandria','Station2',2),
	   (1221,'Asyoot','Station3',4),
	   (2112,'Ismaileya','Station4',5)
       --('ID','ST_LOCATION','ST_NAME','NO_OF_TERMINALS')

INSERT INTO Trip
VALUES (1,'4:30','2:30',10101010,1111,2222),
       (2,'10:00','13:40',12121212,1221,2112)
       --('TRIPCODE','ARRIVAL_TIME','DEPARTURE_TIME','TRAIN_PLATENUMBER','COMESTATION','GOSTATION')

INSERT INTO Ticket
VALUES (11,'E',1000,'2020-02-01',1111111111,1212121212,1),
       (12,'B',2000,'2020-02-02',1111111111,1313131313,2)
	   --('TICKETNO','CLASS','PRICE','TICKET_DATE','ESSN','PSSN','TRIPCODE')



INSERT INTO Drive
VALUES (1111111111,10101010),
       (1111111111,12121212)
       --('ESSN','TRAINNUM')

