USE TrainStation
----------------------INSERT VALUES INTO TABLES-----------------------
GO
INSERT INTO User_Login
VALUES ('james@gmail.com','1234admin','admin','JamesX'),
	   ('SarahElzayat@outlook.com','Sarah523','employee','Sara'),
	   ('EricaSam@gmail.com','FishRice','employee','EricaS'),
	   ('Josephjames@yahoo.com','SamuraiX','manager','JJames'),
	   ('JoeyHilton@yahoo.com','Joeydoesntsharefood','employee','JoeH'),
	   ('AnnaCraig@outlook.com','ANNCraig1990','passenger','ANNC'),
	   ('JarodZimmerman@gmail.com','ZimmeR537','passenger','JZimmer'),
	   ('DanaRiggs@gmail.com','DanaLovesFood','employee','Dana90'),
	   ('JohnathonMann@yahoo.com','JohnJesus','employee','Johnny'),
	   ('LaytonRhodes@gmail.com','Layton482','employee','LaytonRhodes'),
	   ('EliottAli@outlook.com','ANNCraig1990','passenger','ElyAli'),
	   ('DaniellaWhittaker@yahoo.com','danny5611','passenger','Danny'),
	   ('EmeliaClark@outlook.com','emelie199165','passenger','EmeliaClark'),
	   ('SophiaStewart@trainstation.com','sophie','passenger','Sophie123'),
	   ('LAMAbeyes@gmail.com','Lamaa111','employee','Lamloom')
	   
	   --('EMAIL','PASS','AUTHORITY','USERNAME')

INSERT INTO CovidVaccination
VALUES (185962587, 'Pfizer','Wellness Center' ),
	   (111245638,'AstraZeneca','Diagnostic Center'),
	   (486512555,'SinoPharm','Express Laboratory'),
	   (444587951,'Pfizer','Family Health Hospital'),
	   (885626444, 'Pfizer','Grace Medical' ),
	   (985652165,'AstraZeneca',' Lifeline Medical Center'),
	   (625315122,'SinoPharm','St.Thomas Hospital'),
	   (222225425,'Pfizer','Universal Body Clinic'),
	   (955564423, 'Sinovac','St.Joseph Hospital' ),
	   (898261511,'Sinovac','Addison Gilbert Hospital'),
	   (859988888,'SinoPharm','St.Louis Hospital'),
	   (223256631,'Sinovac','Bayfront Hospital'),
	   (596255266, 'Pfizer','Beverly Hospital' ),
	   (989898975,'AstraZeneca','Beckley Hospital'),
	   (125444444,'AstraZeneca','St.Mark Hospital'),
	   (323512100,'Pfizer','Yorkshire Hospital')
       --('SERIALNO','VACC_TYPE','ORGANISATION')

INSERT INTO Department
VALUES (1,'Adminstration',NULL),
	   (2,'Reservation Clerk',NULL),
	   (3,'Drivers',NULL),
	   (7,'Security',NULL),
	   (4,'Goods Guard',NULL),
	   (5,'Junior Accounts Assistant',NULL),
	   (6,'Senior Conductor',NULL)
	   --('DEPARTMENTNUMBER','DEPARTMENTNAME','MGR_SSN')

INSERT INTO Employee
VALUES 
	   (775755564,'Joseph','R','James','M','1994-07-30',41000,5,40,'Manial','Cairo',null,6,444587951,'2021-02-16','Josephjames@yahoo.com'),
	   (442536876,'Joey','J','Hilton','M','1980-04-11',15000,2,4,'Faisal','Giza',775755564,5,885626444,'2021-02-24','JoeyHilton@yahoo.com'),
	   (125456789,'james','J','Ross','M','1986-04-22',24500,4,11,'Teseen Street','New Cairo',775755564,1,185962587,'2021-08-24','james@gmail.com'),
	   (154446895,'Sarah','R','Elzayat','F','1990-10-16',44400,3,46,'Haram','Giza',442536876,2,111245638,'2021-06-16','SarahElzayat@outlook.com'),
	   (444585555,'Erica','J','Sam','F','1988-12-24',20222,1,22,'street1','6th of october',442536876,3,486512555,'2021-01-24','EricaSam@gmail.com'),
	   (752540255,'Dana','R','Riggs','F','1997-05-26',30000,1,6,'Ahmed Elzomor','Cairo',442536876,2,985652165,'2021-04-16','DanaRiggs@gmail.com'),
	   (435020050,'Johnathon','J','Mann','M','1985-04-16',10000,2,4,'Bab elooq','Cairo',752540255,7,625315122,'2021-06-24','JohnathonMann@yahoo.com'),
	   (452012452,'Layton','R','Rhodes','M','1990-07-26',20000,3,6,'Talaat Harb','Cairo',125456789,2,222225425,'2021-06-16','LaytonRhodes@gmail.com'),
	   (148452100,'Sam','R','Smith','M','1990-07-25',20000,1,66,'District 10','Elsheikh Zayed',444585555,4,125444444,'2021-06-22','SamSmithsss@gmail.com'),
	   (256102011,'Lama','R','Beyers','F','1999-07-25',20000,1,23,'Elmotamayez','6th of October',442536876,3,323512100,'2021-06-22','LAMAbeyes@gmail.com')
	   --('SSN','FNAME','MINIT','LNAME','GENDER','DOB','SALARY','RATE','HOUSE_NUM','STREET', 'CITY', 'SUPERSSN','DNO','CV_SERIALNO','VACC_DATE','EMP_EMAIL')
	   
