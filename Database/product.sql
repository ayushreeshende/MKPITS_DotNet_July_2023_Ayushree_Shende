create table products(productid int,productname varchar(20),productprice int,productquantity int)
insert into products values(1,'rice',500,5)
insert into products values(2,'wheat',200,6)
insert into products values(3,'jowar',120,7)
insert into products values(4,'pulses',1200,8)
insert into products values(5,'moong',230,9)
insert into products values(6,'sugar',760,10)
insert into products values(7,'chana',800,11)
select * from products
select top 2 productname from product
 select top 3 * from product
 select top 3 productname from product order by productprice desc
 select top 50 PERCENT productname productprice from product order by productprice desc

