create table users1
(
id int primary key identity,
username varchar(30)not null,
password varchar(30)not null,
date_register Date null,
)
 select * from users1

 create table employees
 (
 id int primary key identity(1,1),
 employees_id varchar(20)null,
 full_name varchar(20)null,
 gender varchar(20)null,
 contact_no varchar(20)null,
 image varchar(max)null,
 salary int null,
 insert_date date null,
 update_date date null,
 delete_date date null)
 select * from employees