create database Assesment

use Assesment
CREATE TABLE Sales_Raw
(
    OrderID INT,
    OrderDate VARCHAR(20),
    CustomerName VARCHAR(100),
    CustomerPhone VARCHAR(20),
    CustomerCity VARCHAR(50),
    ProductNames VARCHAR(200),   -- Multiple products comma-separated
    Quantities VARCHAR(100),     -- Multiple quantities comma-separated
    UnitPrices VARCHAR(100),     -- Multiple prices comma-separated
    SalesPerson VARCHAR(100)
);

INSERT INTO Sales_Raw VALUES
(101, '2024-01-05', 'Ravi Kumar', '9876543210', 'Chennai',
 'Laptop,Mouse', '1,2', '55000,500', 'Anitha'),

(102, '2024-01-06', 'Priya Sharma', '9123456789', 'Bangalore',
 'Keyboard,Mouse', '1,1', '1500,500', 'Anitha'),

(103, '2024-01-10', 'Ravi Kumar', '9876543210', 'Chennai',
 'Laptop', '1', '54000', 'Suresh'),

(104, '2024-02-01', 'John Peter', '9988776655', 'Hyderabad',
 'Monitor,Mouse', '1,1', '12000,500', 'Anitha'),

(105, '2024-02-10', 'Priya Sharma', '9123456789', 'Bangalore',
 'Laptop,Keyboard', '1,1', '56000,1500', 'Suresh');


 

 CREATE TABLE Customers (
    CustomerPhone VARCHAR(20) PRIMARY KEY,
    CustomerName VARCHAR(100),
    CustomerCity VARCHAR(50)
);


CREATE TABLE SalesPersons (
    SalesPersonName VARCHAR(100) PRIMARY KEY
);

CREATE TABLE Products (
    ProductName VARCHAR(100) PRIMARY KEY,
    UnitPrice DECIMAL(10,2)
);




CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    OrderDate DATE,
    CustomerPhone VARCHAR(20),
    SalesPersonName VARCHAR(100),
    FOREIGN KEY (CustomerPhone) REFERENCES Customers(CustomerPhone),
    FOREIGN KEY (SalesPersonName) REFERENCES SalesPersons(SalesPersonName)
);


CREATE TABLE Order_Items (
    OrderID INT,
    ProductName VARCHAR(100),
    Quantity INT,
    UnitPrice DECIMAL(10,2),
    PRIMARY KEY (OrderID, ProductName),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductName) REFERENCES Products(ProductName)
);


select OrderID, TotalSales
from (
select
OrderID,
sum(
cast(q.value as int) * cast(p.value as decimal(10,2))
) as TotalSales
from Sales_Raw
cross apply string_split(Quantities, ',') q
cross apply string_split(UnitPrices, ',') p
group by OrderID
) t
order by TotalSales desc
offset 2 rows
fetch next 1 row only;




select SalesPerson,
sum(cast(q.value as int) * cast(p.value as decimal(10,2))) as TotalSales
from Sales_Raw
cross apply string_split(Quantities, ',') q
cross apply string_split(Unitprices, ',') p
group by SalesPerson
having sum(cast(q.value as int) * cast(p.value as decimal(10,2))) > 60000;



select CustomerName,
sum(cast(q.value as int) * cast(p.value as decimal(10,2))) as TotalAmount
from Sales_Raw
cross apply string_split(Quantities, ',') q
cross apply string_split(UnitPrices, ',') p
group by CustomerName
having sum(cast(q.value as int) * cast(p.value as decimal(10,2))) >
(select avg(Total)
from (
select sum(cast(q.value as int) * cast(p.value as decimal(10,2))) as Total
from Sales_Raw
cross apply string_split(Quantities, ',') q
cross apply string_split(UnitPrices, ',') p
group by CustomerName
) as AvgTable);



select UPPER(CustomerName) as CustomerName,
MONTH(CAST(OrderDate as DATE)) as OrderMonth,
OrderDate
from Sales_Raw
where CAST(OrderDate as DATE) between '2026-01-01' and '2026-01-31';
