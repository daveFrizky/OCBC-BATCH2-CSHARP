CREATE DATABASE db_bank;
USE db_bank;

CREATE TABLE customers(
	customersNumber int PRIMARY KEY NOT NULL,
	customerName varchar(50) NOT NULL,
	contactLastName varchar(50) NULL,
	contactFirstName varchar(50) NULL,
	phone varchar(13) NULL,
	addressLine1 varchar(50) NULL,
	addressLine2 varchar(50) NULL,
	city varchar(50) NULL,
	state varchar(50) NULL,
	postalCode int NULL,
	country varchar(50) NULL,
	salesRepEmployeeNumber int NULL,
	creditLimit int NULL
);

CREATE TABLE employees(
	employeeNumber int PRIMARY KEY NOT NULL,
	lastName varchar(50) NULL,
	firstName varchar(50) NULL,
	extension varchar(50) NULL,
	email varchar(50) NULL,
	officeCode nchar(10) NULL,
	reportsTo int NULL,
	jobTitle varchar(50) NULL
);

CREATE TABLE offices(
	officeCode nchar(10) PRIMARY KEY NOT NULL,
	city varchar(50) NULL,
	phone varchar(13) NULL,
	addressLine1 varchar(50) NULL,
	addressLine2 varchar(50) NULL,
	state varchar(50) NULL,
	country varchar(50) NULL,
	postalCode int NULL,
	territory varchar(50) NULL
);

CREATE TABLE orderdetails(
	orderNumber int NULL,
	productCode nchar(10) NULL,
	quantityOrdered int NULL,
	priceEach money NULL,
	orderLineNumber int NULL
) ;

CREATE TABLE orders(
	orderNumber int PRIMARY KEY NOT NULL,
	orderDate date NULL,
	requiredDate date NULL,
	shippedDate date NULL,
	[status] char(1) NULL,
	comments varchar(50) NULL,
	customerNumber int NULL
);

CREATE TABLE payments(
	customerNumber int NOT NULL,
	checkNumber int PRIMARY KEY NOT NULL,
	paymentDate date NULL,
	amount int NULL
);

CREATE TABLE productlines(
	productLine int PRIMARY KEY NOT NULL,
	textDescription varchar(50) NULL,
	htmlDescription varchar(50) NULL,
	[image] varchar(200) NULL
);

CREATE TABLE products(
	productCode nchar(10) PRIMARY KEY NOT NULL,
	productName varchar(50) NULL,
	productLine int NOT NULL,
	productScale int NULL,
	productVendor varchar(50) NULL,
	productDescription varchar(200) NULL,
	quantityInStock int NULL,
	buyPrice money NULL,
	MSRP money NULL
);


INSERT customers VALUES 
(1,'Devi Anjani','Anjani','Devi','081232132137','Jl. cempaka no.3','Jl. kuningan no.1','Bandung','Jawa Barat', 60111,'Indonesia', 1, 3),
(2,'Budi Doremi','Doremi','Budi','08213123224','Jl. bubutan no.4','Jl. kembang no.2','Bandung','Jawa Barat', 60112,'Indonesia', 2, 4),
(3,'Jaya marifah','marifah','Jaya','089253523622','Jl. durian no.5','Jl. Bina no.3','Bandung','Jawa Barat', 60113,'Indonesia', 3, 6),
(4,'Joko Bodo','Bodo','Joko','081525362362','Jl. apel no.6','Jl. bangsa no.4','Bandung','Jawa Barat', 60114,'Indonesia', 4, 2),
(5,'Nina Bulema','Bulema','Nina','08253636373','Jl. bekam no.7','Jl. lembah no.5','Bandung','Jawa Barat', 60115,'Indonesia', 5, 1),
(6,'Vina Pandu','Pandu','Vina','089635435463','Jl. lembayung no.8','Jl. dukuh no.6','Bandung','Jawa Barat', 60114,'Indonesia', 6, 4),
(7,'Panji sujiwo','Sujiwo','Panji','085232732737','Jl. indragiri no.9','Jl. kuningan no.7','Bandung','Jawa Barat', 60114,'Indonesia', 7, 6),
(8,'Dika rahaja','Rahaja','Dika','081734343628','Jl. kepanjen no.10','Jl. kembali no.8','Bandung','Jawa Barat', 60113,'Indonesia', 8, 3),
(9,'Ben Sukamoto','Sukamoto','Be','081229936372','Jl. darmo no.11','Jl. kuningan no.9','Bandung','Jawa Barat', 60113,'Indonesia', 9, 5),
(10,'Dio Semani','Semani','Dio','081666373838','Jl. husada no.12','Jl. asiwan no.10','Bandung','Jawa Barat', 60111,'Indonesia', 10, 4);

