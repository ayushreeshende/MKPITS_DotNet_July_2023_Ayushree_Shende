create table department1(department_id int primary key,
departmentname varchar(20)not null
,manager_id varchar(20)not null,
location_id int);
insert into department1 values(10,' Administration' ,200 , 1700) 
         insert into department1 values( 20,' Marketing', 201,1800 )
      insert into department1 values      (30,'Purchasing', 114 ,1700 )
            insert into department1 values(40,' Human Resources', 203, 2400) 
    insert into department1 values        (50,' Shipping', 121, 1500) 
      insert into department1 values      (60,' IT' , 103 , 1400)
        insert into department1 values    (70,' Public Relations', 204,  2700 )
         insert into department1 values   (80,' Sales', 145 , 2500)
         insert into department1 values  ( 90, ' Executive', 100, 1700)
     insert into department1 values      (100,  'Finance',   108 , 1700 )
       insert into department1 values    (110, ' Accounting', 205 ,1700 )
      insert into department1 values     (120,  'Treasury',  0 , 1700 )
       insert into department1 values    (130, 'Corporate Tax', 0, 1700) 
	   select * from department1
