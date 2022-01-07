--Select çalıştırmak istenen kodu seçer (bir Tablodur)
--ANSII
Select ContactName,CompanyName,City from Customers 


Select * From Customers where City='Berlin'

--case insensitive (büyük küçük harf duyarsız)

Select * From Products where CategoryID =1 or CategoryID= 3


 Select * From Products where CategoryID =1 and UnitPrice>=10

 --                     (sırala) defoultu asc(Ascending=Artan)dır   Azalmasını istersek desc(descending)
 select * From Products where CategoryID=1 order by UnitPrice  desc
  
   
 select count(*) from Products where CategoryID=1


 Select CategoryID, count(*) from Products group by CategoryID having count(*)<10


 select Products.CategoryID, Products.ProductName, Products.UnitPrice,Categories.CategoryName 
 from Products inner join Categories on Products.CategoryID  = Categories.CategoryID 
 where Products.UnitPrice>10


 --DTO Data Transformation Object

 Select * from Products p left join [Order Details] od on p.ProductID= od.ProductID  


 Select *from Customers c left join Orders o on c.CustomerID = o.CustomerID 
 where o.CustomerID is null





