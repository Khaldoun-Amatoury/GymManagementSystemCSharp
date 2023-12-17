create table NewStaff
(
SID int not null IDENTITY(1,1) primary key,
Fname varchar(150) Not null,
Lname varchar(150) Not null,
Gender varchar(20) Not null,
Dob varchar(100) Not null,
Mobile bigint not null,
Email varchar(150),
JoinDate varchar(100) Not null,
Statee varchar(100) Not null,
City varchar(100) Not null
);