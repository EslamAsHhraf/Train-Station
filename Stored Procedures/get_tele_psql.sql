use TrainStation
go
create PROCEDURE get_tele_p @ssn_e int
AS
BEGIN
       SET NOCOUNT ON;
SELECT P_PhoneNumber 'Phonenumber' FROM  Pass_PhoneNumber
where PSSN=@ssn_e
END

