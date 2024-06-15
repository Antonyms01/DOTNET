create procedure emp_update
@pid int,
@pname nvarchar(max),
@psalary float
as
begin
update Employee set  name=@pname,salary=@psalary where id=@pid;
end
