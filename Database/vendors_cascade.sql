create table vendors(vendors_id int identity primary key,group_name varchar(50)not null)
create table vendordetails(vendor_id int identity primary key,vendor_name varchar(20)not null,group_id int not null)
drop table vendordetails
create table  vendors1 (vendors1_id INT IDENTITY PRIMARY KEY,
        vendors1_name VARCHAR(100) NOT NULL,
        group_id INT NOT NULL,
        constraint fk2  foreign key(group_id)
        references (group_id)
        on delete cascade

        