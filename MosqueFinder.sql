select * from General_Profile


create table Recruiters
(
 Name varchar(60) primary key,
 Email varchar(60),
 Phone varchar(60),
 Address varchar(60),
 District varchar(60),
 Area varchar(60),
 Picture Image
);

select * from Recruiters

create table Applicants
(
 Name varchar(60) primary key,
 Email varchar(60),
 Phone varchar(60),
 Address varchar(60),
 District varchar(60),
 Area varchar(60),
 Picture Image
);

select * from Applicants

create table Generals
(
 Name varchar(60) primary key,
 Email varchar(60),
 Phone varchar(60),
 Address varchar(60),
 District varchar(60),
 Area varchar(60),
 Picture Image
);

select * from Generals

create table Doners
(
 Name varchar(60) primary key,
 District varchar(60),
 Area varchar(60),
 Mosque varchar(60),
 Amount varchar(60),
 Via varchar(60)
);

select * from Recruiter_SignUp

insert into Nearby_Mosque values('Baitul Mahfuz Jame Masjid','Dhaka','Nikunjo-2');

select * from Nearby_Mosque where District='Manikganj' and Area='Banagram'


select * from General_Pofile

select * from Apply where ApplyAs='Imam'and District='Manikganj'  