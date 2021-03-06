create database ANSLMS
use ANSLMS

drop database ANSLMS

-------------------------------------------------------------------------------
create procedure sp_login
@username varchar (50),
@password varchar(max)
	as
	select tblUserDetails.username,tblUserDetails.password from tblUserDetails
	where tblUserDetails.username=@username and tblUserDetails.password=@password
	return 0

	select * from tblAdminDetails


------------------------------------------------------------------------------------------


select * from tblAdminActionReport
select * from tblAdminDetails
select * from tblAdminLoginReport
select * from tblAdminTransaction
select * from tblBooks
select * from tblBooksData
select * from tblLoginReport
select * from tblBooksBorrowed
select * from tblUserActionReport
select * from tblUserDetails
select * from tblUserLoginReport
select * from tblUserReport

truncate table tblAdminActionReport
truncate table tblAdminDetails
truncate table tblAdminLoginReport
truncate table tblAdminTransaction
truncate table tblBooks
truncate table tblBooksData
truncate table tblLoginReport
truncate table tblBooksBorrowed
truncate table tblUserActionReport
truncate table tblUserDetails
truncate table tblUserLoginReport
truncate table tblUserReport
	---------------------------------------------------------------------------------------
--tblUserdetails
create table tblUserDetails
(
	GenID int unique identity(100000,1),
	ID varchar(50) not null,
	UserUsername varchar(50) primary key,
	password varchar(max) not null,
	First_Name varchar(50) not null,
	Middle_Name varchar(30),
	Last_Name varchar(50) not null,
	Address varchar(max) not null,
	Contact_Number varchar(20) not null,
	Gender varchar(10) not null,
	Birthdate datetime,
	Age int,
	Section varchar(20),
	Grade_Level varchar(20) ,
	Email_Address varchar(100) not null,
	Security_Question varchar(max) not null,
	Security_Answer varchar(max) not null,
	Usertype varchar(50)
)
--FOr tblUserdetails
drop table tblUserDetails
select * from tblUserDetails

--Stored Procedures for tblUserdetails
--Login
create procedure sp_UserLogin
@username varchar (50),
@password varchar(max)
as
select tblUserDetails.Userusername,tblUserDetails.password from tblUserDetails
where tblUserDetails.UserUsername=@username and tblUserDetails.password=@password
return 0

--USER INSERT
create procedure sp_UserInsert
(
	@ID varchar(50),
	@username varchar(50),
	@password varchar(max),
	@First_Name varchar(50),
	@Middle_Name varchar(30),
	@Last_Name varchar(50),
	@Address varchar(max),
	@Contact_Number varchar(20),
	@Gender varchar(10),
	@Birthdate datetime,
	@Age int,
	@Section varchar(20),
	@Grade_Level varchar(20) ,
	@Email_Address varchar(100),
	@Security_Question varchar(max),
	@Security_Answer varchar(max),
	@Usertype varchar(50)
)
as
insert into tblUserDetails
values (@ID,@username,@password,@First_Name,@Middle_Name ,@Last_Name ,@Address ,@Contact_Number ,@Gender,@Birthdate ,@Age ,@Section,@Grade_Level ,@Email_Address ,@Security_Question ,@Security_Answer,@Usertype)

--USER UPDATE
create procedure sp_UserUpdate
(
	@ID varchar(50),
	@username varchar(50),
	@password varchar(max),
	@First_Name varchar(50),
	@Middle_Name varchar(30),
	@Last_Name varchar(50),
	@Address varchar(max),
	@Contact_Number varchar(20),
	@Gender varchar(10),
	@Birthdate datetime,
	@Age int,
	@Section varchar(20),
	@Grade_Level varchar(20) ,
	@Email_Address varchar(100),
	@Security_Question varchar(max),
	@Security_Answer varchar(max),
	@Usertype varchar(50)
)
as
update tblUserDetails
set ID=@ID,UserUsername=@username,password=@password,First_Name=@First_Name,Middle_Name=@Middle_Name ,Last_Name=@Last_Name ,Address=@Address ,Contact_Number=@Contact_Number ,Gender=@Gender,Birthdate=@Birthdate ,Age=@Age ,Section=@Section,Grade_Level=@Grade_Level ,Email_Address=@Email_Address ,Security_Question=@Security_Question ,Security_Answer=@Security_Answer,Usertype=@Usertype
where tblUserDetails.ID=@ID

