comment 'Lab 5'

1.
create table STUDENT(
	regno varchar(20),
	name varchar(50),
	major varchar(20),
	bdate date,
	primary key (regno));

create table COURSE (
	curse int,
	cname varchar(30),
	dept varchar(30),
	primary key (curse));

create table ENROLL (
	regno varchar(20),
	curse int,
	primary key (regno, curse),
	foreign key (regno) references STUDENT,
	foreign key (curse) references COURSE);

create table BOOK_ADOPTION (
	curse int,
	sem int,
	book_isbn int,
	primary key (curse, book_isbn),
	foreign key (curse) references COURSE,
	foreign key (book_isbn) references text);

create table TEXT (
	book_isbn int, 
	booktitle varchar(50), 
	publisher varchar(50), 
	author varchar(50),
	primary key(book_isbn));


2.
insert into student values('170953122', 'Tushar', 'CCE', date'1999-05-27');
insert into student values('170953128', 'Shreyas', 'CCE', date'1999-07-05');
insert into student values('170953130', 'Bhavya', 'CCE', date'1998-05-15');
insert into student values('170953212', 'Manik', 'CCE', date'1999-03-25');
insert into student values('170953164', 'Soumik', 'CCE', date'1999-09-18');
insert into student values('170953098', 'Meghana', 'CCE', date'1999-09-25');

insert into course values(1001, 'PSUC', 'CSE');
insert into course values(2203, 'ESD', 'ICT');
insert into course values(2358, 'IoT', 'ICT');
insert into course values(1101, 'EG1', 'MME');
insert into course values(1002, 'BME', 'MME');
insert into course values(3301, 'BET', 'EEE');

insert into enroll values('170953122', 2203);
insert into enroll values('170953128', 1001);
insert into enroll values('170953130', 2358);
insert into enroll values('170953212', 1101);
insert into enroll values('170953164', 1002);
insert into enroll values('170953122', 1002);
insert into enroll values('170953122', 3301);
insert into enroll values('170953164', 3301);

insert into text values(1234, 'Embedded Systems', 'Puffin', 'Dr. Santosha Rao');
insert into text values(6789, 'Advanced RISC Architecture', 'Scholastic', 'Dr. Santosha Rao');
insert into text values(4353, 'Advanced Embedded C', 'Puffin', 'Tom Cruise');
insert into text values(2345, 'Problem Solving using Computers', 'Puffin', 'Balaguruswamy');
insert into text values(3456, 'Internet of Things', 'Puffin', 'John Doe');
insert into text values(4567, 'Basics of Mechanical Engineering', 'Scholastic', 'Johnny Appleseed');
insert into text values(5678, 'An Introduction to Engineering Graphics I', 'Roopa', 'Matt Daemon');
insert into text values(4224, 'An Introduction to Engineering Graphics II', 'Roopa', 'Matt Daemon');

insert into book_adoption values(2203, 4, 1234);
insert into book_adoption values(1001, 1, 2345);
insert into book_adoption values(2358, 6, 3456);
insert into book_adoption values(1002, 1, 4567);
insert into book_adoption values(1101, 1, 5678);
insert into book_adoption values(1101, 1, 4224);
insert into book_adoption values(2203, 5, 6789);
insert into book_adoption values(2203, 6, 4353);

3.

i.
select * from course
where curse in (select curse from book_adoption group by curse having count(*)>1);

ii.
select c.curse, c.dept
from course c, book_adoption b, text t
where c.curse=b.curse and b.book_isbn in
(select t.book_isbn from text t where t.book_isbn=b.book_isbn and t.publisher="Roopa")
group by c.dept;

iii.
select S.name
from student S natural join enroll E natural join course c
group by S.name
having count(all S.name)>1;

iv.
(select regno, name, major
from student) minus 
(select regno, name, major
from student natural join enroll);

v.
select book_isbn
from text
where book_isbn in (select book_isbn from book_adoption natural join enroll group by book_isbn);

vi.
select c.curse, c.cname, c.dept 
from course c where curse in (select b.curse
from book_adoption b natural join text t where t.publisher='Puffin' group by b.curse having count(*)>=2);

vii.
with totalbooks(Student,Textbooks) as 
(select regno,count(book_isbn)
from enroll natural join book_adoption 
group by regno)
select Student, Textbooks from totalbooks
where Textbooks = (select max(Textbooks) from totalbooks);

viii.
select publisher as 'Publisher', count(*) as 'Books published' from text group by publisher;

ix.
select name from student
where regno in (select regno from enroll natural join book_adoption group by regno);


comment 'Additional Exercises'


i.
insert into customer values(7, 'Gautam', null);
select cname from customer where city is null;

ii.
select c.cust, c.cname, o.ordamt
from customer c natural join orders o
where c.cust in (select cust from orders group by cust having max(ordamt)) limit 1;

iii.
select ordr
from orders
where not exists (select ordr from shipment);


??iv.??
insert into items values(16, 1200);
select ite
from items
where not exists (select ite from order_items);

v.
select ite
from order_items
group by ite having max(qty) order by max(qty) desc limit 1;

vi.
select ordr
from orders
where ordr not in (select ordr from shipment where shipdate='20190814');

vii.
select cust
from orders
where ordr in (select ordr from shipment where shipdate='20190814' or shipdate='20190901') group by cust order by cust;

ix.
select cname from customer where cust in (select cust from orders group by cust order by count(cust) desc) limit 1;


