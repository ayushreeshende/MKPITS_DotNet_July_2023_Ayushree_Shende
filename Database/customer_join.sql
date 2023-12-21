create table cust1(cust_id int identity primary key,cust_name varchar(20)not null,telno varchar(20));
insert into cust1 values('amit',66788990)
insert into cust1 values('sumit',785322)
insert into cust1 values('achal',88009921)
insert into cust1 values('mahi',9021356)
insert into cust1 values('shruti',8911222)
insert into cust1 values('ani',89065)
insert into cust1 values('anu',8009900)
select * from cust1


create table orders(order_id int identity primary key,order_date date,cust_id int ,
product_name varchar(20),quantity int);

insert into orders values('2022-6-9',1,'mouse',3)
insert into orders values('2023-9-10',2,'keyboard',5)
insert into orders values('2021-8-1',3,'scanner',3)
insert into orders values('2020-9-15',4,'printer',7)
insert into orders values('2019-8-30',5,'hd',6)
select * from orders

SELECT cust.custid,cust.custname,  orders.order_id,orders.order_date,orders.product_name
    FROM cust 
    INNER JOIN orders  
    ON cust.custid = orders.cust_id; 
	
	SELECT cust.custid,cust.custname,  orders.order_id,orders.order_date,orders.product_name
    FROM cust 
	cross join orders

	SELECT cust.custid,cust.custname,  orders.order_id,orders.order_date,orders.product_name
    FROM cust 
	left outer join orders
	 ON cust.custid = orders.cust_id;

	 SELECT cust.custid,cust.custname,  orders.order_id,orders.order_date,orders.product_name
    FROM cust 
	right outer join orders
	 ON cust.custid = orders.cust_id;

	 SELECT cust.custid,cust.custname,  orders.order_id,orders.order_date,orders.product_name
    FROM cust 
	full outer join orders
	 ON cust.custid = orders.cust_id;

	 drop table customer2

	 create table customer2 (custid int ,custname varchar(20),city varchar (100))
	 insert into customer2 values(1,'prajwal','nasik')
insert into customer2 values(1,'Prajwal','pune')
insert into customer2 values(1,'prajwal','pune')
insert into customer2 values(4,'pari','nasik')
insert into customer2 values(4,'pari','nagpur')

select * from customer2

SELECT S1.custname, S2.custid, S2.city  
    FROM customer2 S1, customer2 S2  
    WHERE S1.custid <> S2.custid AND S1.city = S2.city  
    ORDER BY S2.city;  