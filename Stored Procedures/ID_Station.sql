use TrainStation
go
create PROCEDURE ID_Station
AS
BEGIN
       SET NOCOUNT ON;
 SELECT ID FROM Station
END