create database ANSLMS
use ANSLMS


create procedure sp_login
@username varchar (50),
@password varchar(max)
as
	select tblUserDetails.username,tblUserDetails.password from tblUserDetails
	where tblUserDetails.username=@username and tblUserDetails.password=@password
	return 0

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
	Section varchar(20) not null,
	Grade_Level varchar(20) not null,
)

select * from tblUserDetails

--sample data for test
insert into tblUserDetails
values ('10001','nathan23','test12','Nathaniel','Angelico','Tabanao','jfkdjfldkjsf','564564654','Male','7-23-1998',18,'CI502A-C','3rd YR')

drop table test

create table test
(
	username varchar(20),
	apassword varchar(20)
)

insert into  test
values ('nathan23','test12')

create procedure sp_login1
@username varchar (50),
@password varchar(max)
as
	select test.username,test.apassword from test
		where test.username=@username and test.apassword=@password
	return 0

drop table tblbooksdb

create table tblBooksDB
(
	BookID int identity(200000,1),
	bISBN varchar(50)
	bTitle varchar(100) not null,
	bAuthor1 varchar(100) not null,
	bAuthor2 varchar(100),
	bAuthor3 varchar(100),
	bAuthor4 varchar(100),
	bPublication_Year varchar(20),
	bField_of_Study varchar(50),
	bCategory varchar(50),
	bPublisher varchar(50)
)

create table  BookAuthors
(
	
)

create table tblDailyReports
(
	transactionID int identity(200000,1)
	tDate datetime,
	tAttendant varchar(100),

)

create table tblBookUsage
(
	
)

create table tblLostBooks
(
	
)