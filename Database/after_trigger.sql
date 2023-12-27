create table employee (empid int primary key,
empname varchar(20))
insert into employee values(1,'amitabh')
insert into employee values(2,'amey')
insert into employee values(3,'harshu')
insert into employee values(4,'likhit')
select * from employee

CREATE TABLE EmpLog (
	LogID int IDENTITY(1,1) NOT NULL,
	EmpID int ,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL)	

	create trigger empu
on employee
after update
as
insert into EmpLog(EmpID,Operation,UpdatedDate)

select empid,'update',GETDATE() from deleted

select * from employee
update employee set empname='amitabh' where empid=1

select * from employee
select * from EmpLog
