create database employeeEFDB;

use employeeEFDB

create table employee
(empid int primary key,
name varchar(30) not null,
ssn bigint not null,
salary float not null,
deptid int not null);

create table department 
(deptid int primary key,
name varchar(30) not null);

alter table employee 
add constraint fk_deptid foreign key (deptid) references department(deptid);

insert into department values(14,'admin');
insert into department values(1,'tech');
insert into department values(12,'manager');
select * from department
select * from employee
insert into employee values(4,'xxx',6546,30998,14)