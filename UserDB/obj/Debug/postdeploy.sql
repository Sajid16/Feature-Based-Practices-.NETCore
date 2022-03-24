if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName, LastName)
	values ('Tim', 'Corey'),
		   ('John', 'Smith'),
		   ('John', 'Doe'),
		   ('Marry', 'Jones'),
		   ('Sajid', 'Mahboob');
end
GO
