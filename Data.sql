CREATE DATABASE QuanLyQuanCaFe
GO

USE QuanLyQuanCaFe
GO

-- Food
-- Table
-- FoodCategogy
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT PRIMARY KEY,
	name nvarchar(100) default N'Bàn Chưa Có Tên',
	statuss nvarchar(100) default N'Trống', -- Bàn Trống || Bàn Có Người
)
GO

CREATE TABLE Account
(
	displayname nvarchar(100) not null default N'Kter',
	username nvarchar(100) primary key,
	passwordd nvarchar(100) not null default 0,
	typee int not null default 0 -- 1: Admin 0:Staff
)
GO

CREATE TABLE FoodCatogory
(
	id INT PRIMARY KEY,
	name nvarchar(100) default N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT  PRIMARY KEY,
	name nvarchar(100) default N'Chưa đặt tên',
	idCategory int not null,
	price int not null default 0

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCatogory(id)
)
GO

CREATE TABLE Bill
(
	id INT  PRIMARY KEY,
	DateCheckIn date not null default getdate(),
	DateCheckOut date,
	idTable int not null,
	statuss int not null default 0 -- 1 đã thanh toán || 0 chưa thanh toán

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT  PRIMARY KEY,
	idBill int not null,
	idFood int not null,
	count int not null default 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

INSERT dbo.Account
(
    displayname,
    username,
    passwordd,
    typee
)
VALUES
(   N'quang', -- displayname - nvarchar(100)
    N'admin1', -- username - nvarchar(100)
    N'1234', -- passwordd - nvarchar(100)
    1    -- typee - int
    )

INSERT dbo.Account
(
    displayname,
    username,
    passwordd,
    typee
)
VALUES
(   N'tuan', -- displayname - nvarchar(100)
    N'admin2', -- username - nvarchar(100)
    N'1234', -- passwordd - nvarchar(100)
    1    -- typee - int
    )


INSERT dbo.FoodCatogory
(
    id,
    name
)
VALUES
(   1,  -- id - int
    N'hai san' -- name - nvarchar(100)
    )

INSERT dbo.FoodCatogory
(
    id,
    name
)
VALUES
(   2,  -- id - int
    N'cafe' -- name - nvarchar(100)
    )

INSERT dbo.Food
(
    id,
    name,
    idCategory,
    price
)
VALUES
(   1,   -- id - int
    N'hai san', -- name - nvarchar(100)
    1,   -- idCategory - int
    10000    -- price - int
    )

INSERT dbo.Food
(
    id,
    name,
    idCategory,
    price
)
VALUES
(   2,   -- id - int
    N'cafe', -- name - nvarchar(100)
    2,   -- idCategory - int
    10000    -- price - int
    )

INSERT dbo.TableFood
(
    id,
    name,
    statuss
)
VALUES
(   1,   -- id - int
    N'ban 1', -- name - nvarchar(100)
    N'trong'  -- statuss - nvarchar(100)
    )
INSERT dbo.TableFood
(
    id,
    name,
    statuss
)
VALUES
(   2,   -- id - int
    N'ban 2', -- name - nvarchar(100)
    N'co nguoi'  -- statuss - nvarchar(100)
    )
INSERT dbo.Bill
(
    id,
    DateCheckIn,
    DateCheckOut,
    idTable,
    statuss
)
VALUES
(   1,         -- id - int
    GETDATE(), -- DateCheckIn - date
    null, -- DateCheckOut - date
    1,         -- idTable - int
    0          -- statuss - int
    )
INSERT dbo.Bill
(
    id,
    DateCheckIn,
    DateCheckOut,
    idTable,
    statuss
)
VALUES
(   2,         -- id - int
    GETDATE(), -- DateCheckIn - date
    GETDATE(), -- DateCheckOut - date
    2,         -- idTable - int
    1          -- statuss - int
    )
INSERT dbo.BillInfo
(
    id,
    idBill,
    idFood,
    count
)
VALUES
(   1, -- id - int
    1, -- idBill - int
    1, -- idFood - int
    2  -- count - int
    )
INSERT dbo.BillInfo
(
    id,
    idBill,
    idFood,
    count
)
VALUES
(   2, -- id - int
    2, -- idBill - int
    2, -- idFood - int
    3  -- count - int
    )
SELECT * FROM dbo.Food
SELECT * FROM dbo.Account
SELECT * FROM dbo.FoodCatogory
 SELECT * FROM dbo.Bill
 SELECT * FROM dbo.BillInfo
 SELECT id FROM dbo.Bill WHERE idTable=1 AND statuss = 0
 SELECT * FROM dbo.BillInfo WHERE idBill = 1

 SELECT * FROM dbo.TableFood









CREATE PROC usp_getlistaccount
@username NVARCHAR(100)
AS
BEGIN
 SELECT * FROM dbo.Account WHERE username = @username
END
GO

EXEC dbo.usp_getlistaccount @username = N'a' -- nvarchar(100)

