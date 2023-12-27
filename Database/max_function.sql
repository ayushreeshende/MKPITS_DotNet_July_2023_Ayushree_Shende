create table product121(product_id int identity primary key,
product_region varchar(20)not null,
product_name varchar(20)not null,
product_year varchar(20)not null,
product_quantity varchar(20)not null,
product_price int);
insert into product121 values('east','computer',2022,100,5000)
insert into product121 values('north','keyboard',2023,200,6000)
insert into product121 values('south','computer',2024,800,7000)
insert into product121 values('west','mouse',2021,600,89000)
insert into product121 values('north','keyboard',2025,800,7800)
select * from product121
 
 

    SELECT Product_name,product_quantity, product_Price  
    FROM Product121  
    WHERE product_quantity = (  
    SELECT MAX(product_quantity) AS "Maximum Quantity"   
    FROM product121);   
	
	SELECT product_name, max(product_price) AS "maximum price"   
    FROM Product121 
    GROUP BY Product_name  
    HAVING Max(product_price)>300
	
	