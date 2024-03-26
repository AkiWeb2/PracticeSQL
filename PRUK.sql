use PRUK2;

create table Defendant(
ID_Defandant int IDENTITY(1,1) NOT NULL,
FIO varchar(50) NOT NULL,
Passport int NOT NULL,
PlaceOfLiving varchar(90) NOT NULL,
Phone varchar(50) NOT NULL,
PRIMARY KEY (ID_Defandant)
);

create table Victim(
ID_Victim int IDENTITY(1,1) NOT NULL,
FIO varchar(50) NOT NULL,
Passport int NOT NULL,
PlaceOfLiving varchar(90) NOT NULL,
Phone varchar(50) NOT NULL,
PRIMARY KEY (ID_Victim)
);

create table Investigator(
ID_Investigator int IDENTITY(1,1) NOT NULL,
FIO varchar(50) NOT NULL,
Phone varchar(50) NOT NULL,
PRIMARY KEY (ID_Investigator)
);

create table Advocate(
ID_Advocate int IDENTITY(1,1) NOT NULL,
FIO varchar(50) NOT NULL,
Phone varchar(50) NOT NULL,
PRIMARY KEY (ID_Advocate)
);

create table Court(
ID_Court int IDENTITY(1,1) NOT NULL,
NameCourt varchar(60) NOT NULL,
PhoneCourt varchar(50) NOT NULL,
PRIMARY KEY (ID_Court)
);

create table CaseCourt(
ID_CaseCourt int IDENTITY(1,1) NOT NULL,
defandant int NOT NULL FOREIGN KEY  REFERENCES Defendant(ID_Defandant),
victim int NOT NULL FOREIGN KEY REFERENCES Victim(ID_Victim),
investigator int NOT NULL FOREIGN KEY  REFERENCES Investigator (ID_Investigator),
advocate int NOT NULL FOREIGN KEY  REFERENCES Advocate(ID_Advocate),
court int NOT NULL FOREIGN KEY  REFERENCES Court(ID_Court),
categories varchar(50) NOT NULL,
CategoriesOfConsideration varchar(50) NOT NULL,
PRIMARY KEY (ID_CaseCourt)
);

create table register(
IDReg int IDENTITY(1,1) NOT NULL,
Login varchar(30) NOT NULL,
PasswordReg varchar(30) NOT NULL,
PRIMARY KEY (IDReg)
);
insert into register (Login, PasswordReg) values ('Sled', '1111');
insert into register (Login, PasswordReg) values ('Dello', '2222');
insert into register (Login, PasswordReg) values ('Admin', '3333');