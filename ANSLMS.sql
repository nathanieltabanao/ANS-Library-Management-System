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

--sample data for test
insert into tblUserDetails
values ('10001','nathan23','test12','Nathaniel','Angelico','Tabanao','jfkdjfldkjsf','564564654','Male','7-23-1998',18,'CI502A-C','3rd YR')