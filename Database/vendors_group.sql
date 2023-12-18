create table vendors_group(group_id int identity primary key,group_name varchar(100) not null);
create table vendors(vendors_id int identity primary key,vendors_name varchar(100)not null,group_id int not null);
select * from vendors_group
insert into vendors values('amit',123)
select* from vendors

drop table vendors
create table vendors(vendors_id int identity primary key,vendors_name varchar(100)not null,group_id int not null,
constraint fk_group foreign key(group_id) references  vendors_group(group_id))
select* from vendors_group
insert into vendors(vendors_name,group_id) 
values('amit',1)
insert into vendors_group values('mkpits')
select * from vendors_group
insert into vendors(vendors_name,group_id) 
values('amit',1)
select * from vendors_group
select * from vendors

