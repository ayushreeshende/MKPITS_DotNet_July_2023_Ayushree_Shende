
create table student(rno int, firstname varchar(50), lastname varchar(20),address varchar(50),city varchar(40),country varchar(50))

insert into student values(1,'amit','shah','ajni','nagpur','india')
insert into student values(2,'aish','nagdev','digori','chennai','usa')
insert into student values(3,'pallavi','lanjewar','umred','agra','uk')
insert into student values(4,'arpita','meshram','vanswadi','pune','america')
insert into student values(5,'kumud','patel','wadi','agra','europe')
insert into student values(6,'maahi','patel','besa','delhi','africa')
insert into student values(7,'rajat','kose','beltarodi','punjab','aisa')
insert into student values(8,'ramesh','raut','chintamani','amritsar','antartica')

select* from student
select * from student where firstname='pallavi' and lastname='lanjewar'


select country from student

drop table student