INSERT employees VALUES 
(1,'Besos','Jeff', NULL,'jeff@gmail.com','A01', 1,'Manager'),
(2,'Marie','Rene', NULL,'Rene@gmail.com','A02', 10,'Staff'),
(3,'Sanjaya','Kevi', NULL,'Kevin@gmail.com','A03', 1,'Branch Manager'),
(4,'Susilo','Anji', NULL,'Anji@gmail.com','A04', 4,'HRD'),
(5,'William','Boy', NULL,'Boy@gmail.com','A05', 1,'Marketing'),
(6,'Hawk','Stephe', NULL,'Stephen@gmail.com','A06', 1,'IT Head'),
(7,'Anderso','Shau', NULL,'Shaun@gmail.com','A07', 6,'IT Support'),
(8,'Bobby','Cloud', NULL,'Cloud@gmail.com','A08', 5,'Sales'),
(9,'Margaret','Stevie', NULL,'Stevie@gmail.com','A09', 1,'Head Sales'),
(10,'Kinasi','Putri', NULL,'Putri@gmail.com','A10', 1,'Head Staff');

INSERT offices VALUES 
('A01','Bandung','72399921','Jl. Diponegoro', NULL,'Jawa Barat','Indonesia', 60113,'Mandeu'),
('A02','Bandung','72399919','Jl. Mawar','Jl. Sudirman','Jawa Barat','Indonesia', 60110, NULL),
('A03','Bandung','72399917','Jl. Diponegoro','Jl.Bojong','Jawa Barat','Indonesia', 60107,'Owned'),
('A04','Bandung','72399915','Jl. Melati','Jl.Cendrawasih','Jawa Barat','Indonesia', 60104, NULL),
('A05','Bandung','72399913','Jl. Diponegoro','Jl. Maca','Jawa Barat','Indonesia', 60101,'Owned'),
('A06','Bandung','72399911','Jl. Pari','Jl.Wayang','Jawa Barat','Indonesia', 60098, NULL),
('A07','Bandung','72399909','Jl. Diponegoro', NULL,'Jawa Barat','Indonesia', 60095,'Owned'),
('A08','Bandung','72399907','Jl. Opak','Jl.Waru','Jawa Barat','Indonesia', 60092, NULL),
('A09','Bandung','72399905','Jl. Kamboja', NULL,'Jawa Barat','Indonesia', 60089,'Owned'),
('A10','Bandung','72399903','Jl. Sepatu', NULL,'Jawa Barat','Indonesia', 60086,'Owned');

INSERT orderdetails VALUES 
(2,'P002', 30, 15000000.0000, 3),
(3,'P003', 10, 17000000.0000, 4),
(4,'P004', 5, 19000000.0000, 5),
(5,'P005', 3, 21000000.0000, 6),
(6,'P006', 2, 23000000.0000, 10),
(7,'P007', 1, 25000000.0000, 12),
(8,'P008', 8, 27000000.0000, 11),
(9,'P009', 7, 29000000.0000, 7),
(10,'P010', 5, 31000000.0000, 8),
(1,'P001', 3, 13000000.0000, 2);

INSERT orders VALUES 
(1, '2020-06-06' , '2020-06-06' , '2020-06-07' ,'1','On the way', 1),
(2, '2020-06-07' , '2020-06-06' , '2020-06-08' ,'1','Finished', 2),
(3, '2020-06-08' , '2020-06-07' , '2020-06-09' ,'1','On the way', 3),
(4, '2020-06-09' , '2020-06-08' , '2020-06-10' ,'1','On the way', 4),
(5, '2020-06-10' , '2020-06-09' , '2020-06-11' ,'1','On the way', 5),
(6, '2020-06-11' , '2020-06-10' , '2020-06-12' ,'1','Finished', 6),
(7, '2020-06-12' , '2020-06-11' , '2020-06-13' ,'1','On the way', 7),
(8, '2020-06-13' , '2020-06-12' , '2020-06-14' ,'1','Finished', 8),
(9, '2020-06-14' , '2020-06-13' , '2020-06-15' ,'1','On the way', 9),
(10, '2020-06-15' , '2020-06-14' , '2020-06-16' ,'1','Pending', 10);