--USER DELETE
create procedure sp_DeleteUser
(
	@ID varchar(50)
)
as
delete from tblUserDetails
where tblUserDetails.ID=@ID

-- USER ID
create procedure sp_UserID
as
declare @ID int
select  @ID = IDENT_CURRENT('tblUserDetails')
return @ID

--USER SEARCH
create procedure sp_UserSearch
(
	@SearchKey varchar(50)
)
as
select ID,First_Name,Middle_Name,Last_Name,Address,Contact_Number,Gender,Birthdate,Age,Section,Grade_Level,Email_Address from tblUserDetails
where  tblUserDetails.Last_Name like '%'+@SearchKey+'%'

--id retrieve
create procedure UserUsertype
@parameter1 varchar (50),
@parameter2 varchar(50)
as
select tblUserDetails.Userusername,tblUserDetails.Usertype from tblUserDetails
where tblUserDetails.Userusername=@parameter1 and tblUserDetails.Usertype='student'
return 0

-- check username for dlasjdlkasjdklasjdas
create procedure sp_UserUsernameCheck
(
	@username varchar(50)
)
as
select * from tblUserDetails
where tblUserDetails.Userusername=@username
return 0

----Security Change Qustion
create procedure sp_UserChangePassVerify
(
	@username varchar(50),
	@password varchar(max),
	@Security_Question varchar(max),
	@Security_Answer varchar(max)
)
as
select * from tblUserDetails
where tblUserDetails.Userusername=@username and tblUserDetails.Security_Question=@Security_Question and tblUserDetails.Security_Answer=@Security_Answer
return 0

create procedure sp_UserChangePass
(
	@username varchar(50),
	@password varchar(max)
)
as
update tblUserDetails
set password=@password
where tblUserDetails.Userusername=@username

create procedure sp_UserView
as
select * from tblUserDetails

create procedure sp_ViewUserModified
as
select UserUsername,First_Name,Middle_Name,Last_Name from tblUserDetails


create procedure sp_SearchUserModified
@SearchKey varchar(50)
as
select UserUsername,First_Name,Middle_Name,Last_Name from tblUserDetails
where UserUsername like '%'+@SearchKey+'%' or First_Name like '%'+@SearchKey+'%' or Last_Name like '%'+@SearchKey+'%'

---------------------------------------------------------------------------------------
--tblAdminDetails
create table tblAdminDetails
(
	GenID int unique identity(200000,1),
	ID varchar(50) not null,
	AdminUsername varchar(50) primary key,
	password varchar(max) not null,
	First_Name varchar(50) not null,
	Middle_Name varchar(30),
	Last_Name varchar(50) not null,
	Address varchar(max) not null,
	Contact_Number varchar(20) not null,
	Gender varchar(10) not null,
	Birthdate datetime,
	Age int,
	Email_Address varchar(100) not null,
	Security_Question varchar(max) not null,
	Security_Answer varchar(max) not null,
	Usertype varchar(50)
)

drop table tblAdminDetails
select * from tblAdminDetails
truncate table tblAdminDetails

--procedures for Admin

--Data Insert Admin
create procedure sp_AdminInsert
(
	@ID varchar(50),
	@username varchar(50),
	@password varchar(max),
	@First_Name varchar(50),
	@Middle_Name varchar(30),
	@Last_Name varchar(50),
	@Address varchar(max),
	@Contact_Number varchar(20),
	@Gender varchar(10),
	@Birthdate datetime,
	@Age int,
	@Email_Address varchar(100),
	@Security_Question varchar(max),
	@Security_Answer varchar(max),
	@Usertype varchar(50)
)
as
insert into tblAdminDetails
values(@ID,@username,@password,@First_Name ,@Middle_Name,@Last_Name,@Address,@Contact_Number,@Gender ,@Birthdate,@Age,@Email_Address,@Security_Question,@Security_Answer,@Usertype)


