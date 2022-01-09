use TrainStation
go
create PROCEDURE SSN_Passenger
AS
BEGIN
       SET NOCOUNT ON;
 SELECT Pass_SSN FROM Passenger
END