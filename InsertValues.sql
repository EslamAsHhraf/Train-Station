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
	   ('LAMAbeyes@gmail.com','Lamaa111','employee','Lamloom'),
	   ('SamSmithsss@gmail.com','sam111','employee','Sam'),

	    ('LillyGallegos@yahoo.com','lilly57','employee','Lilly12'),
	   ('BrandenKey@yahoo.com','14528','employee','Branden'),
	   ('DanielaBooker@gmail.com','9512414','employee','DanielaB'),
	   ('AlisaCherry@outlook.com','4204245','employee','Alisa_Cherry'),
	   ('SameraJackson@gmail.com','10452','employee','SameraJ'),
	   ('RihannaBrock@gmail.com','452045','employee','RihannaB'),
	   ('FranklinOrtega@yahoo.com','f84153','employee','FranklinO'),
	   ('BrittneyRobertson@gmail.com','brit251','employee','BrittneyR'),
	   ('ImaanBenitez@gmail.com','Im656','employee','ImaanB'),
	   ('TierneyKrueger@gmail.com','T84541D','employee','TierneyK'),
	   
	   
		('AiyshaLyon@gmail.com','AiyshaLyon','passenger','AiyshaLyon'),
		('SapphireRiley@outlook.com','Sapphire123','passenger','Sapphire'),
		('ChelseyMay@yahoo.com','Chelsey789','passenger','Chelsey'),
		('AlawParkes@outlook.com','Alaw99','passenger','AlawParkes'),
		('EvelinaBird@trainstation.com','Evel888','passenger','EvelinaBird'),
		('MargaretEdwards@gmail.com','Margaret777','passenger','MargaretEdwards'),
		('LukasRogers@outlook.com','Lukas556','passenger','LukasRogers'),
		('AngelicaRowley@yahoo.com','Angel1234','passenger','Angel'),
	   

	   ('AbigayleBeach@outlook.com','Abigay997','passenger','Abigay'),
		('SullivanBlundell@trainstation.com','Sullivan123','passenger','Sullivan'),
		('GriffinScott@gmail.com','Griffin789!','passenger','Griffin'),
		('DaisyCharlton@outlook.com','99Daisy','passenger','Daisy'),
		('JacqueWoodcock@yahoo.com','Jacque888','passenger','Jacque'),
		('YosefBarrett@outlook.com','Yosef888','passenger','Yosef Barrett'),
		('LibbieBerry@trainstation.com','LibbieBerry556','passenger','Libbie Berry');

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
	   (323512100,'Pfizer','Yorkshire Hospital'),

	   (532422542,'SinoPharm','Yorkshire Hospital'),
	   (533543535,'Pfizer','Alsalam Clinic'),
	   (555533334, 'Sinovac','Addison Hospital' ),
	   (222211144,'Sinovac','Addison Gilbert Hospital'),
	   (535220000,'SinoPharm','St.Louis Hospital'),
	   (877511000,'Sinovac','Bayfront Hospital'),
	   (277474441, 'Pfizer','Beverly Hospital' ),
	   (105200011,'AstraZeneca','Peace Hospital'),
	   (415566523,'AstraZeneca','St.Mark Hospital'),
	   (755557777,'Pfizer','Alsalam Hospital'),

	   (111452854,'SinoPharm','Yorkshire Hospital'),
	   (454444444,'Pfizer','Alsalam Clinic'),
	   (111112222, 'Sinovac','Addison Hospital' ),
	   (543254225,'Sinovac','Addison Gilbert Hospital'),
	   (542457857,'SinoPharm','St.Louis Hospital'),
	   (888899777,'Sinovac','Bayfront Hospital'),
	   (885556624, 'Pfizer','Beverly Hospital' ),
	   (154452223,'AstraZeneca','Peace Hospital'),
	   (559996663,'AstraZeneca','St.Mark Hospital'),
	   (100022233,'Pfizer','Alsalam Hospital'),
	   (333060522,'Sinovac','Bayfront Hospital'),
	   (622332000, 'Pfizer','Beverly Hospital' ),
	   (449511260,'AstraZeneca','Peace Hospital'),
	   (111223333,'AstraZeneca','St.Mark Hospital'),
	   (663126423,'Pfizer','Alsalam Hospital');
       --('SERIALNO','VACC_TYPE','ORGANISATION')

