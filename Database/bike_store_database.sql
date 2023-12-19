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
drop table store

create table staff(staff_id int identity primary key,
first_name varchar(20)
last_name
email
phnno
active
store_id
manager_id
