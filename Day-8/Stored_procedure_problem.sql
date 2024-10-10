CREATE TABLE suppliers
(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(30) NOT NULL,
	contact_person VARCHAR(50) NOT NULL,
	phone BIGINT NOT NULL,
	email VARCHAR(50) NOT NULL,
	address VARCHAR(50) NOT NULL
)



CREATE TABLE medications
(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50) NOT NULL,
	category VARCHAR(30) NOT NULL,
	price DECIMAL(5,2) NOT NULL,
	exp_date DATE,
	supplier_id INT UNIQUE,
	stock_quantity INT
	CONSTRAINT FK_medications_suppliers_id
	FOREIGN KEY(supplier_id) REFERENCES suppliers(id)
)
 CREATE TABLE customers
 (
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50) NOT NULL,
	phone BIGINT NOT NULL,
	email VARCHAR(50) NOT NULL,
	address VARCHAR(50) NOT NULL
)

CREATE TABLE sales
(
	id INT PRIMARY KEY IDENTITY,
	customer_id INT NOT NULL,
	medication_id INT NOT NULL,
	quantity BIGINT NOT NULL,
	sale_date DATE,
	total_price decimal(5,2),

	CONSTRAINT FK_sales_customers_id 
	FOREIGN KEY (customer_id) REFERENCES customers(id),
	CONSTRAINT FK_sales_medications_id 
	FOREIGN KEY (medication_id) REFERENCES medications(id)
)

CREATE TABLE inventory
(
	id INT PRIMARY KEY IDENTITY,
	medication_id INT NOT NULL,
	supplier_id INT NOT NULL,
	stock_in BIGINT,
	stock_out BIGINT,
	date_added DATE,
	CONSTRAINT FK_inventory_medications_id 
	FOREIGN KEY (medication_id) REFERENCES medications(id),
	CONSTRAINT FK_inventory_supplier_id 
	FOREIGN KEY (supplier_id) REFERENCES suppliers(id)
)
GO
CREATE PROCEDURE sp_suppliers
(
	@Name VARCHAR(30),
	@Contact_person VARCHAR(50),
	@Phone BIGINT,
	@Email VARCHAR(50),
	@Address VARCHAR(50)
)
AS
BEGIN
	INSERT INTO suppliers(name,contact_person,phone,email,address)
	VALUES( @Name,@Contact_person,@Phone,@Email,@Address);
END
EXEC sp_suppliers 
    @Name = 'Global Pharma', 
    @Contact_person = 'Alice Williams', 
    @Phone = 9876543210, 
    @Email = 'alice.williams@globalpharma.com', 
    @Address = '100 Oak St';

EXEC sp_suppliers 
    @Name = 'MediCare Inc.', 
    @Contact_person = 'Bob Johnson', 
    @Phone = 9876543211, 
    @Email = 'bob.johnson@medicare.com', 
    @Address = '200 Pine Ave';

EXEC sp_suppliers 
    @Name = 'LifeHealth', 
    @Contact_person = 'Carol White', 
    @Phone = 9876543212, 
    @Email = 'carol.white@lifehealth.com', 
    @Address = '300 Maple Blvd';

EXEC sp_suppliers 
    @Name = 'Wellness Pharmacy', 
    @Contact_person = 'David Green', 
    @Phone = 9876543213, 
    @Email = 'david.green@wellnesspharmacy.com', 
    @Address = '400 Cedar Dr';

EXEC sp_suppliers 
    @Name = 'Health Essentials', 
    @Contact_person = 'Eve Brown', 
    @Phone = 9876543214, 
    @Email = 'eve.brown@healthessentials.com', 
    @Address = '500 Birch Rd';
GO 
CREATE PROCEDURE sp_medications
(
	@Name VARCHAR(50),
	@Category VARCHAR(30),
	@Price DECIMAL(5,2),
	@Exp_date DATE,
	@Supplier_id INT,
	@Stock_quantity INT
)
AS
BEGIN
	INSERT INTO medications(name,category,price,exp_date,supplier_id,stock_quantity)
	VALUES (@Name,@Category,@Price,@EXP_date,@Supplier_id,@Stock_quantity);
END
EXEC sp_medications 
    @Name = 'Aspirin', 
    @Category = 'Pain Reliever', 
    @Price = 12.50, 
    @Exp_date = '2025-08-15', 
    @Supplier_id = 1, 
    @Stock_quantity = 100;