create procedure sp_AdminUpdate
(
	@ID varchar(50),
	@username varchar(50),
	@password varchar(max),
	@First_Name varchar(50),
	@Middle_Name varchar(30),
	@Last_Name varchar(50),
	@Address varchar(max),
	@Contact_Number varchar(20),
	@Gender varchar(10),
	@Birthdate datetime,
	@Age int,
	@Email_Address varchar(100),
	@Security_Question varchar(max),
	@Security_Answer varchar(max),
	@Usertype varchar(50)
)
as
update tblAdminDetails
set AdminUsername=@username,password=@password,First_Name=@First_Name,Middle_Name=@Middle_Name,Last_Name=@Last_Name,Address=@Address,Contact_Number=@Contact_Number,Gender=@Gender,Age=@Age,Email_Address=@Email_Address,Security_Question=@Security_Question,Security_Answer=@Security_Answer,Usertype=@Usertype
where ID=@ID

--delete from admin table
create procedure sp_AdminDelete
(
	@ID varchar(50)
)
as
delete tblAdminDetails
where ID=@ID

--search function 


--LOGINFUNCTION
create procedure sp_AdminLogin
@username varchar (50),
@password varchar(max)
as
select tblAdminDetails.AdminUsername,tblAdminDetails.password from tblAdminDetails
where tblAdminDetails.AdminUsername=@username and tblAdminDetails.password=@password
return 0

--ID FUcntion
create procedure sp_AdminID
as
declare @ID int
select  @ID = IDENT_CURRENT('tblAdminDetails')
return @ID

create procedure AdminUsertype
@parameter1 varchar (50),
@parameter2 varchar(50)
as
select tblAdminDetails.AdminUsername,tblAdminDetails.Usertype from tblAdminDetails
where tblAdminDetails.AdminUsername=@parameter1 and tblAdminDetails.Usertype='admin'
return 0


create procedure sp_AdminUsernameCheck
(
	@username varchar(50)
)
as
select * from tblAdminDetails
where tblAdminDetails.AdminUsername=@username
return 0


----Security Change Qustion
create procedure sp_AdminChangePassVerify
(
	@username varchar(50),
	@password varchar(max),
	@Security_Question varchar(max),
	@Security_Answer varchar(max)
)
as
select * from tblAdminDetails
where tblAdminDetails.AdminUsername=@username and tblAdminDetails.Security_Question=@Security_Question and tblAdminDetails.Security_Answer=@Security_Answer
return 0

create procedure sp_AdminChangePass
(
	@username varchar(50),
	@password varchar(max)
)
as
update tblAdminDetails
set password=@password
where tblAdminDetails.AdminUsername=@username



------------------------------------------------------------------------------------------------
--test system
create table test
(
	username varchar(20),
	apassword varchar(20)
)
drop table test

insert into  test
values ('nathan23','test12')

create procedure sp_login1
@username varchar (50),
@password varchar(max)
as
	select test.username,test.apassword from test
		where test.username=@username and test.apassword=@password
	return 0
--------------------------------------------------------------------------------------------------------

drop table tblBooksData

--table for books
create table tblBooksData
(
	BookID int identity(300000,1),
	ISBN varchar(50),
	Title varchar(200) primary key,
	Author1 varchar(100) not null,
	Publication_Year datetime,
	Field_of_Study varchar(50),
	Category varchar(50),
	Publisher varchar(50),
	Quantity int,
	Price decimal(8,2)
)

select * from tblBooksData

insert into tblBooksData
values('8789798-4546','the idiot')
--stored procedures


--addbook
create procedure sp_BookAdd
(
	@ISBN varchar(50),
	@Title varchar(200),
	@Author1 varchar(100),
	@Publication_Year datetime,
	@Field_of_Study varchar(50),
	@Category varchar(50),
	@Publisher varchar(50),
	@Quantity int,
	@Price decimal(8,2)
)
as
insert into tblBooksData
values (@ISBN,@Title,@Author1,@Publication_Year,@Field_of_Study,@Category,@Publisher,@Quantity,@Price)

--update book details
create procedure sp_BookEdit
(
	@BookID int,
	@ISBN varchar(50),
	@Title varchar(200),
	@Author1 varchar(100),
	@Publication_Year datetime,
	@Field_of_Study varchar(50),
	@Category varchar(50),
	@Publisher varchar(50),
	@Quantity int,
	@Price decimal(8,2)
)
as 
update tblBooksData
set ISBN=@ISBN,Title=@Title,Author1=@Author1,Publication_Year=@Publication_Year,Field_of_Study=@Field_of_Study,Category=@Category,Publisher=@Publisher, Quantity=@Quantity,Price=@Price
where BookID=@BookID


