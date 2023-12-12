create table employee(employeeid int primary key identity(1,1),empname varchar(20))
insert into employee(empname)values('rajesh')
select * from employee
insert into employee(empname)values('kunal')
select  * from employee
delete from employee where employeeid=1

insert into employee(empname)values('chestu123')
delete from employee
select * from employee
insert into employee(empname)values('chestu123')
insert into employee(empname) values('rajesh123')

insert into employee(empname) values('rajesh123')


create table stud(rno int ,name varchar(20) not null)

insert into stud(rno,name) values(6,'ravi')
select * from stud


