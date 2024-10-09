create table patients (
    id int identity primary key,
    first_name varchar(50) not null,
    last_name varchar(50) not null,
    gender char(1) check (gender IN ('M', 'F', 'O')), 
    age int check (age > 0 and age < 120),
    phone_number varchar(10),
    email varchar(60) unique NOT NULL,
    created_at datetime default getdate()
);
INSERT INTO patients (first_name, last_name, gender, age, phone_number, email) 
VALUES 
('John', 'Doe', 'M', 34, '9876543210', 'john.doe@example.com'),
('Jane', 'Smith', 'F', 29, '9123456789', 'jane.smith@example.com'),
('Alex', 'Johnson', 'O', 22, '9012345678', 'alex.johnson@example.com'),
('Emily', 'Davis', 'F', 45, '9234567890', 'emily.davis@example.com'),
('Michael', 'Brown', 'M', 55, '9345678901', 'michael.brown@example.com');

create table appointments (
    id int identity primary key,
    patient_id int not null,
    appointment_date date check (appointment_date >= CAST(GETDATE() AS DATE)), 
    appointment_time time not null,
    reason_for_visit varchar(100) not null,
    doctor_name varchar(100) not null,
    created_at datetime default getdate(),
    foreign key (patient_id) references patients(id) 
);
INSERT INTO appointments (patient_id, appointment_date, appointment_time, reason_for_visit, doctor_name)
VALUES
(1, '2024-10-15', '10:00:00', 'Routine checkup', 'Dr. Sarah Thompson'),
(2, '2024-10-16', '11:30:00', 'Follow-up for blood test', 'Dr. David Wilson'),
(3, '2024-10-17', '09:45:00', 'Consultation for headache', 'Dr. Emily Rodriguez'),
(4, '2024-10-18', '14:00:00', 'Back pain consultation', 'Dr. James Anderson'),
(5, '2024-10-19', '13:15:00', 'Skin rash checkup', 'Dr. Olivia Martin');