INSERT INTO Department
VALUES (1,'Adminstration',NULL),
	   (2,'Reservation Clerk',NULL),
	   (3,'Drivers',NULL),
	   (7,'Security',NULL),
	   (4,'Goods Guard',NULL),
	   (5,'Junior Accounts Assistant',NULL),
	   (6,'Senior Conductor',NULL);
	   --('DEPARTMENTNUMBER','DEPARTMENTNAME','MGR_SSN')

INSERT INTO Employee
VALUES 
	   (775755564,'Joseph','R','James','M','1994-07-30',41000,5,40,'Manial','Cairo',NULL,6,185962587,'2021-02-16','Josephjames@yahoo.com'),
	   (442536876,'Joey','J','Hilton','M','1980-04-11',15000,2,4,'Faisal','Giza',256102011,5,111245638,'2021-02-24','JoeyHilton@yahoo.com'),
	   (125456789,'james','J','Ross','M','1986-04-22',24500,4,11,'Teseen Street','New Cairo',256102011,1,486512555,'2021-08-24','james@gmail.com'),
	   (154446895,'Sarah','R','Elzayat','F','1990-10-16',44400,3,46,'Haram','Giza',NULL,2,444587951,'2021-06-16','SarahElzayat@outlook.com'),
	   (444585555,'Erica','J','Sam','F','1988-12-24',20222,1,22,'street1','6th of october',148452100,3,885626444,'2021-01-24','EricaSam@gmail.com'),
	   (752540255,'Dana','R','Riggs','F','1997-05-26',30000,1,6,'Ahmed Elzomor','Cairo',148452100,2,985652165,'2021-04-16','DanaRiggs@gmail.com'),
	   (435020050,'Johnathon','J','Mann','M','1985-04-16',10000,2,4,'Bab elooq','Cairo',148452100,7,625315122,'2021-06-24','JohnathonMann@yahoo.com'),
	   (452012452,'Layton','R','Rhodes','M','1990-07-26',20000,3,6,'Talaat Harb','Cairo',NULL,2,222225425,'2021-06-16','LaytonRhodes@gmail.com'),
	   (148452100,'Sam','R','Smith','M','1990-07-25',20000,1,66,'District 10','Elsheikh Zayed',NULL,4,955564423,'2021-06-22','SamSmithsss@gmail.com'),
	   (256102011,'Lama','R','Beyers','F','1999-07-25',20000,1,23,'Elmotamayez','6th of October',NULL,3,898261511,'2021-06-22','LAMAbeyes@gmail.com'),

	   (532422542,'Lilly','A','Gallegos','F','1995-07-30',41000,5,45,'Fostat','Cairo',NULL,6,532422542,'2021-02-26','LillyGallegos@yahoo.com'),
	   (533543535,'Branden','J','Key','M','1980-11-11',15500,2,4,'Faisal','Giza',256102011,5,533543535,'2021-05-24','BrandenKey@yahoo.com'),
	   (555533334,'Daniela','C','Booker','F','1988-04-22',14500,4,11,'Teseen Street','New Cairo',256102011,1,555533334,'2021-11-24','DanielaBooker@gmail.com'),
	   (222211144,'Alisa','V','Cherry','F','1998-10-16',42400,3,10,'Haram','Giza',NULL,2,222211144,'2021-07-16','AlisaCherry@outlook.com'),
	   (535220000,'Samera','B','Jackson','F','1998-02-24',24200,1,57,'street3','6th of october',148452100,3,535220000,'2021-04-24','SameraJackson@gmail.com'),
	   (877511000,'Rihanna','E','Brock','F','1999-01-26',30110,1,4,'Ahmed Shawky','Cairo',148452100,2,877511000,'2021-05-16','RihannaBrock@gmail.com'),
	   (277474441,'Franklin','W','Ortega','M','1995-04-16',10400,2,2,'Champelion','Cairo',148452100,7,277474441,'2021-06-24','FranklinOrtega@yahoo.com'),
	   (105200011,'Brittney','K','Robertson','F','1990-07-26',20200,3,44,'Talaat Harb','Cairo',NULL,2,105200011,'2021-09-16','BrittneyRobertson@gmail.com'),
	   (415566523,'Imaan','L','Benitez','F','1990-07-13',62000,1,26,'District 11','Elsheikh Zayed',NULL,4,415566523,'2021-09-22','ImaanBenitez@gmail.com'),
	   (755557777,'Tierney','D','Krueger','M','1993-05-25',77000,1,20,'Elhussein','6th of October',NULL,3,755557777,'2021-06-22','TierneyKrueger@gmail.com');
	   --('SSN','FNAME','MINIT','LNAME','GENDER','DOB','SALARY','RATE','HOUSE_NUM','STREET', 'CITY', 'SUPERSSN','DNO','CV_SERIALNO','VACC_DATE','EMP_EMAIL')
	   
