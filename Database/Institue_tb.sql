create table TableNation(
NationID int primary key,
NationName varchar(20))
insert into TableNation values(1,'India')
insert into TableNation values(2,'Hindustan')
insert into TableNation values(3,'Asia')
insert into TableNation values(4,'Europe')
select * from TableNation

create table TableState(
StateID int primary key,
NationId int,StateName varchar(500),
 foreign key (NationID)
 references TableNation(NationID))

 insert into TableState values(1,1,'Maharashtra')
 insert into TableState values(2,2,'Asia')
 insert into TableState values(3,3,'Europe')
 select * from TableState

 create table TableCity(
 CityId int primary key,
 StateID int,CityName varchar(500)
 foreign key(StateID)
 references TableState(StateID))

 insert into TableCity values(1,1,'Nagpur')
 insert into TableCity values(2,2,'Bhopal')
 insert into TableCity values(3,3,'Raipur')
 select * from TableCity

 create table TableCourseRegDetail(
 CourseRegId int primary key,
 CategoryID int,
 FullName varchar(1500),
 GenderId int)

 insert into TableCourseRegDetail values(11,1,'ArpitaGadling',1)
 insert into TableCourseRegDetail values(12,2,'AmrutaMeshram',2)
 insert into TableCourseRegDetail values(13,3,'HarshDhawane',3)
 insert into TableCourseRegDetail values(14,4,'RajFender',4)
select * from TableCourseRegDetail

create table TableRegAddress(
RegAddressId int primary key,
CourseRegID int,NationID int,StateID int,CityID int,
foreign key(CourseRegID)references TableCourseRegDetail(CourseRegID),
foreign key(NationID)references TableNation(NationID),
foreign key (StateID) references TableState(StateID),
foreign key(CityID)references TableCity(CityID))

insert into TableRegAddress values(1,11,1,1,1),(2,12,2,2,2)
select * from TableRegAddress

create table TableFeeDetail(FeeID int,
CourseRegID int,
TotalAmount Decimal,
MiniPER decimal,
PaidAmount Decimal,
BalAmount Decimal,
PaidDate DateTime,
foreign key (CourseRegID)references TableCourseRegDetail(CourseRegID))

insert into TableFeeDetail values(1,11,2000,500,400,100,'2023-7-9')
insert into TableFeeDetail values(2,12,3000,1000,500,200,'2024-12-10')
select * from TableFeeDetail

select * from TableNation
select * from TableState
select * from TableCity
select * from TableCourseRegDetail
select * from TableRegAddress
select * from TableFeeDetail 




