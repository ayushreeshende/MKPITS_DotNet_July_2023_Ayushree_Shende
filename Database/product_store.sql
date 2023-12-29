create table TableProductGSTDetails(
Product_Gst_ID int primary key,
Gst_Detail_Name varchar(500),
CGST Decimal,
SGST Decimal,
IGST Decimal)

insert into TableProductGSTDetails values(11,'laptop',34.0,45.00,60.00)
insert into TableProductGSTDetails values(12,'mouse',60.00,70.00,80.00)
insert into TableProductGSTDetails values(13,'speaker',33.00,78.00,50.00)
insert into TableProductGSTDetails values(14,'printer',56.00,45.00,90.00)
insert into TableProductGSTDetails values(15,'keyboard',22.00,94.00,61.00)
select * from TableProductGSTDetails


create table TableProductCategory(
Product_Category_ID int primary key,
Product_Type_Name varchar(500),
Product_GST_Id int,
foreign key (Product_GST_ID)references TableProductGSTDetails
(Product_GST_ID))
select * from TableProductCategory
insert into TableProductCategory values(1,'olive',11)
insert into TableProductCategory values(2,'coloresense',12)
insert into TableProductCategory values(3,'lakme',13)
insert into TableProductCategory values(4,'hydroni',14)
select * from TableProductCategory

create table TableProduct(
ProductID int primary key,
ProductTypeID int,
ProductName varchar(500))

insert into TableProduct values(33,40,'knife')
insert into TableProduct values(44,50,'spoon')
insert into TableProduct values(55,60,'bowl')
select * from TableProduct

create table TableInvoiceDetails(
Invoice_Detail_ID int primary key,
Customer_Name varchar(500),
Customer_Contact varchar(15),
Product_Category_Id int foreign key(Product_Category_ID) references TableProductCategory(Product_Category_ID),
ProductID int foreign key(ProductID)references TableProduct(ProductID),
Residental_Type_ID int,
Invoice_Date DateTime,
Quantity Decimal,
price Decimal,
CGST Decimal,
SGST Decimal,
IGST Decimal,
CGST_Value Decimal,
SGST_Value Decimal,
IGST_Value Decimal,
Total_Amount Decimal)


insert into TableInvoiceDetails values(9,'amit','678890',1,33,2,'2022-7-9',
20.00,1000.00,10.00,20.00,30.00,21.00,31.00,15.00,1500.00)
insert into TableInvoiceDetails values(7,'arjun','786433',2,44,3,'2023-8-12',
30.00,2000.00,11.00,21.00,31.00,22.00,35.00,20.00,1000.00)
select * from TableInvoiceDetails






