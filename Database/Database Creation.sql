create database Shopify

go

use Shopify

go


create table users(
	UserId int identity(1, 1) primary key,
	Username nvarchar(50) not null,
	Password nvarchar(50) not null,
	Email nvarchar(50) not null unique,
	Age int,
	Address nvarchar(50),
	Role nvarchar(50) not null check(Role in ('Admin', 'User'))
)

go

create table Categories(
	CategoryId int identity(1, 1) primary key,
	CategoryName nvarchar(50) not null
)

go 

create table Products(
	ProductId int identity(1, 1) primary key,
	ProductName nvarchar(50) not null,
	Price decimal(10, 2) not null,
	CategoryId int not null,
	constraint FK_Products_Categories Foreign key (CategoryId) references Categories(CategoryId)
)

go

create table Favourites(
	UserId int not null, 
	ProductId int not null,
	constraint PK_Favorites Primary key (UserId, ProductId),
	constraint FK_Favorites_Users Foreign key (UserId) References users(UserId),
	constraint FK_Favorites_Products Foreign Key (ProductId) References Products(ProductId)
)