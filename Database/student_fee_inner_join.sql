create table student5(student_id int identity primary key,addmission_no varchar(20)not null,
first_name varchar(20)not null,
last_name varchar(30) not null,
age int,city varchar(20)not null)
insert into student5 values(7651,'achal','wagh',19,'nagpur')
insert into student5 values(5699,'anjali','mahajan',20,'bhopal')
insert into student5 values(2387,'avaintika','lokhande',18,'mumbai')
insert into student5 values(9077,'dhanashri','mate',20,'pune')
insert into student5 values(50021,'sanaskruti','meshram',21,'hyderabad')
insert into student5 values(8901,'shweta','raidas',22,'raipur')
select * from student5


create table mfee(addmission_no varchar(20)not null,courses varchar(20)not null,amount_paid int)
insert into mfee values(8901,'java',2000)
insert into mfee values(2387,'sql',7000)
insert into mfee values(7088,'oracle',9000)
insert into mfee values(8062,'python',6700)
select * from mfee



    SELECT student5.addmission_no, student5.first_name, student5.last_name, mFee.courses, mfee.amount_paid  
    FROM student5 
    INNER JOIN mFee  
    ON student5.addmission_no = mFee.addmission_no;  

	select student5.addmission_no,student5.first_name,student5.last_name,mfee.courses,mfee.amount_paid
	from student5
	cross join mfee

	select student5.addmission_no,student5.first_name,student5.last_name,mfee.courses,mfee.amount_paid
	from student5
	left outer join mfee
  ON student5.addmission_no = mfee.addmission_no;  

  

    SELECT student5.addmission_no, student5.first_name, student5.last_name, mfee.courses, mfee.amount_paid  
    FROM student5  
    RIGHT OUTER JOIN mfee  
    ON student5.addmission_no = mfee.addmission_no;
	
	select student5.addmission_no,student5.first_name,student5.last_name,mfee.courses,mfee.amount_paid
	from student5
	full outer join mfee
	on student5.addmission_no=mfee.addmission_no;

	drop table student5

	create table studen(id int identity primary key,first_name varchar(20)not null,
	last_name varchar(20)not null,city varchar(20));
	insert into studen values('amit','shahu','nagpur'),('rani','shende','pune')
	insert into studen values('archit','thakur','nagpur'),('vinit','kasture','hyderabad')
	insert into studen values('manish','gajbjiye','pune')
	select * from studen
	
	select s1.first_name,s2.last_name,s2.city
     from studen s1,studen s2
     where s1.id <> s2.id 
     and s1.city=s2.city
     order by s2.city



