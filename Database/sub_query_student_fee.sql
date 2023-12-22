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

create  table fees1( feesid int identity primary key ,
rno int,
feesdate date,
amount varchar(20)not null,
courseid int);

insert into fees1 values(1,'2023-8-9',3000,1)
insert into fees1 values(2,'2021-12-4',6000,2)
insert into fees1 values(3,'2022-11-2',8000,3)
insert into fees1 values(4,'2023-1-2',89000,4)
insert into fees1 values(5,'2020-10-10',7800,5)
select * from fees1

select feesid,rno,feesdate,amount,courseid
from fees1
where courseid in
(select courseid from students1 where city='nagpur')

select feesid,rno,feesdate,amount,courseid
from fees1
where courseid in
(select courseid from students1 where city='delhi')

select feesid,rno,feesdate,amount,courseid
from fees1
where courseid in
(select courseid from students1 where city='mumbai')