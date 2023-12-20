create table  store(store_id int identity primary key,
store_name varchar(20)not null,
phnno varchar(20),
email_id varchar(20),
street varchar(20),
city varchar(20),
state varchar(30),
zip_code varchar(20));
insert into store values('sahil',4566778,'sahil@gmail.com','amravati','nagpur','maharashtra',440027)
insert into store values('amit',56788999,'amit@gmail.com','chinch','akola','andhra pradesh',440026)
insert into store values('harshu',54901245,'harshu@gmail.com','kali','buldhana','uttar pradesh',4789590)
select * from store
                                                                                                                            
create table staff(staff_id int identity primary key,
first_name varchar(20)not null,
last_name varchar(30)not null,
email varchar(20)not null,
phnno varchar(20)not null,
active tinyint not null,
store_id int not null,
manager_id int,
foreign key(store_id)
references store(store_id)
on delete cascade on update cascade)
insert into staff values('rehana','shekh','rehana@gmail.com',567899,2,1,5)
insert into staff values('shylok','khan','shylok@gmail.com',5319900,1,2,3)
insert into staff values('amruta','chiillarvar','amruta@gmail.com',89022211,3,3,7)
select * from staff


create table category(category_id int identity primary key,
category_name varchar(20)not null)
insert into category values('pulser')
insert into category values('honda')
insert into category values('activa')
select * from category


create table brand(brand_id int identity primary key,
brand_name varchar(20)not null)
insert into brand values('shine')
insert into brand values('honda')
select * from brand


create table product5(product_id int identity primary key,
product_name varchar(20)not null,
brand_id int not null,
category_id int not null,
model_year smallint not null,
list_price dec(10,2)not null,
FOREIGN KEY (category_id) 
 REFERENCES category (category_id) 
  ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (brand_id) 
  REFERENCES brand (brand_id) 
 ON DELETE CASCADE ON UPDATE CASCADE);
insert into product5 values('olive',1,1,2023,59)
insert into product5 values('lakme',2,2,2022,70)
select * from product5


create table customer5(customer_id int identity primary key,
first_name varchar(20)not null,
last_name varchar(20)not null,
phnno varchar(20),
email varchar(20)not null,
city varchar(220),
street varchar(320),
state varchar(30),
zip_code varchar(20));

insert into customer5 values('suhani','meshram',4325678,'suhani@gmail.com','nagpur','akola','maharashtra',440027)
insert into customer5 values('rashmi','nagdevte',6788899900,'rashmi@gmail.com','buldhana','amti','up',440026)
select * from customer5



create table orders3(order_id int identity primary key,
customer_id int ,
order_status tinyint not null,
order_date date not null,
required_date date not null,
shipped_date date ,
store_id int not null,
staff_id int not null,
foreign key (customer_id)
references customer5(customer_id)
on delete cascade on update cascade,
foreign key(store_id)
references store(store_id)
ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (staff_id) 
        REFERENCES staff (staff_id) 
        ON DELETE NO ACTION ON UPDATE NO ACTION);

		insert into orders3 values(1,1,'2022-8-12','2022-9-11','2018-8-8',1,1)
		insert into orders3 values(2,2,'2019-6-13','2016-1-2','2019-5-5',2,2)
		select * from orders3



		create table order_items(order_id int,
		item_id int ,
		product_id int not null,
		quantity int not null,
		list_price dec(10,2)not null,
		discount decimal(4,2)not null default 0,
		primary key(order_id,item_id),
		FOREIGN KEY (order_id) 
        REFERENCES orders3 (order_id) 
        ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (product_id) 
        REFERENCES product5 (product_id) 
        ON DELETE CASCADE ON UPDATE CASCADE);

		insert into order_items values(1,1,1,40,100,20)
		insert into order_items values(2,2,2,50,200,10)
		select * from order_items



		create table stocks(store_id int,
		product_id int,
		quantity int,
		primary key (store_id,product_id),
		foreign key(store_id)
		references store(store_id)
		on delete cascade on update cascade,
		foreign key (product_id) 
        REFERENCES product5 (product_id) 
        ON DELETE CASCADE ON UPDATE CASCADE);

		insert into stocks values(1,1,40)
		insert into stocks values(2,2,590)
		select * from stocks


		select * from store
		select * from staff
		select * from category
		select * from brand
		select * from product5
		select * from customer5
		select * from orders3
		select * from order_items
		select * from stocks


		                                                                                     