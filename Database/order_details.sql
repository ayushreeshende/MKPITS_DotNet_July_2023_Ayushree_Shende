create  table order1(order1_id int identity primary key,order1_date date,cust_id int) 
create table orderdetails(order_id int,product_name varchar(20) , quantity int,
constraint fk11 foreign key(order_id)
references order1 (order1_id)) 
insert into order1 values('2022-8-10',123)
select * from order1
insert into orderdetails values(2,'mouse',2)
insert into orderdetails values(2,'keyboard',3)
select * from orderdetails
delete from order1 where order1_id=1
insert into order1 values(3,'2023-10-10',134)
select * from order1