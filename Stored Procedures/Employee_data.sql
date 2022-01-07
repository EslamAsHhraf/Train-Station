use TrainStation
go
create PROCEDURE Employee_data 
AS
BEGIN
       SET NOCOUNT ON;

SELECT SSN,Fname+' '+Minit+'. '+Lname 'Name',Gender,DOB 'Date of birth',Salary,Rate,House_Num 'House Number', Street +' ,'+City 'Address'
,Super_SSN 'Supervisor',Dno 'Department Number',CV_SerialNo 'Serial Number of vacc',Vacc_Date 'Date of vacc',Vacc_Type 'Type of Vacc',Organisation 'Organisation',Emp_Email 'Email'
FROM Employee,CovidVaccination where SerialNo=CV_SerialNo;

END
