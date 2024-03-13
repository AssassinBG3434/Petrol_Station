CREATE TABLE Delivery(
	id int IDENTITY,
	PRIMARY KEY(id),
	name_ nvarchar(35),
	mol nvarchar(35),
	adress nvarchar(35),
	bulstat nvarchar(35)
);

CREATE TABLE Gas(
	id INT IDENTITY,
	PRIMARY KEY(id),
	type_ nvarchar(35)
);
CREATE TABLE GasTank(
	id INT IDENTITY,
	PRIMARY KEY(id),
	name_ varchar(10)
);
CREATE TABLE Gas_GasTank(
	id int IDENTITY,
	PRIMARY KEY (id),
	gasId int,
	FOREIGN KEY (gasId) REFERENCES Gas(id),
	gasTankId int,
	FOREIGN KEY (gasTankId) REFERENCES GasTank(id)

);
CREATE TABLE AllDelivered(
	id int IDENTITY,
	PRIMARY KEY (id),
	gasId int,
	FOREIGN KEY (gasId) REFERENCES Gas(id),
	deliveryId int,
	FOREIGN KEY (deliveryId) REFERENCES Delivery(id),
	quantity int,
	gasTankId int,
	FOREIGN KEY (gasTankId) REFERENCES GasTank(id),
	registerPlate nvarchar(35),
	driver nvarchar(35)
);
ALTER TABLE AllDelivered
ADD price decimal(5,2);

CREATE TABLE Price(
	id int IDENTITY,
	PRIMARY KEY (id),
	type_ nvarchar(35),
	price decimal(10,2)
);

CREATE TABLE Sold_Gas(
	id int IDENTITY,
	PRIMARY KEY(id),
	quantity decimal(10,2),
	date_ dateTime,
	sold_price decimal(10,2),
	type_ nvarchar(35),
	pump nvarchar(35)
);
INSERT INTO Delivery (name_,mol,adress,bulstat) VALUES ('demea','materialno otgovorno lice','adress','bulstat');
SELECT * FROM Delivery;
INSERT INTO Delivery (name_, mol, adress, bulstat)
VALUES (N'Иван Иванов', N'Иванович', N'ул. Цветна 5', N'123456789');

SELECT name_ FROM Delivery;
SELECT name_ FROM Delivery;

INSERT INTO Gas (type_) VALUES (N'газ');
INSERT INTO GasTank (name_) Values (3);
INSERT INTO Gas_GasTank (gasId,gasTankId) values (2,2);

INSERT INTO AllDelivered (gasId,deliveryId,quantity,gasTankId,registerPlate,driver,price) 
VALUES (2,1,1000,2,N'B 3453 TX',N'Иван',1.54);
SELECT * FROM AllDelivered;

SELECT (id) FROM GAS where (type_ = N'газ');