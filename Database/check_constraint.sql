create table product1(product_id int identity primary key,product_name varchar (20)not null,unit_price dec(10,2)constraint positive_price 
check(unit_price>0));
insert into product values('mouse',120)
insert into product values('keyboard',220)
insert into product values('scanner',130)
select * from product
 drop table product


 create table result(rno int  primary key,marks int check(marks>0));
 insert into result values(1,220)
 insert into result values(2,0)
 insert into result values(3,450)
 insert into result values(4,230)
 select * from result
 drop table result

 create table product2(product2_id int identity primary key,product2_name varchar(20)null,unit_price dec(10,2));

 insert into product2(product2_name,unit_price)
 values('harddisk',23)
 select * from product2
