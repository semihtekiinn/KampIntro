--Select
--ANSII
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City='London'

 --case insensitive - büyük küçük harf duyarsız
select * from Products where categoryId=1 or CategoryID=3
-- <> işareti 'farklı' anlamındadır . Yani UnitPrice<>10 yazsaydım 
-- 10dan farklı olanları getir anlamına gelecekti.

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by CategoryID, ProductName -- Önce kategori Id yi sırala, sonra productname i sırala . 
--Yani categoryId leri 1 olanların içinde isim sırası yap.


select * from Products order by UnitPrice 
select * from Products order by UnitPrice asc   --ascending ( artan ) demek . Hiç bir şey yazmasanda bu çalışır. Yani default hali bu . yukarıdaki satırla aynı anlamda
select * from Products order by UnitPrice desc  --descending ( azalan - düşen ) demek.    
-- (a)sc artanın a sı , (d)esc düşenin d si olarak aklında kalsın .

select * from Products where CategoryID=1 order by UnitPrice desc -- categoryId si 1 olanların içinde fiyatı azalan olarak sırala .

select count(*) from Products -- count (saymak) - Products tablosunda kaç tane satır olduğunu yazdırır.
 
select count(*) from Products where CategoryID=2 -- 2 numaralı kategoride kaç ürün olduğunu yazdırır.

select count(*) Adet from Products where CategoryID=2 -- Sütun ismini Adet olarak değiştirir.

select CategoryID from Products group by CategoryID -- group by dan sonra yazılan şeyi select'ten sonrada yazmak zorundayız.
--Select'ten sonra * koyamayız.Sadece kümülatif dataları yazabiliriz count gibi.
--group by bütün categoryId leri guplayarak tablo haline getirir.group by önüne yazılan şeyleri tekrar etmeyecek şekilde listele demek .

select CategoryID, count(*) from Products group by CategoryID -- CategoryId leri tekrar etmeden sırala. ardından her birinin içinde kaç eleman var yazdır.
--Group by olduğu için her bir grup için ayrı ayrı eleman sayısı hesaplanır.


select CategoryID, count(*) from Products group by CategoryID having count(*)<10 -- having counta şart getirdi. Sayısı 10'dan küçük olanları yazdırdı.

select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 -- CategoryId'leri grupla.
--unitPrice'ı 20den büyük olanlar içinde eleman sayısı 10'dan küçük olan grupların eleman sayılarını yazdır.

--JOIN
select * 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID -- inner join birleştirme komutu. on (durumunda) şartımızı belirtir.  
-- inner join sadece iki tabloda da eşleşenleri bir araya getirir. Eşleşmeyen varsa bir araya getirmez.


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID   -- * yerine birleştirdiğimiz ablolardan istediğimiz kolonları çağırabiliriz. 


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10
-- Ürünlerden fiyatı 10'dan büyük olanlar için onu kategorilerle join et ve onu bana getir .


-- DTO ( Data transformation object )


Select * from Products p inner join [Order Details] od 
on p.ProductID=od.ProductID
-- inner join sadece eşleşen kayıtları getirir.


Select * from Products p left join [Order Details] od 
on p.ProductID=od.ProductID

-- left solda olup sağda olmayan kayıtları da getir demektir. Bu örnekte saolda olan her şey sağda da varmış. Aşağıdaki örneğe bakın.

Select * from Customers c inner join Orders o
on c.CustomerID = o.CustomerID
--iki tabloda da ortak olan 830 kayıt var . 

Select * from Customers c right join Orders o
on c.CustomerID = o.CustomerID
-- right sağda olup solda olmayanları da tabloya dahil et demek. Yani left ile aynı mantıkta çalışır.

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
--Solda olup sağda olmayan tabloyu istediğimde 832 kayıt çıktı. Yani 2 müşteri hiç alışveriş yapmamış.Yapmayanları aşağıdaki gibi buluyoruz.

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null 
-- tabloda şipariş versede bazı bilgileri null olan kısımlar var . 
--Mesela Region sütunu null olabilir alışveriş yapan müşterilerde de. 
--O yüzden primary key dediğimiz sütunlarda null var mı diye aratırız . 
--Primary key olabilecek sütunlar CustomerId vs.



Select * from Products p inner join [Order Details] od 
on p.ProductID=od.ProductID
inner join Orders o
on o.CustomerID=od.CustomerID
--bir inner daha eklemek istersek .




