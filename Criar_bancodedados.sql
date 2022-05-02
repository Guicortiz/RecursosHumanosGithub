create database RHGithub
go
use RHGithub
go
create table Employee
(
	pk_int_Employee int identity primary key,
	str_Name varchar(100) not null,
	str_Github varchar(50) not null,
	str_linkedin varchar(50) not null,
	str_Fone varchar(11) not null,
	dt_Birthday date not null,
	dt_CreatedAt datetime not null,
	dt_UpdatedAt datetime null
)

create table Employee_Github
(
pk_int_Employee_Github int identity primary key,
fk_int_Employee int,
str_login varchar(50) not null,
int_id int not null,
str_html_url varchar(50) not null,
str_type varchar(20) not null,
str_name varchar(100) not null,
str_company varchar (50) null,
str_blog varchar (50) null,
str_location varchar (50) null,
str_email varchar (50) null,
str_bio varchar (50) null,
int_public_repos int null,
int_followers int null,
int_following int null,
dt_CreatedAt Date null,
dt_UpdateAt Date null
, CONSTRAINT FK_Employee FOREIGN KEY (fk_int_Employee)
        REFERENCES Employee (pk_int_Employee))

insert into Employee values ('Guilherme Chenci Ortiz','Guicortiz','Guicortiz','16993247388','1998-01-28 00:00:00',GETDATE(),null)
insert into Employee values ('Luan Morais de Brito','luanmbrito','luanmbrito','16991237586','1998-05-15 00:00:00',GETDATE(),null)
insert into Employee values ('Victor Hugo Zanoello','zanoello03','zanoello03','16993458545','1998-12-18 00:00:00',GETDATE(),null)

SELECT pk_int_Employee,str_Name,str_Github,str_linkedin,str_Fone,dt_Birthday FROM Employee