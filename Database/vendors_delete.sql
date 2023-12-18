create table vendors(vendors_id int identity primary key,group_name varchar(50)not null)
create table vendordetails(vendor_id int identity primary key,vendor_name varchar(20)not null,group_id int not null)
drop table vendors
create table vendors(vendors_id int identity primary key,vendors_name varchar(100) not null,group_id int,
constraint fk_group foreign key(group_id) references vendors(vendors_id)
on delete  no action)
select* from vendordetails
insert into vendors values('amit',1)
select * from vendors
delete from vendordetails where group_id=1
insert into vendors values('amit',1)
delete from vendordetails where group_id=1
drop table vendors