UPDATE  Department
SET MGR_SSN = 125456789
WHERE DepartmentNumber = 1


UPDATE  Department
SET MGR_SSN = 154446895
WHERE DepartmentNumber = 2

UPDATE  Department
SET MGR_SSN = 444585555
WHERE DepartmentNumber = 3

UPDATE  Department
SET MGR_SSN = 148452100
WHERE DepartmentNumber = 4

UPDATE  Department
SET MGR_SSN = 442536876
WHERE DepartmentNumber = 5

UPDATE  Department
SET MGR_SSN = 775755564
WHERE DepartmentNumber = 6

UPDATE  Department
SET MGR_SSN = 435020050
WHERE DepartmentNumber = 7

INSERT INTO E_PhoneNumber
VALUES (775755564,'01023456787'),
	   (442536876,'01023456788'),
	   (125456789,'01023456789'),
	   (154446895,'01011112233'),
	   (444585555,'01114566682'),
	   (752540255,'01266578999'),
	   (435020050,'01002655544'),
	   (452012452,'01000666444'),
	   (148452100,'01155522210'),
	   (256102011,'01555564989')
	   --('ESSN','PHONENUMBER')

INSERT INTO Passenger
VALUES (121212121,'Anna','M','Craig', 'F','AnnaCraig@outlook.com',12355,'2020-12-12'),
	   (131313131,'Jarod','R','Zimmer','M','JarodZimmerman@gmail.com',12234,'2021-02-04'),
	   (111155520,'Eliott','M','Ali', 'M','EliottAli@outlook.com',12355,'2020-12-12'),
	   (520120444,'Daniella','R','Whittaker','F','DaniellaWhittaker@yahoo.com',12234,'2021-02-04'),
	   (454520450,'Emelia','M','Clark', 'F','EmeliaClark@outlook.com',12355,'2020-12-12'),
	   (525487777,'Sophia','R','Stewart','F','SophiaStewart@trainstation.com',12234,'2021-02-04')
	   --('PASS_SSN','PASS_FNAME', 'PASS_MINIT', 'PASS_LNAME', 'PASS_GENDER','PASS_EMAIL','PASS_CV_SERIALNO','PASS_VACC_DATE')

INSERT INTO Pass_PhoneNumber
VALUES (1212121212,'01000025546'),
	   (1212121212,'01123456712'),
	   (1313131313,'01234245876'),
	   (1313131313,'01112223334'),
	   (1212121212,'01526455520'),
	   (1313131313,'01555548620')
	   --('PASS_SSN','PASS_PHONENUMBER')

INSERT INTO Complaints
VALUES (1,'Uncomfortable seat',525487777),
       (2,'rude employee',111155520)
       --('CCODE','DESCRIP','P_SSN')

INSERT INTO Handle
VALUES (1,442536876),
	   (2,442536876)
	   --('CODE','ESSN')



INSERT INTO Blacklist
VALUES (121212121,'2021-03-15','Theft')
       --('PSSN','DATE_BLACKLISTED','REASON')

INSERT INTO Train
VALUES (101010101,0,'Yellow',100), 
	   (121212121,0,'Green',50),
	   (555412684,0,'Red',50),
	   (112015320,0,'Grey',50)
	   --('PLATENUMBER','MAINTENANCE','COLOUR','CAPACITY')

INSERT INTO Station
VALUES (1111,'Cairo','Station1',3),
       (2222,'Alexandria','Station2',2),
	   (1242,'Asyoot','Station3',4),
	   (45224,'Ismaileya','Station4',5),
	   (13554,'Mansoura','Station1',3),
       (1221,'Benisuef','Station2',2),
	   (21205,'Damietta','Station3',4),
	   (45758,'Menofya','Station4',5)
       --('ID','ST_LOCATION','ST_NAME','NO_OF_TERMINALS')

INSERT INTO Trip
VALUES (1,'4:30','2:30',10101010,1111,2222),
       (2,'10:00','13:40',12121212,13554,45354),
	   (3,'6:30','2:30',10101010,1111,21205),
       (4,'5:00','11:40',12121212,45354,2222),
	   (5,'4:00','2:30',10101010,45758,13554),
       (6,'8:00','12:40',12121212,1221,45354)
       --('TRIPCODE','ARRIVAL_TIME','DEPARTURE_TIME','TRAIN_PLATENUMBER','COMESTATION','GOSTATION')

INSERT INTO Ticket
VALUES (11,'E',1000,'2020-02-01',154446895,111155520,1),
       (12,'B',300,'2020-02-02',154446895,111155520,2),
	   (65,'E',100,'2020-02-01',452012452,454520450,3),
       (452,'B',200,'2020-02-02',752540255,1313131313,4),
	   (542,'E',100,'2020-02-01',154446895,520120444,5),
       (558,'B',200,'2020-02-02',752540255,525487777,6)
	   --('TICKETNO','CLASS','PRICE','TICKET_DATE','ESSN','PSSN','TRIPCODE')



INSERT INTO Drive
VALUES (444585555,101010101),
       (256102011,121212121),
	   (444585555,555412684),
	   (256102011,112015320)
	   
       --('ESSN','TRAINNUM')
	   

