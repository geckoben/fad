CREATE TRIGGER [SetCloture]
ON [Coachings]
AFTER INSERT, UPDATE
AS

BEGIN
	if(update(EstCloture))
	begin
		print 'ok'
		update Coachings set Cloture=1 where Clé=(select Clé from inserted)
	end
END

