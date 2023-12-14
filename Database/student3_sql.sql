create table student(rno int,first_name varchar(20),last_name varchar (20),course varchar(30),city varchar(20),state varchar(50))
insert into student values(1,'amit','shah','dotnet','nagpur','maha')
insert into student values(2,'kumud','raut','java','mumbai','maha')
insert into student values(3,'ravi','shankar','oracle','bhopal','andhra pradesh')
insert into student values(4,'anshika','shende','sql','nagpur','mah')
insert into student values (5,'thiya','shende','c#','pune','up')
insert into student values (6,'kanisk','talaha','c','pune','rajasthan')
insert into student values(7,'hardik','shamkule','block chain','delhi','gujrat')

select * from student

select first_name  ,last_name from student order by first_name,last_name desc

select first_name ,last_name from student order by LEN (last_name) desc

select city, first_name from student order by city desc, first_name asc

select * from student where first_name='ravi' or city='nagpur'

drop table student


