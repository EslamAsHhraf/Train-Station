USE TrainStation 
insert into User_Login values
('jonathon.taylor@sqltutorial.org','123456789','Employee','jonathon taylor'),
('steven.king@sqltutorial.org','abc@123456789','Employee','steven king'),
('valli.pataballa@sqltutorial.org','123valli','Employee','valli pataballa'),
('diana.lorentz@sqltutorial.org','123diana','Employee','diana lorentz'),
('john.chen@sqltutorial.org','123john','Employee','john chen'),
('neena.kochhar@sqltutorial.org','123neena','Passenger','neena kochhar'),
('bruce.ernst@sqltutorial.org','123bruce','Passenger','bruce ernst'),
('david.austin@sqltutorial.org','123david','Passenger','david austin'),
('payam.kaufling@sqltutorial.org','123payam','Passenger','payam kaufling'),
('ismael.sciarra@sqltutorial.org','123ismael','Manager','ismael sciarra'),
('luis.popp@sqltutorial.org','123luis','Admin','luis popp');

insert into CovidVaccination values
(123789456,'ASTRAZENECA','London Hospital'),
(333444455,'MODERNA','Manchester Hospital'),
(223334444,'CANSINO BIOLOGICS','London Hospital'),
(888888888,'ASTRAZENECA','Leicester Hospital'),
(999999999,'ASTRAZENECA','Liverpool Hospital'),
(444444444,'CANSINO BIOLOGICS','Manchester Hospital'),
(777777777,'MODERNA','Leicester Hospital'),
(444433322,'MODERNA','Liverpool Hospital'),
(888833322,'JANSSEN','London Hospital'),
(666622222,'JANSSEN','London Hospital');

insert into Department values
(5,'Recepion',NULL),
(6,'Security',NULL),
(7,'Marketing',NULL);

insert into Employee values
(123456789,'jonathon','M', 'taylor','M','1998-03-24',10000,5,6,'Green Lane','London',NULL,5,123789456,'2021-03-24','jonathon.taylor@sqltutorial.org'),
(777788888,'steven','A', 'king','M','1997-01-05',20000,8,2,'Manor Road','London',123456789,5,333444455,'2021-01-05','steven.king@sqltutorial.org'),
(999911111,'valli','B', 'pataballa','M','1996-10-01',30000,8,5,'Kingsway','London',NULL,6,223334444,'2021-10-01','valli.pataballa@sqltutorial.org'),
(777755555,'diana','C', 'lorentz','F','1998-09-28',25000,9,2,'Mill Lane','Liverpool',999911111,6,888888888,'2021-09-28','diana.lorentz@sqltutorial.org'),
(666664444,'john','F', 'chen','M','1995-05-01',35000,2,5,'Grove Road','Manchester',999911111,6,999999999,'2021-05-01','john.chen@sqltutorial.org'),
(666664445,'ismael','M', 'sciarra','M','1999-12-07',60000,2,2,'School Lane','leicester',NULL,6,444444444,'2021-12-07','ismael.sciarra@sqltutorial.org');

insert into E_PhoneNumber values
(123456789,1999155),
(123456789,1901955),
(777788888,1991455),
(777755555,1906655);


insert into Passenger values
(333335555,'neena','S','kochhar','F','neena.kochhar@sqltutorial.org',777777777,'2021-01-04'),
(333334444,'bruce','D','ernst','M','bruce.ernst@sqltutorial.org',444433322,'2021-01-06'),
(666655555,'david','E','austin','M','david.austin@sqltutorial.org',888833322,'2021-02-26'),
(666677777,'payam','R','kaufling','M','payam.kaufling@sqltutorial.org',666622222,'2021-05-30');

insert into Pass_PhoneNumber values
(333335555,3316194),
(333335555,3319000),
(333334444,3319491),
(666655555,3319500);

insert into Complaints values
('ee111','Wait too much to buy ticket',333334444),
('cc111','Ticket is very expensive',666655555);