EXEC sp_medications 
    @Name = 'Amoxicillin', 
    @Category = 'Antibiotic', 
    @Price = 25.00, 
    @Exp_date = '2024-12-01', 
    @Supplier_id = 2, 
    @Stock_quantity = 50;

EXEC sp_medications 
    @Name = 'Metformin', 
    @Category = 'Diabetes', 
    @Price = 15.75, 
    @Exp_date = '2025-05-20', 
    @Supplier_id = 3, 
    @Stock_quantity = 200;

EXEC sp_medications 
    @Name = 'Ibuprofen', 
    @Category = 'Pain Reliever', 
    @Price = 8.90, 
    @Exp_date = '2026-02-11', 
    @Supplier_id = 4, 
    @Stock_quantity = 150;

EXEC sp_medications 
    @Name = 'Lisinopril', 
    @Category = 'Blood Pressure', 
    @Price = 20.00, 
    @Exp_date = '2024-09-30', 
    @Supplier_id = 5, 
    @Stock_quantity = 120;
 GO
 CREATE PROCEDURE sp_customers
 (
	@Name VARCHAR(50),
	@Phone BIGINT,
	@Email VARCHAR(50),
	@Address VARCHAR(50)
)
AS 
BEGIN
	INSERT INTO customers(name,phone,email,address)
	VALUES(@Name,@Phone,@Email,@Address);
END
EXEC sp_customers @Name='John Smith', @Phone=9876543210, @Email='john.smith@email.com', @Address='123 Main St';
EXEC sp_customers @Name='Emily Clark', @Phone=9876543211, @Email='emily.clark@email.com', @Address='456 Oak Ave';
EXEC sp_customers @Name='Michael Brown', @Phone=9876543212, @Email='michael.brown@email.com', @Address='789 Pine Blvd';
EXEC sp_customers @Name='Sarah Johnson', @Phone=9876543213, @Email='sarah.johnson@email.com', @Address='321 Elm St';
EXEC sp_customers @Name='David Miller', @Phone=9876543214, @Email='david.miller@email.com', @Address='654 Maple Ave';

GO
CREATE PROCEDURE sp_sales
(
	@Customer_id INT,
	@Medication_id INT,
	@Quantity BIGINT,
	@Sale_date DATE,
	@Total_price decimal(5,2)
)
AS
BEGIN
	INSERT INTO sales(customer_id,medication_id,quantity,sale_date,total_price)
	VALUES (@Customer_id,@Medication_id,@Quantity,@Sale_date,@Total_price);
END
EXEC sp_sales @Customer_id = 1, @Medication_id = 2, @Quantity = 3, @Sale_date = '2024-10-01', @Total_price = 37.50;
EXEC sp_sales @Customer_id = 2, @Medication_id = 1, @Quantity = 5, @Sale_date = '2024-10-02', @Total_price = 62.50;
EXEC sp_sales @Customer_id = 3, @Medication_id = 3, @Quantity = 2, @Sale_date = '2024-10-03', @Total_price = 31.50;
EXEC sp_sales @Customer_id = 1, @Medication_id = 4, @Quantity = 4, @Sale_date = '2024-10-04', @Total_price = 80.00;
EXEC sp_sales @Customer_id = 4, @Medication_id = 5, @Quantity = 1, @Sale_date = '2024-10-05', @Total_price = 20.00;

GO
CREATE PROCEDURE sp_inventory
(
	@Medication_id INT,
	@Supplier_id INT,
	@Stock_in BIGINT,
	@Stock_out BIGINT,
	@Date_added DATE
)
AS
BEGIN
	INSERT INTO inventory(medication_id,supplier_id,stock_in,stock_out,date_added)
	VALUES(@Medication_id,@Supplier_id,@Stock_in,@Stock_out,@Date_added);
END
EXEC sp_inventory @Medication_id = 1, @Supplier_id = 1, @Stock_in = 100, @Stock_out = 20, @Date_added = '2024-10-01';
EXEC sp_inventory @Medication_id = 2, @Supplier_id = 2, @Stock_in = 150, @Stock_out = 30, @Date_added = '2024-10-02';
EXEC sp_inventory @Medication_id = 3, @Supplier_id = 3, @Stock_in = 200, @Stock_out = 50, @Date_added = '2024-10-03';
EXEC sp_inventory @Medication_id = 4, @Supplier_id = 1, @Stock_in = 120, @Stock_out = 15, @Date_added = '2024-10-04';
EXEC sp_inventory @Medication_id = 5, @Supplier_id = 4, @Stock_in = 80, @Stock_out = 10, @Date_added = '2024-10-05';


