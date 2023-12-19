create table person(person_id int identity primary key,
first_name varchar(20)not null,
last_name varchar(20)not null,
emailid varchar(20)unique);
insert into person values('amit','barve','amu@gmail.com')
insert into person values('sumit','koche','sumit123@gmail.com')
insert into person values('kumud','shahu','shhau@gmail.com')
select * from person
drop table person

sp_help persons

create table persons(
person_id int identity primary key,
first_name varchar(20)not null,
last_name varchar(20)not null,
email varchar(20),
CONSTRAINT unique_email UNIQUE(email));



insert into persons values('achal','kumbhare','achal@gmail.com')
insert into persons values('bhagu','shahu','bhagu34@gmail.')
select * from persons

CREATE TABLE person_skills (
    id INT IDENTITY PRIMARY KEY,
    person_id int,
    skill_id int,
    updated_at DATETIME,
    UNIQUE (person_id, skill_id));
insert into person_skills values(111,19,'2021-12-12')
insert into person_skills values(198,14,'2021-12-12')
insert into person_skills values(112,12,'2021-12-12')
insert into person_skills values(156,11,'2021-12-12')
select * from person_skills