use TrainStation
go
create PROCEDURE Change_Rate @ssn int,@rate int
AS
BEGIN
       SET NOCOUNT ON;
UPDATE Employee SET Rate= @rate WHERE SSN= @ssn  
END