INSERT payments VALUES 
(1, 1, '2020-09-09' , 10000000),
(2, 2, '2020-09-10' , 20000000),
(3, 3, '2020-09-11' , 30000000),
(4, 4, '2020-09-12' , 40000000),
(5, 5, '2020-09-13' , 50000000),
(6, 6, '2020-09-14' , 60000000),
(7, 7, '2020-09-15' , 70000000),
(8, 8, '2020-09-16' , 80000000),
(9, 9, '2020-09-17' , 90000000),
(10, 10, '2020-09-18' , 100000000);

INSERT productlines VALUES 
(1, 'Big and heavy', 'Line1.html','image1.jpg'),
(2, 'Big and Light', 'Line2.html','image2.jpg'),
(3, 'Carefull', 'Line3.html', 'image3.jpg'),
(4, 'Big and heavy','Line4.html','image4.jpg'),
(5, 'Big and Light','Line5.html','image5.jpg'),
(6, 'Carefull','Line6.html','image6.jpg'),
(7, 'Big and heavy','Line7.html','image7.jpg'),
(8, 'Big and Light','Line8.html','image8.jpg'),
(9, 'Carefull','Line9.html','image9.jpg'),
(10,'Big and heavy','Line10.html','image10.jpg');

INSERT products VALUES 
('P001','Honda Supra', 1, 2,'Honda','Sepeda Motor', 4, 10000000.0000, 13000000.0000),
('P002','Kawasaki Ninja', 2, 5,'Kawasaki','Sepeda Motor', 5, 12000000.0000, 15000000.0000),
('P003','Yamaha Mio', 3, 3,'Yamaha','Sepeda Motor', 6, 14000000.0000, 17000000.0000),
('P004','Honda Beat', 4, 6,'Honda ','Sepeda Motor', 2, 16000000.0000, 19000000.0000),
('P005','Kawasaki Ninja RR', 5, 2,'Kawasaki','Sepeda Motor', 3, 18000000.0000, 21000000.0000),
('P006','Yamaha Xeo', 6, 8,'Yamaha','Sepeda Motor', 8, 20000000.0000, 23000000.0000),
('P007','Honda PCX', 7, 9,'Honda Supra','Sepeda Motor', 5, 22000000.0000, 25000000.0000),
('P008','Kawasaki Blitz', 8, 5,'Kawasaki','Sepeda Motor', 9, 24000000.0000, 27000000.0000),
('P009','Yamaha Nmax', 9, 3,'Yamaha','Sepeda Motor', 3, 26000000.0000, 29000000.0000),
('P010','Honda CB', 10, 5,'Honda ','Sepeda Motor', 1, 28000000.0000, 31000000.0000);

ALTER TABLE customers ADD CONSTRAINT FK_customers_employees FOREIGN KEY(salesRepEmployeeNumber)
REFERENCES employees (employeeNumber);

ALTER TABLE employees ADD CONSTRAINT FK_employees_employees FOREIGN KEY (reportsTo)
REFERENCES employees (employeeNumber);

ALTER TABLE employees ADD CONSTRAINT FK_employees_offices FOREIGN KEY(officeCode)
REFERENCES offices (officeCode);

ALTER TABLE orderdetails ADD CONSTRAINT FK_orderdetails_orders FOREIGN KEY(orderNumber)
REFERENCES orders (orderNumber);

ALTER TABLE orderdetails ADD CONSTRAINT FK_orderdetails_products FOREIGN KEY(productCode)
REFERENCES products (productCode);

ALTER TABLE orders ADD CONSTRAINT FK_orders_customers FOREIGN KEY(customerNumber)
REFERENCES customers (customersNumber);

ALTER TABLE payments ADD CONSTRAINT FK_payments_customers FOREIGN KEY(customerNumber)
REFERENCES customers (customersNumber);

ALTER TABLE products ADD CONSTRAINT FK_products_productlines FOREIGN KEY(productLine)
REFERENCES productlines (productLine);

