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

DECLARE 
    @product_name VARCHAR(MAX), 
    @list_price   DECIMAL;

DECLARE cursor_product CURSOR
FOR SELECT 
        productname, 
        listprice
    FROM 
        product22;
		OPEN cursor_product;

		FETCH NEXT FROM cursor_product INTO 
    @productname, 
    @listprice;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @product_name + CAST(@list_price AS varchar);
        FETCH NEXT FROM cursor_product INTO 
            @product_name, 
            @list_price;
    END;
CLOSE cursor_product;
DEALLOCATE cursor_product;



DECLARE 
    @product_name2 VARCHAR(MAX), 
    @list_price2   DECIMAL;

DECLARE cursor_product2 CURSOR
FOR SELECT 
        productname, 
        price
    FROM 
        product;

OPEN cursor_product2;

FETCH NEXT FROM cursor_product2 INTO 
    @product_name2, 
    @list_price2;
PRINT @product_name2 + CAST(@list_price2 AS varchar);
WHILE @@FETCH_STATUS = 0
    BEGIN
       
        FETCH NEXT FROM cursor_product2 INTO 
            @product_name2, 
            @list_price2;
            
          PRINT @product_name2 + CAST(@list_price2 AS varchar);
    END;

CLOSE cursor_product2;

DEALLOCATE cursor_product2;