UPDATE  Department
SET MGR_SSN = 125456789
WHERE DepartmentNumber = 1;


UPDATE  Department
SET MGR_SSN = 154446895
WHERE DepartmentNumber = 2;

UPDATE  Department
SET MGR_SSN = 444585555
WHERE DepartmentNumber = 3;

UPDATE  Department
SET MGR_SSN = 148452100
WHERE DepartmentNumber = 4;

UPDATE  Department
SET MGR_SSN = 442536876
WHERE DepartmentNumber = 5;

UPDATE  Department
SET MGR_SSN = 775755564
WHERE DepartmentNumber = 6;

UPDATE  Department
SET MGR_SSN = 435020050
WHERE DepartmentNumber = 7;

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
	   (256102011,'01555564989'),

	   (532422542,'01112546666'),
	   (533543535,'01000163622'),
	   (555533334,'01066633510'),
	   (222211144,'01555555241'),
	   (535220000,'01222241326'),
	   (877511000,'01233625005'),
	   (277474441,'01145952616'),
	   (105200011,'01584923200'),
	   (415566523,'01222012265'),
	   (755557777,'01086655555');

	   
	   --('ESSN','PHONENUMBER')

INSERT INTO Passenger
VALUES (121212121,'Anna','M','Craig', 'F','AnnaCraig@outlook.com',859988888,'2020-12-12'),
	   (131313131,'Jarod','R','Zimmer','M','JarodZimmerman@gmail.com',223256631,'2021-02-04'),
	   (111155520,'Eliott','M','Ali', 'M','EliottAli@outlook.com',596255266,'2020-12-12'),
	   (520120444,'Daniella','R','Whittaker','F','DaniellaWhittaker@yahoo.com',989898975,'2021-02-04'),
	   (454520450,'Emelia','M','Clark', 'F','EmeliaClark@outlook.com',125444444,'2020-12-12'),
	   (525487777,'Sophia','R','Stewart','F','SophiaStewart@trainstation.com',323512100,'2021-02-04'),
	   

	   (542042200,'Aiysha','R','Lyon','M','AiyshaLyon@gmail.com',111452854,'2021-02-04'),
	   (151111552,'Sapphire','M','Riley', 'M','SapphireRiley@outlook.com',454444444,'2020-12-12'),
	   (221112556,'Chelsey','R','May','F','ChelseyMay@yahoo.com',111112222,'2021-02-04'),
	   (226543514,'Alaw','M','Parkes', 'F','AlawParkes@outlook.com',543254225,'2020-12-12'),
	   (211110220,'Evelina','R','Bird','F','EvelinaBird@trainstation.com',542457857,'2021-02-04'),
	   (153484681,'Margaret','R','Edwards','M','MargaretEdwards@gmail.com',888899777,'2021-02-04'),
	   (200022213,'Lukas','M','Rogers', 'M','LukasRogers@outlook.com',885556624,'2020-12-12'),
	   (684153315,'Angelica','R','Rowley','F','AngelicaRowley@yahoo.com',154452223,'2021-02-04'),
	   
	   (125165413,'Abigayle','M','Beach', 'F','AbigayleBeach@outlook.com',559996663,'2020-12-12'),
	   (125346446,'Sullivan','R','Blundell','F','SullivanBlundell@trainstation.com',100022233,'2021-02-04'),
	   (135215353,'Griffin','R','Scott','M','GriffinScott@gmail.com',333060522,'2021-02-04'),
	   (115422133,'Daisy','M','Charlton', 'M','DaisyCharlton@outlook.com',622332000,'2020-12-12'),
	   (155469688,'Jacque','R','Woodcock','F','JacqueWoodcock@yahoo.com',449511260,'2021-02-04'),
	   (855588896,'Yosef','M','Barrett', 'F','YosefBarrett@outlook.com',111223333,'2020-12-12'),
	   (999987754,'Libbie','R','Berry','F','LibbieBerry@trainstation.com',663126423,'2021-02-04');
	   --('PASS_SSN','PASS_FNAME', 'PASS_MINIT', 'PASS_LNAME', 'PASS_GENDER','PASS_EMAIL','PASS_CV_SERIALNO','PASS_VACC_DATE')

