create database chaitanya;

use chaitanya;
create table person(name varchar(20),age int,address varchar(200));
create table employee(id int, address varchar(100), name varchar(100),salary double, joindate date );
create table student(rollno int,address varchar(100), marks int, grade char);

alter table student add column(name varchar(100));

insert into person(name,age,address) values("chaitanya",12,"gangapur road");
INSERT INTO person(name, age, address) VALUES 
("Chaitanya", 12, "Gangapur Road"),
("Aarav", 25, "MG Road"),
("Vivaan", 30, "Brigade Road"),
("Aditya", 22, "Indiranagar"),
("Ananya", 28, "Whitefield"),
("Ishaan", 35, "Koramangala"),
("Saanvi", 27, "HSR Layout"),
("Vihaan", 23, "Sarjapur Road"),
("Avni", 26, "Electronic City"),
("Kavya", 31, "Bannerghatta Road");

insert into employee1(eid,address,name,salary,joindate) values(12,"gangapur road","chaitnyaa",12000,"2003-12-22");
INSERT INTO employee (id, address, name, salary, joindate) VALUES
(12, "gangapur road", "chaitnyaa", 12000, "2003-12-22"),
(13, "MG Road", "Aarav", 15000, "2005-03-15"),
(14, "Park Street", "Mira", 18000, "2006-07-18"),
(15, "Baner Road", "Karthik", 20000, "2008-01-20"),
(16, "Laxmi Road", "Radha", 17000, "2010-05-12"),
(17, "Sinhagad Road", "Vikram", 22000, "2012-09-25"),
(18, "FC Road", "Sneha", 21000, "2014-11-30"),
(19, "Law College Road", "Ravi", 19000, "2016-02-28"),
(20, "Karve Road", "Priya", 16000, "2018-06-17"),
(21, "Shivaji Nagar", "Ankit", 25000, "2020-04-22");

insert into student(rollno,name,address, marks, grade) values (1,"chaitanya","gangapur road",120,'B');
INSERT INTO student (rollno, name, address, marks, grade) VALUES (13, "Aarav", "MG Road", 135, 'A');
INSERT INTO student (rollno, name, address, marks, grade) VALUES (14, "Bhavya", "Kothrud", 110, 'B');
INSERT INTO student (rollno, name, address, marks, grade) VALUES (15, "Diya", "Baner Road", 125, 'B');
INSERT INTO student (rollno, name, address, marks, grade) VALUES (16, "Eshan", "Hadapsar", 145, 'A');
INSERT INTO student (rollno, name, address, marks, grade) VALUES (17, "Fariha", "Shivaji Nagar", 115, 'B');
INSERT INTO student (rollno, name, address, marks, grade) VALUES (18, "Gaurav", "Viman Nagar", 130, 'A');
INSERT INTO student (rollno, name, address, marks, grade) VALUES (19, "Hina", "Kalyani Nagar", 105, 'C');
INSERT INTO student (rollno, name, address, marks, grade) VALUES (20, "Ishanvi", "Wakad", 140, 'A');
INSERT INTO student (rollno, name, address, marks, grade) VALUES (21, "Jay", "Hinjewadi", 125, 'B');
INSERT INTO student (rollno, name, address, marks, grade) VALUES (22, "Karan", "Aundh", 150, 'A');

select * from person;
select * from student;
select * from employee1;

select * from employee where (salary>20000);
select sum(salary) from employee;
select avg(salary) from employee;

create table employee1(eid int Primary key, address varchar(100), name varchar(100),salary double, joindate date );
describe employee1;
create table department( dept_id int ,dept_name varchar(100),dept_hod varchar(100));

truncate table employee1;
truncate table department;

alter table department add foreign key(id) references employee1(eid);
describe department;
describe employee1;

INSERT INTO department (dept_id, dept_name, dept_hod,id) VALUES (22, "IT", "Aundh",12);
INSERT INTO department (dept_id, dept_name, dept_hod,id) VALUES (22, "IT", "Aundh",1);
insert into employee1(eid,address,name,salary,joindate) values(1,"gangapur road","chaitnyaa",12000,"2003-12-22");

select * from department;

SELECT *
FROM Employee1,department where Employee1.eid=department.id;

SELECT *
FROM Employee1
JOIN department ON Employee1.eid=department.id;

