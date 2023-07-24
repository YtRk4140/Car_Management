  Create Database MyStock
  Use MyStock

  Drop table Cars
  Create table Cars
		(CarID int primary key, CarName nvarchar(20) not null, Manufacturer nvarchar(20) not null, Price money not null, ReleaseYear int not null)

  Insert into Cars (CarID, CarName, Manufacturer, Price, ReleaseYear) Values
		('1', 'Accord', 'Honda Motor Company', '24970', '2021'),
		('2', 'Clarity', 'Honda Motor Company', '33400', '2021'),
		('3', 'BMW 8 Series', 'BMW', '85000', '2021'),
		('4', 'Audi A6', 'Audi', '14000', '2020')

	select * from Cars
  