INSERT INTO Pass_PhoneNumber
VALUES (121212121,'01000025546'),
	   (131313131,'01123456712'),
	   (111155520,'01234245876'),
	   (520120444,'01112223334'),
	   (454520450,'01526455520'),
	   (525487777,'01555548620'),

	   (542042200,'01111222222'),
	   (151111552,'01000321145'),
	   (221112556,'01112544146'),
	   (226543514,'01555849966'),
	   (211110220,'01500100012'),
	   (153484681,'01000022233'),
	   (200022213,'01522214444'),
	   (684153315,'01000442222'),
	   (125165413,'01299899898'),
	   (125346446,'01023233333'),
	   (135215353,'01001444444'),
	   (115422133,'01025641654'),
	   (155469688,'01141250505'),
	   (855588896,'01111587777'),
	   (999987754,'01222547788');
	   --('PASS_SSN','PASS_PHONENUMBER')

INSERT INTO Complaints
VALUES (1,'Uncomfortable seat',525487777),
       (2,'rude employee',111155520);
       --('CCODE','DESCRIP','P_SSN')

INSERT INTO Handle
VALUES (1,442536876),
	   (2,442536876);
	   --('CODE','ESSN')



INSERT INTO Blacklist
VALUES (121212121,'2021-03-15','Theft');
       --('PSSN','DATE_BLACKLISTED','REASON')

INSERT INTO Train
VALUES (101010101,0,'Yellow',100), 
	   (121212121,0,'Green',50),
	   (555412684,1,'Red',50),
	   (112015320,0,'Grey',50);
	   --('PLATENUMBER','MAINTENANCE','COLOUR','CAPACITY')

INSERT INTO Station
VALUES (1111,'Cairo','Station1',3),
       (2222,'Alexandria','Station2',2),
	   (1242,'Asyoot','Station3',4),
	   (45224,'Ismaileya','Station4',5),
	   (13554,'Mansoura','Station5',3),
       (1221,'Benisuef','Station6',2),
	   (21205,'Damietta','Station7',4),
	   (45758,'Menofya','Station8',5);
       --('ID','ST_LOCATION','ST_NAME','NO_OF_TERMINALS')

INSERT INTO Trip
VALUES (1,'4:30','2:30',101010101,1111,2222),
       (2,'10:00','13:40',121212121,45758,21205),
	   (3,'6:30','2:30',101010101,1111,45224),
       (4,'5:00','11:40',121212121,1221,2222),
	   (5,'4:00','2:30',101010101,21205,1221),
       (6,'8:00','12:40',121212121,1221,21205);
       --('TRIPCODE','ARRIVAL_TIME','DEPARTURE_TIME','TRAIN_PLATENUMBER','COMESTATION','GOSTATION')

INSERT INTO Ticket
VALUES (11,'G',1000,'2020-02-01',154446895,111155520,1),
       (12,'G',300,'2020-02-02',154446895,111155520,2),
	   (65,'G',100,'2020-02-01',452012452,454520450,3),
       (452,'G',200,'2020-02-02',752540255,1313131313,4),
	   (542,'V',100,'2020-02-01',154446895,520120444,5),
       (558,'V',200,'2020-02-02',752540255,525487777,6);
	   --('TICKETNO','CLASS','PRICE','TICKET_DATE','ESSN','PSSN','TRIPCODE')



INSERT INTO Drive
VALUES (444585555,101010101),
       (256102011,121212121),
	   (444585555,555412684),
	   (256102011,112015320);
	   
       --('ESSN','TRAINNUM')
	   

