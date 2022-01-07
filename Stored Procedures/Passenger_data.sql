use TrainStation
go
create PROCEDURE Passenger_data 
AS
BEGIN
       SET NOCOUNT ON;

SELECT Pass_SSN 'SSN',Pass_Fname+' '+Pass_Minit+'. '+Pass_Lname 'Name',Pass_Gender 'Gender',
Pass_CV_SerialNo 'Serial Number of vacc',Pass_Vacc_Date 'Date of vacc',Vacc_Type 'Type of Vacc',Organisation 'Organisation',Pass_Email 'Email'
FROM Passenger,CovidVaccination where SerialNo=Pass_CV_SerialNo;

END
