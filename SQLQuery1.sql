create database Gym

create table Logiin
(

 Username varchar(50) Not null,
 Passwordd varchar(50) Not null

 );
 
 create table NewMember
(
   MID int NOT NULL IDENTITY(1,1) primary key,
   Fname varchar(150) NOT NULL,
   Lname varchar(150) NOT NULL,
   Gender varchar(20) NOT NULL,
   Dob varchar(100) NOT NULL,
   Mobile bigint NOT NULL,
   Email varchar(150) NOT NULL,
   JoinDate varchar(100) NOT NULL,
   Gymtime varchar(120) NOT NULL,
   Maddress varchar(250) NOT NULL,
   MembershipTime varchar(120) NOT NULL
  
 );


  create table NewStaff
(
   SID int NOT NULL IDENTITY(1,1) primary key,
   Fname varchar(150) NOT NULL,
   Lname varchar(150) NOT NULL,
   Gender varchar(20) NOT NULL,
   Dob varchar(100) NOT NULL,
   Mobile bigint NOT NULL,
   Email varchar(150) NOT NULL,
   JoinDate varchar(100) NOT NULL,
   Statee varchar(100) NOT NULL,
   City varchar(100) NOT NULL
  
  
 );

  create table Equipment
(
   EID int NOT NULL IDENTITY(1,1) primary key,
   Equipname varchar(250) NOT NULL,
   EDescription varchar(450) NOT NULL,
   MUsed varchar(250) NOT NULL,
   DDate varchar(150) NOT NULL,
   Cost bigint NOT NULL

 );
 


 select * from NewMember;