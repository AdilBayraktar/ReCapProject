create table Color(ColorId int primary key not null , ColorName varchar);
create table Brand (BrandId int primary key not null , BrandName varchar);
create table Car( CarId int primary key not null , BrandId int references Brand(BrandId) ,
ColorId int references Color(ColorId) , ModelYear varchar , DailyPrice decimal , CarDescription varchar
);
