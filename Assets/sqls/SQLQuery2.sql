--Select(seçmek için kulanılır)
-- * sütunları (kolon) cağırır
--sütun isimlerinden sonra boşluk bırakılarak bir şey yazarsak sütun ismi degişir
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'London'

--case İnsensitive (büyük küçük harf duyarsız)
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

--order by (sıralamak)
select * from Products where CategoryID=1 order by UnitPrice asc --ascending (asc) (artan-yükselen) -- descending (desc) (azalan-düşen)

-- count (seçilen tablo da  kaç tane ürün oldugunu gösterir) 
select count(*) from Products

select count(*) from Products where CategoryID = 2


-- hangi karegoride kaç farklı ürün var ?

--group by da select edilen kolon sadece ve sadece group by edilen grup olabilir
select * from Products group by CategoryID --(burası calışmaz)

--her bir karegori grubu için bir bir grup oluşturup bu grubun/grupların içinde kaç adet ürün var onu yazdırıyor
select CategoryID,count(*) from Products group by CategoryID

--KDS (karar destek sistemleri) ne yogun olarak kulanınlan işlemler bunlar (yukarı)

--yönetim dedi ki (bana ürün sayısı 10dan az olan kategorileri listele)

--ürünlere adit kategorilerde ürün fiyatı 20 den yüksek olan ürünlerin hengi kategoride kaç tane kaldıgı
select CategoryID ,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 


--join kulanımı(birleştirmek)

select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID

-- müşteriye belirli bilgileri göstermek için
-- TABLO-KOLON ( Products.ProductID )
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID

-- INNER JOİN 2 tablodada eşleşen bilgileri birleştiriri eger 2 farklı tabloda eşlesen bilgi yoksa getirmez

--C# DTO ( date transformation object ) ( c#'da bu işe verilen işim (terim) )

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID

--hiç şatış yapılmayan ürünleri belirlemek için

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID

-- left join (sol da olup sağ tarafta olmayanlarıda getir)

select * from Customers c inner join Orders o on c.CustomerID = o.CustomerID -- 830 adet eşleşme 

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID -- 832 adet 

-- yani sisteme kayıt olup sipariş vermeyen 2 müşteri var 

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null

-- 1. tabloda olup 2. tabloda olmayan elemanları çagırma için (is null) kulanılır

-- PK(primary Key) hiç bir zaman null olmayacgından kosulu kontrol ederken PK ya uygulanır   
