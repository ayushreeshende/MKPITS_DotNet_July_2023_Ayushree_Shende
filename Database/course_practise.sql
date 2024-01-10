create Table TableCity(
cityid int identity primary key,
cityname varchar(40)not null,
stateid varchar(40)not null,
foreign key(stateid)references TableState(stateid))

insert into TableCity values(1001,'guntur',101),(1002,'visakhapatnam',101),(1004,'amritsar',102),
(1009,'San Diego',103),(1010,'jacksonville',104),(1005,'jalandhar',102)
select * from TableCity

create table TableNation(
NationId int primary key,
NationName varchar(20)not null)

insert into TableNation values(1,'india'),(2,'United Nation'),
(3,'Nepal'),(4,'Sri Lanka')
select * from TableNation

create table TableState(
stateid int primary key,
statename varchar(40)not null,
NationId int,
foreign key(Nationid)references TableNation(NationId))

insert into TableState values(101,'andhra pradesh',1),(102,'punjab',1),(103,'california',2),
(104,'florida',2),(105,'koshi',3),(106,'colombo',4),(108,'ratnapura',4)
select * from TableState

create table TableCourseRegDetail(
CourseRegId int primary key,
CategoryId int,
FullName varchar(1500),
GenderId varchar(20))

select * from TableCourseRegDetail

create table TableFeeDetail(FeeId int primary key,
CourseRegId int,
TotalAmount Decimal,
MiniPer Decimal,
PaidAmount Decimal,
BalanceAmount Decimal,
PaidDate decimal,
foreign key(CourseRegId)references TableCourseRegDetail(CourseRegId))

select * from TableFeeDetail


create table TableRegAddress(
RegAddressId int primary key,
CourseRegId int,NationId int,CityId int,StateId int,
foreign key(CourseRegId)references TableFeeDetail(CourseRegId),
foreign key(NationID)references TableNation(NationId),
foreign key(CityId)references TableCity(CityId),
foreign key(StateId)references TableState(StateId))

select * from TableRegAddress









