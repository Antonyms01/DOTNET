create procedure sp_del

@pid int
as
begin
delete from employee where id=@pid;
end

