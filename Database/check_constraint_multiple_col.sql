create table products1(
products_id int identity primary key,
products_name varchar(20) not null,
unit_price dec(10,2)  check(unit_price>0),
discounted_price dec(10,2)check(discounted_price>0), 
check(unit_price>discounted_price));
insert into products1 values('rice',100,20)
insert into products1 values('rice',200,30)
insert into products1 values('jowar',300,100)
insert into products1 values('bajra',400,50)
select * from products1
sp_help product4
create table product4(
product_id int identity primary key,product_name varchar(20)not null,
unit_price dec(10,2) ,
discounted_price dec(10,2),
check(unit_price>0),
check(discounted_price>0 and discounted_price<unit_price));
insert into product4 values('mouse',500,10)
insert into product4 values('pen drive',400,20)
insert into product4 values('usb datacable',300,5)
select * from product4
 drop table product4
     


	 create table prod(prod_id int identity primary key,prod_name varchar(20) not null,
	 unit_price dec(10,2));
	 alter table prod
	 add constraint positive_price check(unit_price>0);
	 insert into prod values('sugar',500)
	 insert into prod values('wheat',300)
	 select * from prod

	 drop table prod

