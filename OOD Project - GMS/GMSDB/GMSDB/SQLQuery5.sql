create table Equipment
(
EID int not null IDENTITY(1,1) primary key,
EquipName varchar(250) not null,
EDescription varchar(450) not null,
MUsed varchar(250) not null,
DDate varchar(150) not null,
Cost bigint not null
);

