create table products(product_id int identity primary key,product_name varchar(20),product_price int,product_quantity int)
insert into products values('mouse',500,1)
insert into products values('keyboard',1000,2)
insert into products values('cpu',1500,5)
insert into products values('monitor',2000,7)
insert into products values('scanner',3000,6)
insert into products values('printer',7000,9)
select * from products
update products set product_price=5000
where product_name='monitor'

update products set product_price=300
where product_name='keyboard'and product_price=1000

delete from products where product_name='cpu'
truncate table products
insert into products values('hd',70000,1)
insert into Products values('pd',20000,3)


alter table products
alter column product_price dec(10,2)

sp_rename 'products','product123'
