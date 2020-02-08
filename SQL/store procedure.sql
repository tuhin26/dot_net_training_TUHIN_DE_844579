--store procedures and functions
 
create procedure getcustomersbycountry
(@counrty varchar(30))
as
select customerid,contactname,companyname,address,country from customers where Country =@counrty;
go

execute getcustomersbycountry 'usa';

create procedure getproductbycategoryid
(@categoryid int)
as
select p.productid,p.productname,p.unitprice,p.quantityperunit,c.categoryid,c.Categoryname from
 products p inner join categories c on p.categoryid=c.categoryid and c.categoryid =@categoryid;
go


--declaring local variable

declare @country as varchar(30);
set @country ='uk';
select* from customers where Country = @country ;

alter procedure gettotalordersbydates
(@date1 date,@date2 date, @countorder int output)
as
select @countorder =count(OrderId) from Orders where orderdate between @date1 and @date2;
go
declare @count as int
declare @date1 as date ,@date2 as date
set @date1='01/01/1997'
set @date2='12/31/1998'
execute gettotalordersbydates @date1,@date2,@count  output;
print 'total number of order placed ' + convert(varchar(10), @count);
print getdate();

--creating function

--by default this function is stored inside the default schema known as dbo which stands for database owner

--scaler function

alter function multi(@n1 int , @n2 int)  
returns bigint
as 
begin
declare @prod as bigint

Set @prod = @n1*@n2;
return @prod
end

select dbo.multi(76,87) as product

--table valued function

create function getcustomers(@country  varchar (30))
returns table 
as
return select * from Customers where country = @country
go



create function getallproductbycategoryid(@categoryid int)
returns table
 as
 return select p.productid,p.productname,p.unitprice,p.quantityperunit,c.categoryid,
 c.Categoryname from products p inner join categories c on p.categoryid=c.categoryid and
  c.categoryid =@categoryid; 
 select * from dbo.getallproductbycategoryid(5);

 --subqueries
 --1. a subquery is used as a part of amain query ,and the value return
 -- from the sub query will be used bye the main query for its execution
 --2. sometime a subquery is used in-place of join
 -- operations to combine two table , but joins are performed over subqueries because of their efficiency

 select productid,productname,unitprice ,quantityperunit,categoryid 
 from products where unitprice >(select avg(unitprice)from products)order by UnitPrice; 

 select orderid,customerid,employeeid,orderdate,shippeddate from orders where orderid =(select
  orderid from orders where employeeid =5 and customerid='vinet')
  

  --correlated subqueries

  --1.a correlated subquery does not return any data back to the main query. 
  --but it alwasy return a boolean value of either 'true' or "false"
  --and accordingly the main query gets executed if it recieves a boolean value of true. otherwise, 
  --the main query ewill not be executed

  --2. these correlated subqueries make use of EXISTS or NOT EXISTS
  --operators as a part of main query 


  select customerid,companyname, address,country from customers where exists
   (select contactname from customers where country ='usa' )

    select customerid,companyname, address,country from customers where not exists
   (select contactname from customers where country ='india' )

    select customerid,companyname, address,country from customers where exists
   (select contactname from customers where country in('usa','uk') )

