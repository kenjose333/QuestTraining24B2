CREATE TABLE courses(
std_id INT PRIMARY KEY,
name VARCHAR(50) NOT NULL,
courses VARCHAR(50) NOT NULL,
fees INT NOT NULL
)
INSERT INTO courses 
(std_id,name,courses,fees)
VALUES
(1,'Ken','CS',5000),
(2,'Jose','CE',2000),
(3,'Mathew','CH',1000),
(4,'Catherine','CS',7000),
(5,'Rahul','CE',2000),
(6,'Kevin','CS',3000)

SELECT courses,count(std_id) AS number_of_students_enrolled FROM courses GROUP BY courses;
SELECT courses,sum(fees) AS total_fees_collected FROM courses GROUP BY courses;
SELECT TOP 1 courses,count(std_id) AS no_of_students_enrolled FROM courses GROUP BY courses ORDER BY count(std_id) DESC;

