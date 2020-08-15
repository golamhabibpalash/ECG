create table pqrstData
(
Id int not null primary key identity,
PData int,
QData int,
RData int,
SData int,
TData int,
PatientId int
)

create table PDataTable
(
Id int not null primary key identity,
Value int,
CycleNo int,
DayCount int,
Date date,
PatientId int
)


create table QDataTable
(
Id int not null primary key identity,
Value int,
CycleNo int,
DayCount int,
Date date,
PatientId int
)


create table RDataTable
(
Id int not null primary key identity,
Value int,
CycleNo int,
DayCount int,
Date date,
PatientId int
)


create table SDataTable
(
Id int not null primary key identity,
Value int,
CycleNo int,
DayCount int,
Date date,
PatientId int
)


create table TDataTable
(
Id int not null primary key identity,
Value int,
CycleNo int,
DayCount int,
Date date,
PatientId int
)


create table PatientTable
(
Id int not null primary key identity,
Name int,
NID int,
Age int,
pqrstDataId int,
Gender varchar(10)
)