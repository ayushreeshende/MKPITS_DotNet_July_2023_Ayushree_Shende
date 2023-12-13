create table student(rno int, name varchar (30),course varchar(20),city varchar(30),state varchar(40))
insert into student values(1,'sumit','java','nagpur','mah')
insert into student values(2,'amit','dotnet','nagpur','mah')
insert into student values(3,'komal','oracle','raipur','oddisa')
select * from student
select course ,COUNT(*) from student   
  where city ='nagpur'
  group by course order by course

  
  select city ,COUNT(*) from student
where state = 'mah'
group by city

drop table student

