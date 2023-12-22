create  table courses1( courseid int identity primary key, 
coursename varchar(20)not null,
fees varchar(20)not null ,
duration int)

insert into courses1 values('java',4500,3)
insert into courses1 values('python',6700,4)
insert into courses1 values('java',5000,5)
insert into courses1 values('oracle',7800,4)
insert into courses1 values('python',9000,6)
insert into courses1 values('python',9300,6)
select * from courses1


create table students1(rno int identity primary key,
name varchar(20)not null,
emailid varchar(30)not null,
city varchar(20)not null,
courseid int);

insert into students1 values('komal','komal@gmail.com','nagpur',1)
insert into students1 values('harshit','harshit@gmail.com','mumbai',2)
insert into students1 values('amity','amit@gmail','delhi',3)
insert into students1 values('rajesh','raj@gmail','nagpur',4)
insert into students1 values('bilal','bilal@gmail.com','delhi',5)
insert into students1 values('raj','raj123gmail.com','delhi',6)
select * from students1


select rno,name,emailid,city,courseid
from students1
where courseid in
(select courseid from courses1 where coursename='java')


select rno,name,emailid,city,courseid
from students1
where courseid in
(select courseid from courses1 where coursename='python')


