use TrainStation
go
create PROCEDURE Change_Department @ssn_e int, @dep_e int
AS
BEGIN
       SET NOCOUNT ON;
UPDATE Employee SET Dno=@dep_e WHERE SSN=@ssn_e
END