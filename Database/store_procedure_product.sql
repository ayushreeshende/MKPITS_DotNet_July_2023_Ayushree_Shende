create table product22(productid int,
productname varchar(20)not null,
brandid varchar(20)not null,
categoriesid varchar(20)not null,
modelyear varchar(20)not null,
listprice  dec(10,2));

insert into product22 values(1,'mouse',1234,1,2023,2900)
insert into product22 values(2,'keyboard',6754,2,2022,6700)
insert into product22 values(3,'cpu',33009,3,2020,8900)
insert into product22 values(4,'printer',4896,4,2024,9080)
select * from product22
create procedure prod1
as 
begin
select * from product22
end;
exec prod1

create proc mprod2
	as
	begin
	select * from product22 where modelyear='2020'
	end
	
	exec mprod2


alter procedure mprod2
as
begin
select productname,listprice from product22
order by listprice
end;

exec mprod2
