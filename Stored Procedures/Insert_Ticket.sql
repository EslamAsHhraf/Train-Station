use TrainStation
go
create PROCEDURE Insetr_ticket @TicketNo int,@Class char ,@Price int, @Ticket_Date date,@TripCode varchar(20)
AS
BEGIN
       SET NOCOUNT ON;
INSERT INTO Ticket ( TicketNo, Class, Price,Ticket_Date,TripCode)
  Values (  @TicketNo ,  @Class , @Price ,  @Ticket_Date , @TripCode ) 
END
