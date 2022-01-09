use TrainStation
go
create PROCEDURE get_tele_E @ssn_e int
AS
BEGIN
       SET NOCOUNT ON;
SELECT PNumber 'Phonenumber' FROM  E_PhoneNumber
where ESSN=@ssn_e
END

