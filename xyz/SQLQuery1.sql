create procedure [dbo].[sp_emp_insert]
@id int,
@name nvarchar(100),
@salary float
as begin
insert into 