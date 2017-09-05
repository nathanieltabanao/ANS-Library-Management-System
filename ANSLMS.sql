create database ANSLMS
use ANSLMS

drop database ANSLMS

create procedure sp_login
@username varchar (50),
@password varchar(max)
as
	select tblUserDetails.username,tblUserDetails.password from tblUserDetails
	where tblUserDetails.username=@username and tblUserDetails.password=@password
	return 0

	select * from tblAdminDetails
--tblUserdetails
create table tblUserDetails
(
	GenID int unique identity(100000,1),
	ID varchar(50) not null,
	username varchar(50) primary key,
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
set ID=@ID,username=@username,password=@password,First_Name=@First_Name,Middle_Name=@Middle_Name ,Last_Name=@Last_Name ,Address=@Address ,Contact_Number=@Contact_Number ,Gender=@Gender,Birthdate=@Birthdate ,Age=@Age ,Section=@Section,Grade_Level=@Grade_Level ,Email_Address=@Email_Address ,Security_Question=@Security_Question ,Security_Answer=@Security_Answer,Usertype=@Usertype
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

--id retrieve
create procedure UserUsertype
@parameter1 varchar (50),
@parameter2 varchar(50)
as
select tblUserDetails.username,tblUserDetails.Usertype from tblUserDetails
where tblUserDetails.username=@parameter1 and tblUserDetails.Usertype='student'
return 0

-- check username for dlasjdlkasjdklasjdas
create procedure sp_UserUsernameCheck
(
	@username varchar(50)
)
as
select * from tblUserDetails
where tblUserDetails.username=@username
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
where tblUserDetails.username=@username and tblUserDetails.Security_Question=@Security_Question and tblUserDetails.Security_Answer=@Security_Answer
return 0

create procedure sp_UserChangePass
(
	@username varchar(50),
	@password varchar(max)
)
as
update tblUserDetails
set password=@password
where tblUserDetails.username=@username



---------------------------------------------------------------------------------------
--tblAdminDetails
create table tblAdminDetails
(
	GenID int unique identity(200000,1),
	ID varchar(50) not null,
	username varchar(50) primary key,
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
set username=@username,password=@password,First_Name=@First_Name,Middle_Name=@Middle_Name,Last_Name=@Last_Name,Address=@Address,Contact_Number=@Contact_Number,Gender=@Gender,Age=@Age,Email_Address=@Email_Address,Security_Question=@Security_Question,Security_Answer=@Security_Answer,Usertype=@Usertype
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

create procedure AdminUsertype
@parameter1 varchar (50),
@parameter2 varchar(50)
as
select tblAdminDetails.username,tblAdminDetails.Usertype from tblAdminDetails
where tblAdminDetails.username=@parameter1 and tblAdminDetails.Usertype='admin'
return 0


create procedure sp_AdminUsernameCheck
(
	@username varchar(50)
)
as
select * from tblAdminDetails
where tblAdminDetails.username=@username
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
where tblAdminDetails.username=@username and tblAdminDetails.Security_Question=@Security_Question and tblAdminDetails.Security_Answer=@Security_Answer
return 0

create procedure sp_AdminChangePass
(
	@username varchar(50),
	@password varchar(max)
)
as
update tblAdminDetails
set password=@password
where tblAdminDetails.username=@username



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
	Title varchar(100) not null,
	Author1 varchar(100) not null,
	Publication_Year datetime,
	Field_of_Study varchar(50),
	Category varchar(50),
	Publisher varchar(50)
)

select * from tblBooksData

insert into tblBooksData
values('8789798-4546','the idiot')
--stored procedures


--addbook
create procedure sp_BookAdd
(
	@ISBN varchar(50),
	@Title varchar(100),
	@Author1 varchar(100),
	@Publication_Year datetime,
	@Field_of_Study varchar(50),
	@Category varchar(50),
	@Publisher varchar(50)
)
as
insert into tblBooksData
values (@ISBN,@Title,@Author1,@Publication_Year,@Field_of_Study,@Category,@Publisher)

--update book details
create procedure sp_BookEdit
(
	@BookID int,
	@ISBN varchar(50),
	@Title varchar(100),
	@Author1 varchar(100),
	@Publication_Year datetime,
	@Field_of_Study varchar(50),
	@Category varchar(50),
	@Publisher varchar(50)
)
as 
update tblBooksData
set ISBN=@ISBN,Title=@Title,Author1=@Author1,Publication_Year=@Publication_Year,Field_of_Study=@Field_of_Study,Category=@Category,Publisher=@Publisher
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
where tblBooksData.Title like '%'+@SearchKey+'&' or tblBooksData.Author1 like '%'+@SearchKey+'&' or tblBooksData.Publisher like '%'+@SearchKey+'&'
return 0

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

--------------------------------------
create table  BookAuthors
(
	
)


------------------------------

create table tblUserReport
(
	transactionID int identity(0000000,1),
	timestamp datetime,
	username varchar(50) foreign key references tblUserDetails(username),
	Action varchar(max)
)


------------------------------------

--login report
drop table tblLoginReport
create table tblLoginReport
(
	LoginID int identity(10000000,1),
	username varchar(50),
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
	@password varchar(max),
	@Action varchar(100),
	@Timestamp datetime,
	@usertype varchar(50)
)
as
insert into tblLoginReport
values (@username,@password,@Action,@Timestamp,@usertype)


--------------------------------------------------------------------------------

--action report
create table tblActionReport
(
	LogID int identity(100000000,1),
	username varchar(50),
	Action varchar(max),
	Timestamp datetime
)

--make this alter to make this foreign key
alter table tblActionReport
add constraint fk_Username
foreign key (username) references tblAdminDetails(username)


----------------------------------------------------------------------------------
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

