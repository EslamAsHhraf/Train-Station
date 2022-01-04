use TrainStation
go
create PROCEDURE Insetr_Trip @TripCode varchar(20),@Arrival_Time time ,@Departure_Time time, @Train_PlateNumber int,@Come_Station int,@Go_Station int
AS
BEGIN
       SET NOCOUNT ON;
INSERT INTO Trip ( Trip_Code, Arrival_Time, Departure_Time,Train_PlateNumber,Come_Station,Go_Station)
   Values ( @TripCode , @Arrival_Time , @Departure_Time , @Train_PlateNumber ,@Come_Station , @Go_Station )
END
