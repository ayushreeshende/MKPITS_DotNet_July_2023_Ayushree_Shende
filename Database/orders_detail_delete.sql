create  table orders(orders_id int identity primary key,orders_date date,cust_id int) 
create table orderdetails(order_id int,product_name varchar(20) , quantity int,
constraint fk11 foreign key(order_id)
references orders (orders_id)) 
insert into orders values('2023-10-10',134)
insert into orders values('2024-5-8',345)
select * from orders
delete from orders where orders_id=1
select * from orders
insert into orderdetails values(2,'2023-6-9',2)
select * from orderdetails
delete from orders where orders_id=2
delete from orderdetails where order_id=2
