use TrainStation
go
create PROCEDURE Dno_Department
AS
BEGIN
       SET NOCOUNT ON;
 SELECT DepartmentNumber FROM Department order by DepartmentNumber 
END