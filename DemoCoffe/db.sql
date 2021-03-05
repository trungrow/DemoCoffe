
--data seperate for many host - One Database for on CF system
create database DB_CoffeApp
go
use DB_CoffeApp
go
create table Admins
(
	AdminId int identity(1,1) primary key,
	AdminUserName varchar(20),
	AdminPassword varchar(100),


	--Person Information
	AdminFullName nvarchar(50),
	AdminMail varchar(50),
	AdminPhone varchar(20),
	AdminAddress nvarchar(200),
	AdminAvatar varchar(100),
	AdminBrithDay date,
	AdminGender bit --0 Male, 1 Female

)
--go
--create table Owners
--(
--	IdOwner int identity(1,1),
--	--Person Information
--	FullNameOwner nvarchar(100),
--	IdentityCustomerOwner varchar(20),
--	MailOwner varchar(50),
--	PhoneOwner varchar(20),
--	AddressOwner nvarchar(200),
--	ImgOwner varchar(100),
--	GenderOwner bit, --0 male, 1 female

--	---Service Information
--	UserNameOwner varchar(20),
--	PasswordOwner varchar(100),
--	OldPasswordOwner varchar(100),
--	--Role...


--	CreateDateOwner datetime default getdate(),
--	UpdateDateOwner datetime default getdate(),
--)
--go
--create table ProductLicenses
--(
--	IdPL int identity(1,1) Primary key,
--	ProductKeyPL uniqueidentifier  default newid(),
--	ActiveStatusPL bit,
--	MachineIDPL varchar(100),


--	--Foreign Key
--	IdOwner int references Owners(IdOwner),
--	CreateDatePL datetime default getdate(),
--	UpdatePL datetime default getdate(),

--)
go
--Setting giao dien...
--create table AppSetting
--(
--	IdApp int identity(1,1) primary key,

--	---Foreign Key
	
--	IdOwner int references Owners(IdOwner),
--	IdPL int references ProductLicenses(IdPL),

--)
-----
--go
--create table ShopInfos
--(
--	IdShopInfo int identity(1,1),
--	IdShopSub int identity(1,1),
--	IconShopInfo varchar(100),
--	Img1ShopInfo varchar(100),
--	Img2ShopInfo varchar(100),
--	Img3ShopInfo varchar(100),
--	Content1ShopInfo nvarchar(500),
--	Content2ShopInfo nvarchar(500),
--	Content3ShopInfo nvarchar(500),
--	PhoneShopInfo varchar(20),
--	MailShopInfo varchar(50),
--	AddressShopInfo nvarchar(200),


--	IdOwner int references Owners(IdOwner),
--	IdPL int references ProductLicenses(IdPL),
--)
go
create table Staffs
(
	StaffId int identity(1,1) primary key,
	StaffCode varchar(20) unique,
	StaffPassword varchar(100),


	--Person Information
	StaffFullName nvarchar(50),
	StaffMail varchar(50),
	StaffPhone varchar(20),
	StaffAddress nvarchar(200),
	StaffAvatar varbinary(max),
	StaffBrithDay date,
	StaffGender bit --0 Male, 1 Female
)
go
create table CoffeTableStates
(
	StateId int identity(1,1),
	StateName nvarchar(50),
	StateColor varchar(20),
)
go
create table CoffeTables
(
	TableId int identity(1,1),
	TableName nvarchar(30),
	TableSize int, -- So luong khach cua ban
	TableDisplay bit, -- trang thai hien thi
	--StateId int, -- Trang thai hoat dong
)
go
create table Categories
(
	CategoryId int identity(1,1),
	CategoryName nvarchar(50),
	CategoryStatus bit default(1),
)
go
create table Products
(
	ProductId int identity(1,1),
	ProductImage varbinary(max),
	ProductName nvarchar(50),
	ProductDescription nvarchar(200),
	ProductPrice decimal(18,0),
	ProductDiscount decimal(18,0),

)
go
create table Orders
(
	OrderId int identity(1,1),
	OrderCode varchar(20),
	OrderStart datetime, -- thoi gian khach vao ban
	OrderEnd datetime,   -- thoi gian khach roi ban
	OrderPeoPleQuantity int, --so nguoi ngoi
	OrderCodeDiscount varchar(20), -- ma giam gia
	OrderTotalDiscount decimal(18,0), --tong so tien giam gia
	OrderTotalTax decimal(18,0), -- so thue phai dong
	OrderTotal decimal(18,0), -- tong so tien thanh toan
	OrderCheckout bit,
	TableId int,
)
go
create table OrderDetails
(
	OrderDetailId int identity(1,1),
	ProductId int,
	ProductQuantity int,

)