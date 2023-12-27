create table products13(productid int,productname varchar(20),productprice int,productquantity int)
insert into products13 values(1,'rice',500,5)
insert into products13 values(2,'wheat',200,6)
insert into products13 values(3,'jowar',120,7)
insert into products13 values(4,'pulses',1200,8)
insert into products13 values(5,'moong',230,9)
insert into products13 values(6,'sugar',760,10)
insert into products13 values(7,'chana',800,11)
select * from products13
create function f1()
returns table
as
return (select * from product13)
select * from f1()