create table ProductCategory(
	CategoryId integer primary key identity,
	Name varchar(150) not null,
	Description varchar(256) not null,
	Inactive bit not null default 0,
	CreatedBy varchar(60) default user, 
	CreatedAt datetime DEFAULT getdate(),
	LastUpdateBy varchar(60) default user,
	LastUpdateAt datetime  default getdate(),
);


create table ProductSubCategory(
	SubCategoryId integer primary key identity,
    CategoryId integer not null, 
	Name varchar(150) not null,
	Description varchar(256) not null,
	Inactive bit not null default 0,
	CreatedBy varchar(60) default user, 
	CreatedAt datetime DEFAULT getdate(),
	LastUpdateBy varchar(60) default user,
	LastUpdateAt datetime  default getdate(),

	foreign key (CategoryId) references ProductCategory(CategoryId)
);


create table Product(
	ProductId integer primary key identity,
	SubCategoryId integer not null,
	Name varchar(150) not null,
	Description varchar(256) not null,
	BarCode varchar(127),
	Reference bit not null,
	HasLength bit not null,
	HasHeight bit not null,
	HasWide   bit not null,
	HasCapacity bit not null,
	Inactive bit not null default 0,
	CreatedBy varchar(60) default user, 
	CreatedAt datetime DEFAULT getdate(),
	LastUpdateBy varchar(60) default user,
	LastUpdateAt datetime  default getdate(),

	foreign key (SubCategoryId) references ProductSubCategory(SubCategoryId)
)



