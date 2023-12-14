create table student(rno int,name varchar(20),city varchar(50),course varchar(20),fees int,paiddate date)
insert into student values(1,'amit','nagpur','java',3000,'2023-11-2')
insert into student values(2,'rajat','akola','oracle',5000,'2023-9-18')
insert into student values(3,'ramesh','amravati','.net',600,'2023-12-22')
insert into student values(4,'kunal','yavatmal','c',8000,'2023-11-16')
select * from student
select * from student where paiddate  between '2023-11-1' and '2023-11-30'

select * from student where rno in(1,2)
select * from student where rno not in(1,2)
select * from student where name like '%am%'
select * from student where city like '%nag%'
select distinct city from student