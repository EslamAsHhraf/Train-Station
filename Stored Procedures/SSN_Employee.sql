use TrainStation
go
create PROCEDURE SSN_Employee
AS
BEGIN
       SET NOCOUNT ON;
 SELECT SSN FROM Employee
END