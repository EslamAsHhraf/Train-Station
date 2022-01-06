use TrainStation
go
create PROCEDURE Employee_data 
AS
BEGIN
       SET NOCOUNT ON;
SELECT * FROM Employee
END