--book ID
create procedure sp_BookID
as
declare @ID int
select  @ID = IDENT_CURRENT('tblBooksData')
return @ID

--search function
create procedure sp_BookSearch
(
	@SearchKey varchar(50)
)
as
select * from tblBooksData
where Title like '%'+@SearchKey+'%' or Author1 like '%'+@SearchKey+'%' or Publisher like '%'+@SearchKey+'%' or isbn like '%'+@SearchKey+'%'

---view shat
create procedure sp_BookView
as
select * from tblBooksData

--delete book
create procedure sp_BookDelete
(
	@BookID int
)
as
delete tblBooksData
where tblBooksData.BookID=@BookID


---to be check
--book quantity
create procedure sp_BookQuantityUpdate
@Title varchar(200),
@Quantity int
as
update tblBooksData
set Quantity=@Quantity
where Title=@Title

create procedure sp_BookQuantity
@title varchar(200),
@quantity int
as
select @Quantity=tblBooksData.Quantity from tblBooksData
where tblBooksData.Title=@Title
return @quantity



--------------------------------------
create table  BookAuthors
(
	
)


------------------------------

create table tblUserReport
(
	transactionID int identity(0000000,1),
	timestamp datetime,
	username varchar(50) foreign key references tblUserDetails(Userusername),
	Action varchar(max)
)

create procedure sp_InsertUserAction
	@timestamp datetime,
	@Username varchar(50),
	@Action varchar(max)
as
insert into tblUserReport
values(@timestamp,@Username,@Action)
------------------------------------

--login report
drop table tblAdminLoginReport
create table tblAdminLoginReport
(
	LoginID int identity(10000000,1),
	username varchar(50) foreign key references tblAdminDetails(adminusername),
	password varchar(max),
	Action varchar(100),
	Timestamp datetime,
	usertype varchar(50)
)

select * from tblAdminLoginReport
 truncate table tblAdminloginreport

--login status
create procedure sp_AdminLoginReport
(
	@username varchar(50),
	@password varchar(max),
	@Action varchar(100),
	@Timestamp datetime,
	@usertype varchar(50)
)
as
insert into tblAdminLoginReport
values (@username,@password,@Action,@Timestamp,@usertype)


--------------------------------------------------------------------------------

--login for user
drop table tblUserLoginReport
create table tblUserLoginReport
(
	LoginID int identity(10000000,1),
	username varchar(50) foreign key references tblUserDetails(Userusername),
	password varchar(max),
	Action varchar(100),
	Timestamp datetime,
	usertype varchar(50)
)

select * from tblUserLoginReport
 truncate table tblAUserloginreport

--login status
create procedure sp_UserLoginReport
(
	@username varchar(50),
	@password varchar(max),
	@Action varchar(100),
	@Timestamp datetime,
	@usertype varchar(50)
)
as
insert into tblUserLoginReport
values (@username,@password,@Action,@Timestamp,@usertype)


----------------------------------------------------------------------------------
create table tblLoginReport
(
	LoginID int identity(10000000,1),
	username varchar(50),
	AdminUsername varchar(50) foreign key references tblAdminDetails(AdminUsername),
	UserUsername varchar(50) foreign key references tblUserDetails(Userusername),
	password varchar(max),
	Action varchar(100),
	Timestamp datetime,
	usertype varchar(50)
)

select * from tblLoginReport
 truncate table tblloginreport

--login status
create procedure sp_LoginReport
(
	@username varchar(50),
	@AdminUsername varchar(50),
	@UserUsername varchar(50),
	@password varchar(max),
	@Action varchar(100),
	@Timestamp datetime,
	@usertype varchar(50)
)
as
insert into tblLoginReport
values (@username,@AdminUsername,@UserUsername,@password,@Action,@Timestamp,@usertype)





-----------------------------------------------------------------------------------
--action report admin
create table tblAdminActionReport
(
	LogID int identity(100000000,1),
	username varchar(50) foreign key references tblAdminDetails(adminusername),
	Action varchar(max),
	Timestamp datetime
)

