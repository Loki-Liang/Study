/*create Person
create table Person
(
Id int primary key identity,
LastName varchar(20),
FirstName varchar(20),
Address varchar(20),
City varchar(20)
)
*/

/*Insert into
insert into dbo.Person(LastName,FirstName,Address,City) 
values ('Adams','John','Oxford Start','London');
insert into dbo.Person(LastName,FirstName,Address,City) 
values ('Bush','George','Fitrh Avenue','New York');
insert into dbo.Person(LastName,FirstName,Address,City) 
values ('Carter','Thomas','Changan Street','Beijing');
*/

--Top
--insert into dbo.Person(LastName,FirstName,Address,City) 
--values ('Obama','Barack','Pennsylvania Avenue','Washington');
--select top 6 * from Person;

--Top Percent
--select Top 50 percent * from Person;

--Like
/*
select * from Person
where City like 'N%';

select * from Person
where City like '%ond%';

select * from Person
where City not like '%on%';
*/

--Charlist
/*
select * from Person
where City like '[ALN]%';
select * from Person
where City not like '[ALN]%';
*/

--In and between...and...
-- select * from Person where id in(1,2,3);
 --select * from Person
 --where id between 1 and 4;
 --select * from Person
 --where LastName not between 'Adams' and 'Carter';

 --Alias
--create table Orders
--(
--Id_O int primary key identity,
--OrdeNo varchar(10),
--Id_P int
--)
--insert into Orders(OrdeNo,Id_P) 
--values ('77895',3);
--insert into Orders(OrdeNo,Id_P) 
--values ('44678',3);
--insert into Orders(OrdeNo,Id_P) 
--values ('22456',1);
--insert into Orders(OrdeNo,Id_P) 
--values ('24562',2);
--insert into Orders(OrdeNo,Id_P) 
--values ('34764',65);

--select Person.LastName,person.firstname,orders.OrdeNo
--from Person,Orders
--where Person.Id=Orders.id_p;

--join
--select Person.LastName,Person.FirstName,Orders.OrdeNo
--From Person inner join Orders
--on Person.Id=Orders.Id_P
--ORDER BY Person.LastName;

--UNion
--SELECT Person.Id FROM Person
--UNION 
--SELECT Orders.Id_O FROM Orders;

--SELECT INTO
SELECT * INTO Persons
from Person;