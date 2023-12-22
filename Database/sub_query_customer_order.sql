create table customers1(custid int identity primary key,
custname varchar(20)not null,
state varchar(20)not null,
city varchar(30));
insert into customers1 values('amit','maharashtra','nagpur')
insert into customers1 values('sumit','andra','nagpur')
insert into customers1 values('harsh','uttar prad','bhopal')
insert into customers1 values('ankush','mp','bhopal')
insert into customers1 values('monty','chandigad','raipur')
insert into customers1 values('kalu','amritsar','raipur')
select * from customers1

select custid from customers1 where  city='nagpur'

create table orders(orderid int,
custid int ,
orderdate date,
productname varchar(20),
quantity int);

insert into orders values(1,1,'2022-8-12','mouse',2)
insert into orders values(2,2,'2023-9-11','keyboard',3)
insert into orders values(3,3,'2021-8-12','cpu',4)
select * from orders

select  orderid,custid,orderdate,productname,quantity
from orders
where custid in
(select custid from customers1 where city='nagpur')


select orderid,custid,orderdate,productname,quantity
from orders
where custid in
(select custid from customers1 where city='bhopal')