--insert stored procedure
create procedure sp_AdminActionReport
(
	@username varchar(50),
	@Action varchar(max),
	@Timestamp datetime
)
as
insert into tblAdminActionReport
values (@username,@Action,@Timestamp)


-------------------------------------------------------

--action report user
create table tblUserActionReport
(
	LogID int identity(100000000,1),
	username varchar(50) foreign key references tblUserDetails(userusername),
	Action varchar(max),
	Timestamp datetime
)

--stored proceure for insert
create procedure sp_UserActionReport
(
	@username varchar(50),
	@Action varchar(max),
	@Timestamp datetime
)
as
insert into tblUserActionReport
values (@username,@Action,@Timestamp)


----------------------------------------------------------------------------------


--tables for daily transactions
drop table tblAdminTransaction

create table tblAdminTransaction
(
	TransactionID int identity(0000000,1),
	AdminUsername varchar(50) foreign key references tblAdminDetails(AdminUsername),
	Action varchar(max),
	Client varchar(50),
	TimeStamp datetime
)

select * from tblAdminTransaction

--stored procedures for admin transaction

create procedure sp_AdminTransactionAdd
(
	@Attendant varchar(50),
	@Action varchar(max),
	@Client varchar(50),
	@TimeStamp datetime
)
as
insert into tblAdminTransaction
values (@Attendant,@Action,@Client,@TimeStamp)


select 


--------------------------------------------------------------------------------------

drop table tblBooksBorrowed

create table tblBooksBorrowed
(
	TransactionID int identity(0000000,1),
	AdminUsername varchar(50) foreign key references tblAdminDetails(AdminUsername),
	UserUsername varchar(50) foreign key references tblUserDetails(UserUsername),
	BorrowersName varchar(150),
	Title varchar(200) foreign key references tblBooksData(Title),
	DateBorrowed datetime,
	DateDeadline datetime
)

select * from tblBooksBorrowed

--stored procedures
create procedure sp_BookBorrowing
(
	@AdminUsername varchar(50),
	@UserUsername varchar(50),
	@BorrowersName varchar(150),
	@Title varchar(200),
	@DateBorrowed datetime,
	@DateDeadline datetime
)
as
insert into tblBooksBorrowed
values (@AdminUsername,@UserUsername,@BorrowersName,@Title,@DateBorrowed,@DateDeadline)
 
 select tblUserDetails.UserUsername,tblBooksBorrowed.Title from tbluserdetails
 inner join tblbooksborrowed on tblUserDetails.UserUsername=tblBooksBorrowed.UserUsername
 where tblBooksBorrowed.Title='1984'

 create procedure sp_BookReturnEntryDelete
 (
	@username varchar(50),
	@Title varchar(200)
 )
 as
 delete tblBooksBorrowed
 where tblBooksBorrowed.Title=@Title and tblBooksBorrowed.UserUsername=@username
-------------------------------------------------------------------------------------------
drop table tblBooks

create table tblBooks
(
	TransactionID int identity(0000000,1),
	AdminUsername varchar(50) foreign key references tblAdminDetails(AdminUsername),
	UserUsername varchar(50) foreign key references tblUserDetails(UserUsername),
	Title varchar(200) foreign key references tblBooksData(Title),
	DateBorrowed datetime,
	DateDeadline datetime,
	ActualReturned datetime,
	IsGoodContidion varchar(2),
	IsPaid varchar(2)
)	


select * from tblBooks

create procedure sp_SearchAccountingNotPaid
@searchkey varchar(50)
as
select tblBooks.TransactionID,tblBooks.UserUsername, tblUserDetails.First_Name, tblUserDetails.Middle_Name,tblUserDetails.Last_Name,tblBooks.Title,tblBooks.DateBorrowed,tblBooks.DateDeadline,tblBooks.ActualReturned,tblBooks.IsGoodContidion,tblBooks.Ispaid from tblBooks
inner join tblUserDetails on tblBooks.UserUsername=tblUserDetails.UserUsername
where tblBooks.Ispaid='n' or tblBooks.UserUsername=@searchkey

