# Komutlar

* ***SELECT*** - veritabanından veri alır.
* ***UPDATE*** - veritabanında verileri günceller.
* ***DELETE*** - veritabanından veri siler.
* ***INSERT INTO*** - veritabanına yeni veri ekler.
* ***CREATE DATABASE*** - yeni veritabanı oluşturur.
* ***ALTER DATABASE*** - veritabanını değiştirir.
* ***CREATE TABLE*** - yeni tablo oluşturur.
* ***ALTER TABLE*** - tablo değiştirir.
* ***DROP TABLE*** - tablo siler.
* ***CREATE INDEX*** - dizin oluşturur.
* ***DROP INDEX*** - index siler.

## SQL Select
* bir tablonun içeriğini listelemek için;

```
  SELECT * FROM Customers;
```
* ya da,
```
SELECT column1, column2, ...
FROM table_name;
```
* belirli colonu getirmek için;
```
SELECT CustomerName, City FROM Customers;
```
* farklı olan ifadeler için;
```
SELECT DISTINCT column1, column2, ...
FROM table_name;
```
* Sartır sayısı
```
  SELECT COUNT(*) FROM Customers;
```
### Where
* şu koşulu sağlayan kayıtları getir anlamı taşır.
```
SELECT column1, column2, ...
FROM table_name
WHERE condition;
```
* örnek 1
```
SELECT * FROM Customers
WHERE Country='Mexico';
```

* örnek 2
```
SELECT * FROM Customers
WHERE CustomerID=1;
```

### And kullanımı
* farklı koşulları bağlar. ve anlamı taşır.
```
SELECT column1, column2, ...
FROM table_name
WHERE condition1 AND condition2 AND condition3 ...;
```

### Or kullanımı
* ya da anlamı içerek koşullar için kullanılır.
```
SELECT column1, column2, ...
FROM table_name
WHERE condition1 OR condition2 OR condition3 ...;
```

### Not kullanımı
* verilen koşula eşit olmayan ifadeleri getirir.
```
SELECT column1, column2, ...
FROM table_name
WHERE NOT condition; 
```
