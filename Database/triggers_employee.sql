create table employee (empid int primary key,
empname varchar(20))

CREATE TABLE EmpLog (
	LogID int IDENTITY(1,1) NOT NULL,
	EmpID int ,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL)	

	create trigger empt
on employee
for insert
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'insert',GETDATE() from inserted; 

insert into employee values(11,'amit')
insert into employee values(12,'harshit')
insert into employee values(13,'amey')
select * from employee
select * from Emplog


insert into employee values(10,'amita')
insert into employee values(9,'arpit')
insert into employee values(8,'ayush')
select * from employee
select * from emplog
