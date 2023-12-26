create table product111(product_id int identity primary key,
product_region varchar(20)not null,
product_name varchar(20)not null,
product_year varchar(20)not null,
product_quantity varchar(20)not null,
product_price int);
insert into product111 values('east','computer',2022,100,5000)
insert into product111 values('north','keyboard',2023,200,6000)
insert into product111 values('south','computer',2024,800,7000)
insert into product111 values('west','mouse',2021,600,89000)
insert into product111 values('north','keyboard',2025,800,7800)
select * from product111
 
 SELECT product_name, product_quantity, product_Price  
    from product111 
    WHERE product_price = (  
    SELECT Max(product_price) AS "Minimum Quantity"   
    FROM product111);  

	SELECT Product_name, MIN(product_price) AS "Minimum price"   
    FROM Product111 
    GROUP BY Product_name  
    HAVING MIN(product_price)>300