create table orders11(orderid int primary key, orderdate date, productname varchar(20)not null,
customername varchar(20)not null, quantity int)
insert into orders11 values(1,'1/1/2009','samosa','amit',2)
insert into orders11 values(1,'1/1/2009','pakoda','amit',3)
insert into orders11 values(1,'1/1/2009','kachori','amit',1)
insert into orders11 values(2,'2/2/2009','samosa','ravi',2)
insert into orders11 values(2,'2/2/2009','kachori',	'ravi',	2)
select * from orders11

create table orders111 
(orderid int,	orderdate date, customername varchar(20))	 
insert into orders11 values(1,'1/1/2009','amit')
insert into orders11 values(2,'2/2/2009','ravi')
select * from orders111

create table ordersdetails124 (orderid int foreign key,productname varchar(20)not null,  quantity int)
insert into orders11 values(1,'samaso',2)
insert into orders11 values(1,'pakoda',3)
insert into orders11 values(1,'kachori',1)
insert into orders11 values(2,'samosa',	2)
insert into orders11 values(2,'kachori',2)
select * from ordersdetails124
