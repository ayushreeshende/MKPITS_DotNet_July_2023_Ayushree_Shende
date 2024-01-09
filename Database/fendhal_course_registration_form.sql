create table TableCourseRegDetail(
 CourseRegId int identity primary key,
 CategoryID int,
 FullName varchar(1500),
 GenderId int)


select * from TableCourseRegDetail


create table TableFeeDetail(FeeID int identity primary key,
CourseRegID int,
TotalAmount Decimal,
MiniPER decimal,
PaidAmount Decimal,
BalAmount Decimal,
PaidDate DateTime,
foreign key (CourseRegID)references TableCourseRegDetail(CourseRegID))


select * from TableFeeDetail

create table TableRegAddress(
RegAddressId int identity primary key,
CourseRegID int,NationID int,StateID int,CityID int,
foreign key(CourseRegID)references TableCourseRegDetail(CourseRegID),
foreign key(NationID)references TableNation(NationID),
foreign key (StateID) references TableState(StateID),
foreign key(CityID)references TableCity(CityID))

select * from TableRegAddress