create procedure sp_ViewLostBooks
@SearchKey varchar(50)
as
select tblBooks.TransactionID,tblBooks.UserUsername,tblUserDetails.First_Name,tblUserDetails.Middle_Name,tblUserDetails.Last_Name, tblBooksData.BookID,tblBooksData.ISBN,tblBooks.Title,tblBooks.IsGoodContidion,tblBooks.IsPaid from tblBooks
inner join tblBooksData on tblBooks.Title=tblBooksData.Title
inner join tblUserDetails on tblBooks.UserUsername=tblUserDetails.UserUsername
where tblBooks.IsGoodContidion='n' and tblBooks.UserUsername like '%'+@SearchKey+'%'

create procedure sp_ViewNotPaidBooks
as
select * from tblBooks
where tblBooks.Ispaid='n'

create procedure sp_BookReplace
@transactionid int,
@Key varchar(2)
as
update tblBooks
set IsPaid=@Key, IsGoodContidion=@Key
where TransactionID=@transactionid

create procedure sp_ViewLostBooksTable
@SearchKey varchar(50)
as
select tblBooks.TransactionID,tblBooks.UserUsername,tblUserDetails.First_Name,tblUserDetails.Middle_Name,tblUserDetails.Last_Name, tblBooksData.BookID,tblBooksData.ISBN,tblBooks.Title,tblBooks.IsGoodContidion,tblBooks.IsPaid from tblBooks
inner join tblBooksData on tblBooks.Title=tblBooksData.Title
inner join tblUserDetails on tblBooks.UserUsername=tblUserDetails.UserUsername
where tblBooks.IsGoodContidion='n'


create procedure sp_ViewTopay
as 
	select tblBooks.TransactionID,tblBooks.UserUsername, tblUserDetails.First_Name, tblUserDetails.Middle_Name,tblUserDetails.Last_Name,tblBooks.Title,tblBooks.DateBorrowed,tblBooks.DateDeadline,tblBooks.ActualReturned,tblBooks.IsGoodContidion,tblBooks.Ispaid from tblBooks
	inner join tblUserDetails on tblBooks.UserUsername=tblUserDetails.UserUsername
	where  tblBooks.IsGoodContidion='n' or tblBooks.Ispaid='n'

create procedure sp_BookReturn
(
	@AdminUsername varchar(50),
	@UserUsername varchar(50),
	@Title varchar(200),
	@DateBorrowed datetime,
	@DateDeadline datetime,
	@ActualReturned datetime,
	@IsGoodContidion varchar(2),
	@IsPaid varchar(2)
)
as
insert into tblBooks
values (@AdminUsername,@UserUsername,@Title,@DateBorrowed,@DateDeadline,@ActualReturned,@IsGoodContidion,@IsPaid)
 
create procedure sp_BookReturnEdit
(
	@ID int,
	@AdminUsername varchar(50),
	@UserUsername varchar(50),
	@Title varchar(100),
	@DateBorrowed datetime,
	@DateDeadline datetime,
	@ActualReturned datetime,
	@IsGoodContidion varchar(2),
	@IsPaid varchar(2)
)
as
update tblBooks
set AdminUsername=@AdminUsername,UserUsername=@UserUsername,Title=@Title,DateBorrowed=@DateBorrowed,DateDeadline=@DateDeadline,ActualReturned=@ActualReturned,IsGoodContidion=@IsGoodContidion,ispaid=@IsPaid
where TransactionID=@ID

create procedure sp_BookDuePaid
@id int,
@IsPaid varchar(2)
as
update tblBooks
set IsPaid=@IsPaid
where TransactionID=@id

create procedure sp_BookReturnTransactionID

-----------------------------------------------------------------------------------------
create procedure sp_ViewBorrowedBooks
(
	@username varchar(50)
)
as
select tblUserDetails.UserUsername,tblBooksBorrowed.Title,tblBooksBorrowed.DateBorrowed,tblBooksBorrowed.DateDeadline from tblUserDetails
inner join tblbooksborrowed on tblUserDetails.UserUsername=tblBooksBorrowed.UserUsername
where tblUserDetails.UserUsername=@username

create procedure sp_ViewBorrowedBooksAdmin
(
	@username varchar(50)
)
as
select tblUserDetails.UserUsername,tblBooksBorrowed.Title,tblBooksBorrowed.DateBorrowed,tblBooksBorrowed.DateDeadline from tblUserDetails
inner join tblbooksborrowed on tblUserDetails.UserUsername=tblBooksBorrowed.UserUsername

