create table TableProductCategory(
Product_Category_ID int primary key,
Product_Type_Name varchar(500),
Product_GST_Id int)

insert into TableProductCategory values(1001,'computers',602),(1002,'mobile',604),
(1003,'printers',603),(1004,'AC and fridge',601)

select * from TableProductCategory

create table TableProduct(
ProductID int primary key,
ProductName varchar(500),
product_category_id int,
product_price int,
foreign key(product_category_id)references TableProductCategory(product_category_id))

insert into TableProduct values(201,'Apple',1002,4000),(211,'Lenevo',1002,25000),(212,'Samsung',1003,50000),
(213,'IFB',1004,20000),(214,'LG',1004,30000),(215,'Sony',1001,60000)
select * from TableProductCategory


create table TableProductGSTDetails(
Product_Gst_ID int primary key,
Gst_Detail_Name varchar(500),
CGST Decimal,
SGST Decimal,
IGST Decimal,
foreign key(Product_GST_ID)references TableProductCategory(Product_GST_ID))







