CREATE TABLE categories(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(25) NOT NULL UNIQUE,
)
INSERT INTO categories VALUES 
('Uncategorised'),
('Electronic'),
('Phone')
--CREATE TABLE product_categories(
	id BIGINT PRIMARY KEY IDENTITY,
	--category_id INT,
	--product_id BIGINT,
	--CONSTRAINT FK_category_id FOREIGN KEY (category_id) REFERENCES categories(id),
	--CONSTRAINT FK_product_id FOREIGN KEY (product_id) REFERENCES products(id)
	--)
CREATE TABLE product(
	id BIGINT IDENTITY PRIMARY KEY,
	Fname VARCHAR(100) NOT NULL,
	discripton TEXT,
	price DECIMAL(10,2) NOT NULL CHECK(price<0),
	stock_quantity INT NOT NULL DEFAULT 0,
	created_at DATETIME2 DEFAULT GETDATE()
);