create table nobel_prize_winner(year int,subject varchar(30),winner varchar(50),country varchar(50),category varchar(40))
insert into nobel_prize_winner values(1970 ,'Physics', 'Hannes Alfven',' Sweden','Scientist')
insert into nobel_prize_winner values(1950 ,'Physics',' Louis Neel',' France',' Scientist')
insert into nobel_prize_winner values(1972, 'Chemistry',' Luis Federico Leloir',' France',' Scientist')
insert into nobel_prize_winner values(1970 ,'Physiology', 'Ulf von Euler ', 'Sweden', 'Scientist')
insert into nobel_prize_winner values(1973 ,'Physiology',  'Bernard Katz','  Germany','   Scientist')
insert into nobel_prize_winner values(1970 ,'Literature ', ' Aleksandr Solzhenitsyn',' Russia',' Linguist')
insert into nobel_prize_winner values(1970 ,'Economics',   'Paul Samuelson ',' USA','doctor')
select * from nobel_prize_winner
select * from nobel_prize_winner where year=1970
select * from nobel_prize_winner where subject ='literature'and year=1970

select year,subject from nobel_prize_winner where winner='Bernard Katz'
select year,winner from nobel_prize_winner where subject='physics' and year=1950
select *from nobel_prize_winner where year between'1965 ' and '1975' and subject='chemistry'


select * from nobel_prize_winner where subject='physics' and year <1972

select * from nobel_prize_winner where winner like '%lo%'













