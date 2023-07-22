---------------------------------------------LAB 3------------------------------------------

------Question - 1.------

1.
create table PERSON(
driver_id varchar(30),
name varchar(50),
Address varchar(50),
primary key(driver_id));

create table CAR(
regno varchar(20),
model varchar(30),
Year int,
primary key(regno)
);

create table Accident(
report_number int,
accd_date date,
location varchar(50),
primary key(report_number)
);

create table OWNS(
driver_id varchar(30) references PERSON,
regno varchar(20) references CAR,
primary key(driver_id,regno));

create table PARTICIPATED(
driver_id varchar(20) references PERSON,
regno varchar(20) references CAR,
report_number int references ACCIDENT,
damage_amount int,
primary key(driver_id,regno,report_number));

2.
insert into PERSON values('2017','Tushar', '103/15');
insert into PERSON values('2018','Shreyas','104/15');
insert into PERSON values('2019','Manik','304/14');
insert into PERSON values('2020','Nirbhay','65/17');
insert into PERSON values('2021','Modi','52/17	');

insert into CAR values('4265','Amaze',1995);
insert into CAR values('4266','Punto',1996);
insert into CAR values('4267','Swift',1997);
insert into CAR values('4268','Go',1998);
insert into CAR values('4269','Indica',1999);


insert into Accident values('16','19990112','Hyderabad');
insert into Accident values('17','19990527','Hyderabad');
insert into Accident values('18','19990412','Hyderabad');
insert into Accident values('19','19970717','Hyderabad');
insert into Accident values('20','20000712','Hyderabad');

insert into OWNS values('2017','4265');
insert into OWNS values('2018','4266');
insert into OWNS values('2019','4267');
insert into OWNS values('2020','4268');
insert into OWNS values('2021','4269');

insert into PARTICIPATED values('2017','4265','16','10000');
insert into PARTICIPATED values('2018','4266','17','15000');
insert into PARTICIPATED values('2019','4267','18','20000');
insert into PARTICIPATED values('2020','4268','19','25000');
insert into PARTICIPATED values('2021','4269','20','30000');

ALTER TABLE PERSON MODIFY name varchar(20);
ALTER TABLE PERSON MODIFY Address varchar(20);
ALTER TABLE PERSON MODIFY driver_id varchar(20);

3.
update PARTICIPATED
set damage_amount = '25000'
where report_number = '12';

4.
delete from Participated
where report_number in (
select report_number from accident
where extract(year from accd_date) = '1999');

delete from accident
where extract(year from accd_date) = '1999';

5.
alter table participated add eg int;

alter table participated drop column eg ;

6.
alter table participated
add constraint check_driverid check(length(DRIVER_ID) = 4);

-------Additional Excercise.------

1.
create table CUSTOMER (
	cust int,
	cname varchar(100),
	city varchar(10),
	primary key (cust));

create table ORDERS (
	ordr int,
	odate date,
	cust int references CUSTOMER,
	ordamt int,
	primary key(ordr));

create table ITEM (
	ite int,
	unitprice int,
	primary key(ite));

create table ORDER_ITEMS (
	ordr int references orders,
	ite int references ite,
	qty int,
	primary key(ordr, ite));

create table WAREHOUSE (
	warehouse int,
	city  varchar(10),
	primary key(warehouse));

create table SHIPMENT (
	ordr  int,
	warehouse int references warehouse,
	shipdate  date,
	primary key(ordr,warehouse),
	foreign key (warehouse) references warehouse);

2.

insert into customer values (1,'Tushar Machavolu','BOM');
insert into customer values (2,'Shreyas','DEL');
insert into customer values (3,'Manik Chhabra','DEL');
insert into customer values (4,'Nirbhay Bhardwaj','DEL');
insert into customer values (5,'Modi','LUH');

insert into orders values (10,'20190814',1,100);
insert into orders values (11,'20190814',1,100);
insert into orders values (12,'20190814',1,100);
insert into orders values (13,'20190814',2,100);
insert into orders values (14,'20190814',2,200);
insert into orders values (15,'20190814',3,100);
insert into orders values (16,'20190814',4,500);
insert into orders values (17,'20190814',5,100);

insert into item values(11,100);
insert into item values(12,200);
insert into item values(13,300);
insert into item values(14,400);
insert into item values(15,500);

insert into order_items values(10,11,1);
insert into order_items values(11,12,5);
insert into order_items values(12,13,10);
insert into order_items values(13,14,15);
insert into order_items values(14,15,20);
insert into order_items values(15,15,20);
insert into order_items values(16,15,20);
insert into order_items values(17,15,20);

insert into warehouse values(1,'BOM');
insert into warehouse values(2,'HYD');
insert into warehouse values(3,'IXE');
insert into warehouse values(4,'HYD');
insert into warehouse values(5,'CGK');


insert into shipment values (10,1,'20190814');
insert into shipment values (11,1,'20190814');
insert into shipment values (12,1,'20190814');
insert into shipment values (13,1,'20190814');
insert into shipment values (14,1,'20190814');
insert into shipment values (15,1,'20190814');
insert into shipment values (16,1,'20190814');
insert into shipment values (17,1,'20190814');


3.

a.
select cname,count(orders.cust),avg(ordamt)
from customer,orders
where customer.cust = orders.cust
group by customer.cname,orders.cust;

b.
select ordr from shipment
where warehouse in(select warehouse from warehouse where city = 'BOM' );

c.
update orders o
set o.ordamt=case when (select qty from order_items oi where o.ordr=oi.ordr)>10 then o.ordamt*0.9 else o.ordamt*0.95 end;


---------------------------------------LAB 4---------------------------------

Question 1.

1.

select count(participated.driver_id) as total
from participated,accident
where participated.report_number = accident.report_number and extract(year from  accident.accd_date) = '1999';

2.

select count(participated.regno) as total
from participated,car
where participated.regno = car.regno and car.model = 'Go';

3.
select person.name as OWNER_NAME,count(participated.driver_id) no_of_accd ,sum(participated.damage_amount) as total_amount
from person,participated
where participated.driver_id = person.driver_id
group by person.name,participated.driver_id
order by 1/total_amount;

4.
select person.name as OWNER_NAME, count(*) from person, participated, accident
where person.driver_id=participated.driver_id and accident.report_number=participated.report_number
group by name, extract(year from accd_date) having count(participated.report_number)<2;

5.
select person.name as OWNER_NAME, count(*) from person, participated, accident
where person.driver_id=participated.driver_id and accident.report_number=participated.report_number
group by name having count(participated.report_number)=0;

-------Additional Excercise.------

1.
select cname
from customer natural join orders
where orders.odate=20190814;

2.
select ordr, count(qty)
from order_items
group by order_items.ordr;

3.
select ordr from order_items
group by ordr
having count(ite)>=all (select count(ite) from order_items group by ordr);

4.
select shipment.shipdate, qty
from shipment, order_items
where shipment.ordr=order_items.ordr
and qty=(select max(qty) from order_items);

5.
delete from order_items
where ordr=3;
delete from item
where ite=3;

6.
select ordr, city
from shipment natural join warehouse
where warehouse.city='BOM';

7.
select cname
from customer
where cname like"%Machavolu";

8.
select cname, ordamt
from customer natural join orders
order by ordamt desc;

9.
select * from customer natural join orders natural join shipment
having count(ordr)>=3 and shipdate='20190814';