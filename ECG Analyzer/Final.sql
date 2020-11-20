create table pqrst
(
Id int not null identity(1,1) primary key,
patientId int,
TestDate  datetime,
Cycle  int,
DayCount  int,
PData int,
QData int,
RData int,
SData int,
TData int
)

select * from pqrst