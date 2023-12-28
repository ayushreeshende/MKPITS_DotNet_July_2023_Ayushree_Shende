create table teacher112(teacher_id int primary key,
subject varchar(20)not null,
teacher_age int)

insert into teacher112 values(1,'physics',21)
insert into teacher112 values(2,'chemistry',22)
insert into teacher112 values(3,'bio',23)
insert into teacher112 values(4,'physics',22)
insert into teacher112 values(5,'maths',31)
insert into teacher112 values(6,'eng',33)
select * from teacher112


create table teacher_detail1(teacher_id int primary key,teacher_age int)
insert into teacher_detail1 values(2,22)
insert into teacher_detail1 values(3,23)


create table teacher_subjects(teacher_id int,subject varchar(20),
constraint tea foreign key(teacher_id) references teacher_detail1(teacher_id))


insert into teacher_subjects values(2,'chemistry')
insert into teacher_subjects values(3,'bio')

select * from teacher_detail1
select * from teacher_subjects

