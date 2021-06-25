create database MyStore

create table categories(
CategoryID int identity primary key,
CategoryName nvarchar(15) not null
);

insert into categories(CategoryName) values 
('admin'),('guest'),('modifier'),('customer');
Create table Products(
ProductID int identity primary key,
ProductName nvarchar(40) not null,
UnitPrice money not null,
UnitsInStock smallint not null,
CategoryID int not null
foreign key(CategoryID) references categories
);

insert into Products(ProductName,UnitPrice,UnitsInStock,CategoryID) values 
('NDungx','5000',10,2),('NDungx','5000',10,2),('NDungx','10000',10,3),('NDungx','1000',10,4),('NDungx','50000',10,1);
create database Assignment
use Assignment;

Create table Product(
ProductId int primary key,
CategoryID int not null,
ProductName nvarchar(40) not null,
Weight varchar(20) not null,
UnitPrice money not null,
UnitsInStock int not null
);

Create table Member(
MemberId int primary key,
Email varchar(100) not null,
CompanyName nvarchar(40) not null,
City varchar(15) not null,
Country varchar(15) not null,
[Password] varchar(30) not null
);


Create table [Order](
OrderId int not null primary key,
MemberId int not null
foreign key(MemberID) references Member,
OrderDate datetime not null,
RequiredDate datetime,
ShippedDate datetime,
Freight money
);


Create table OrderDetail(
ProductId int foreign key(ProductId) references Product,
OrderId int foreign key(OrderId) references [Order],
UnitPrice money not null,
Quantity int not null,
Discount float not null,
constraint OrderDetailID primary key(productID, OrderID)
);

drop table OrderDetail