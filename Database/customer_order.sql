create table customer1 (custid int ,custname varchar(20),custaddress varchar (100))
insert into customer1 values(1,'amit','pune')
insert into customer1 values(1,'sumit','mumbai')
insert into customer1 values(3,'komal','delhi')
insert into customer1 values(66,'manu','agra')
insert into customer1 values(88,'anu','kolkata')
insert into customer1 values(6,'punit','chennai')
select * from customer1
select * from customer1 order by custid desc
select * from customer1 where custname='komal'
select * from customer1 where custid=1
select * from customer1 where custid>1
select * from customer1 where custid>1 and custid<66
