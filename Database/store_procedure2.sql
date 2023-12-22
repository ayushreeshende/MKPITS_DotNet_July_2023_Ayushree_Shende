create table product222(productid int,
productname varchar(20)not null,
brandid varchar(20)not null,
categoriesid varchar(20)not null,
modelyear varchar(20)not null,
listprice  dec(10,2));

insert into product222 values(1,'mouse',1234,1,2023,2900)
insert into product222 values(2,'keyboard',6754,2,2022,6700)
insert into product222 values(3,'cpu',33009,3,2020,8900)
insert into product222 values(4,'printer',4896,4,2024,9080)
select * from product222

create proc nprod3(@minlistprice as decimal(10,2))
as
begin
select * from product222
where listprice > @minlistprice
order by listprice
end;
exec nprod3 120
exec nprod3 2022
