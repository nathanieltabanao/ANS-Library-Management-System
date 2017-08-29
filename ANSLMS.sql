create database ANSLMS
use ANSLMS


create procedure sp_login
@username varchar (50),
@password varchar(max)
as
	select tblUserDetails.username,tblUserDetails.password from tblUserDetails
	where tblUserDetails.username=@username and tblUserDetails.password=@password
	return 0


--tblUserdetails
create table tblUserDetails
(
	GenID int unique identity(100000,1),
	ID varchar(50) not null,
	username varchar(50) not null,
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
	Security_Answer varchar(max) not null
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
select tblUserDetails.username,tblUserDetails.password from tblUserDetails
where tblUserDetails.username=@username and tblUserDetails.password=@password
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
	@Security_Answer varchar(max)
)
as
insert into tblUserDetails
values (@ID,@username,@password,@First_Name,@Middle_Name ,@Last_Name ,@Address ,@Contact_Number ,@Gender,@Birthdate ,@Age ,@Section,@Grade_Level ,@Email_Address ,@Security_Question ,@Security_Answer)

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
	@Security_Answer varchar(max)
)
as
update tblUserDetails
set ID=@ID,username=@username,password=@password,First_Name=@First_Name,Middle_Name=@Middle_Name ,Last_Name=@Last_Name ,Address=@Address ,Contact_Number=@Contact_Number ,Gender=@Gender,Birthdate=@Birthdate ,Age=@Age ,Section=@Section,Grade_Level=@Grade_Level ,Email_Address=@Email_Address ,Security_Question=@Security_Question ,Security_Answer=@Security_Answer
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
where tblUserDetails.ID = @SearchKey or tblUserDetails.Last_Name=@SearchKey




---------------------------------------------------------------------------------------
--tblAdminDetails
create table tblAdminDetails
(
	GenID int unique identity(200000,1),
	ID varchar(50) not null,
	username varchar(50) not null,
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
	Security_Answer varchar(max) not null
)


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
	@Security_Answer varchar(max)
)
as
insert into tblAdminDetails
values(@ID,@username,@password,@First_Name ,@Middle_Name,@Last_Name,@Address,@Contact_Number,@Gender ,@Birthdate,@Age,@Email_Address,@Security_Question,@Security_Answer)


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
	@Security_Answer varchar(max)
)
as
update tblAdminDetails
set username=@username,password=@password,First_Name=@First_Name,Middle_Name=@Middle_Name,Last_Name=@Last_Name,Address=@Address,Contact_Number=@Contact_Number,Gender=@Gender,Age=@Age,Email_Address=@Email_Address,Security_Question=@Security_Question,Security_Answer=@Security_Answer
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
select tblAdminDetails.username,tblAdminDetails.password from tblAdminDetails
where tblAdminDetails.username=@username and tblAdminDetails.password=@password
return 0

--ID FUcntion
create procedure sp_AdminID
as
declare @ID int
select  @ID = IDENT_CURRENT('tblAdminDetails')
return @ID

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

--table for books
create table tblBooksData
(
	BookID int identity(300000,1),
	ISBN varchar(50)
	Title varchar(100) not null,
	Author1 varchar(100) not null,
	Author2 varchar(100),
	Author3 varchar(100),
	Author4 varchar(100),
	Publication_Year datetime,
	Field_of_Study varchar(50),
	Category varchar(50),
	Publisher varchar(50)
)

create table  BookAuthors
(
	
)

create table tblDailyReports
(
	transactionID int identity(1000000,1),
	tDate datetime,
	tAttendant varchar(100),

)



create table tblBookUsage
(
	
)

create table tblLostBooks
(
	
)

--need to be added which is wala pa 


--USER TYPE HERE

--BOOK CODE HERE

--Publisher Here

--YR CODE HERE

--TYPE HERE

--CATEGORY HERE

