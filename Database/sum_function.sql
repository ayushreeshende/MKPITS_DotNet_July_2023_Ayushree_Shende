create table student(rno int,name varchar(20),city varchar(50),course varchar(20),fees int,amount int,paiddate date)
insert into student values(1,'amit','nagpur','java',3000,6000,'2023-11-2')
insert into student values(2,'rajat','akola','oracle',5000,9000,'2023-9-18')
insert into student values(3,'ramesh','amravati','.net',600,7000,'2023-12-22')
insert into student values(4,'kunal','yavatmal','c',8000,2000,'2023-11-16')
select * from student
select rno,sum(fees) from student
group by rno

