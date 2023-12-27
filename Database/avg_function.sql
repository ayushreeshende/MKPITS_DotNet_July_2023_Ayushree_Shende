create table employee11(id int identity primary key,
sname varchar(20)not null,
occupation varchar(20)not null,
working_date date not null,
working_hours int,
salary int);
insert into employee11 values('jhon','manager','2023-9-7',6,50000)
insert into employee11 values('smith','clerk','2024-9-1',8,7000)
insert into employee11 values('ronaldo','player','2022-8-10',9,67000)
insert into employee11 values('pandey','cricketer','2022-9-11',9,89000)
insert into employee11 values('lauries','poet','2020-11-2',2,7000)
insert into employee11 values('tagore','writer','2017-12-12',2,4000)
insert into employee11 values('murli','manager','2018-1-12',9,84000)
select * from employee11

  SELECT avg(working_hours) AS "Average Working Hours"   
    FROM employee11
    WHERE occupation = 'manager'   
	drop table employee11