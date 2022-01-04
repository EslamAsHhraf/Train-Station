use TrainStation
go
create PROCEDURE Change_Salary @ssn int,@salary int
AS
BEGIN
       SET NOCOUNT ON;
UPDATE Employee SET Salary= @salary WHERE SSN= @ssn  
END