create procedure sp_SearchBorrowedBooks
@SearchKey varchar(50)
as
select tblUserDetails.UserUsername,tblBooksBorrowed.Title,tblBooksBorrowed.DateBorrowed,tblBooksBorrowed.DateDeadline from tblUserDetails
inner join tblbooksborrowed on tblUserDetails.UserUsername=tblBooksBorrowed.UserUsername
where tblBooksBorrowed.UserUsername like '%'+@SearchKey+'%' or tblBooksBorrowed.Title like '%'+@SearchKey+'%'

 select tblUserDetails.UserUsername,tblBooksBorrowed.Title from tbluserdetails
 inner join tblbooksborrowed on tblUserDetails.UserUsername=tblBooksBorrowed.UserUsername
 where tblBooksBorrowed.Title='1984'
-----------------------------------------------------------------------------------------

create table tblTransaction
(
	AdminUsername varchar(50) foreign key references tblAdminDetails(AdminUsername),
	UserUsername varchar(50) foreign key references tblUserDetails(UserUsername),
	Action varchar(max),
	Title varchar(200) foreign key references tblBooksData(Title),
	Timestamp datetime
)

select * from tblTransaction

create procedure sp_BookAction
(
	@AdminUsername varchar(50),
	@UserUsername varchar(50),
	@Action varchar(max),
	@Title varchar(200),
	@Timestamp datetime	
)
as
insert into tblTransaction
values (@AdminUsername,@UserUsername,@Action,@Title,@Timestamp)
---------------------------------------------------------------------------------------

--accounting maybe
--really accounting prices and stuff\
create table tblBookPrices
(
	Title varchar(200) foreign key references tblbooksdata(Title),
	Price decimal(8,2)
)

create procedure sp_BookPriceInsert
@title varchar(200),
@price decimal(8,2)
as
insert into tblBookPrices
values(@title,@price)

select * from tblBookPrices
----------------------------------------------------------------------------------------
create table tblLostDamagedBooks
(
	UserUsername varchar(50) foreign key references tblUserDetails(UserUsername),
	Title varchar(200) foreign key references tblBooksData(Title)
)

create procedure sp_InsertDamagedBooks
@username varchar(50),
@Title varchar(200)
as
insert into tblLostDamagedBooks
values (@username,@Title)

create procedure sp_DeleteDamagedBooks
@username varchar(50),
@Title varchar(200)
as
delete tblLostDamagedBooks
where tblLostDamagedBooks.UserUsername=@username and tblLostDamagedBooks.Title=@Title
-------------------------------------------------------------------

drop table tblBookAccounting

create table tblBookAccounting
(
	TransactionID int identity(100000000,1),
	Timestamp datetime,
	AdminUsername varchar(50) foreign key references tblAdminDetails(AdminUsername),
	UserUsername varchar(50) foreign key references tblUserDetails(UserUsername),
	name varchar(200),
	PaymentDue decimal(8,2),
	Cash decimal(8,2),
	Change decimal(8,2)
)

create procedure sp_BookPayDue
@timestamp datetime,
@adminusername varchar(50),
@userusername varchar(50),
@name varchar(200),
@paymentdue decimal(8,2),
@cash decimal(8,2),
@change decimal(8,2)
as
insert into tblBookAccounting
values(@timestamp,@adminusername,@userusername,@name,@paymentdue,@cash,@change)

create procedure sp_ViewAccounting
as
select * from tblBookAccounting
------------------------------------------------------------------
create table tblReplacedBooks
(
	ReplacementID int identity(5000000,1),
	UserUsername varchar(50) foreign key references tbluserdetails(userusername),
	Title varchar(200) foreign key references tblBooksdata(Title),
	AdminUsername varchar(50) foreign key references tblAdminDetails(AdminUsername),
	DateReplaced datetime
)

create procedure sp_ReplaceBook
@UserUsername varchar(50),
@Title varchar(200),
@AdminUsername varchar(50),
@DateReplaced datetime
as
insert into tblReplacedBooks
values(@UserUsername,@Title,@AdminUsername,@DateReplaced)

--------------------------------------------------------------------
--USER TYPE HERE

--BOOK CODE HERE

--Publisher Here

--YR CODE HERE

--TYPE HERE

--CATEGORY HERE

