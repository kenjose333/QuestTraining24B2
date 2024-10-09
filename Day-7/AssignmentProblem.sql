create table student(
  id int primary key identity,
  name varchar(10)
);

insert into student (name) values
('Ken'),
('Jose'),
('Mathew'),
('Kevin'),
('Catherine');

create table subjects(
  id int primary key identity,
  sub_code varchar(6),
  subject varchar(50)
);

insert into subjects (sub_code, subject) values
('CST101','Maths'),
('CST201','Chemistry'),
('CST305','Biology'),
('HUN404','English');

create table exam(
  id int primary key identity,
  exam_name varchar(10),
  min_marks int,
  max_marks int,
);

insert into exam (exam_name, min_marks, max_marks) values
('Quarter',10,25),
('Half',20,50),
('END',45,100);

create table marks(
  id int primary key identity,
  std_id int,
  sub_id int,
  exam int,
  marks int,
  
  CONSTRAINT fk_std_id FOREIGN KEY (std_id) REFERENCES student(id),
  CONSTRAINT fk_sub_id FOREIGN KEY (sub_id) REFERENCES subjects(id),
  CONSTRAINT fk_exam_id FOREIGN KEY (exam) REFERENCES exam(id)
);

INSERT INTO marks (std_id, sub_id, exam, marks) VALUES
(1,2,1,17),  
(2,2,2,44), 
(3,4,2,33),  
(4,1,3,78),
(5,3,2,90);  

select 
student.id,
subjects.subject,
marks.marks,
exam.exam_name
from 
marks 
inner join 
student on marks.std_id = student.id
inner join
subjects on marks.sub_id = subjects.id
inner join 
exam on marks.exam = exam.id;