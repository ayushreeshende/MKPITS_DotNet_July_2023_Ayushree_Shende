create table orders (ord_no int, purch_amt float, ord_date date, customer_id int, salesman_id int,city varchar(20),grade int)
insert into orders values(70001 , 150.5, '2012-10-05' , 3005, 5002,'paris',100)
insert into orders values(70009 , 270.65, '2012-09-10',  3001, 5005,'london',200)
insert into orders values(70002 , 65.26 ,' 2012-10-05' ,3002, 5001,'paris',300)
insert into orders values(70004 , 110.5, '2012-08-17',  3009,   5003,'rome',100)
insert into orders values(70007 ,  948.5,' 2012-09-10 ', 3005 ,  5002,'san jose',200)
insert into orders values(70005  , 2400.6,'2012-07-27',  3007, 5001,'usa',200)
insert into orders values(70008  , 5760,' 2012-09-10',  3002, 5001,'uk',200)
select * from orders
select distinct salesman_id from orders
select * from  orders where city='paris'
select * from orders where salesman_id=5001
select * from orders where grade=200
drop table orders



