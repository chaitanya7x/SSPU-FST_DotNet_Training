use chaitanya;

CREATE TABLE orders (
    orderid INT PRIMARY KEY,
    date DATE,
    cid INT,
    totalAmt DOUBLE,
    FOREIGN KEY (cid) REFERENCES customers(cid)
);

CREATE TABLE customers (
    cid INT PRIMARY KEY NOT NULL,
    fname VARCHAR(10),
    lname VARCHAR(10),
    city VARCHAR(20),
    country VARCHAR(20),
    phone VARCHAR(15)
);

insert into customers(cid,fname,lname,city,country,phone) values 
(1,"chaitanya","mate","nashik","india","123123123"),
(2,"chaitanya","mate","nashik","india","123123123"),
(3,"chaitanya","mate","nashik","india","123123123"),
(4,"chaitanya","mate","nashik","india","123123123"),
(5,"chaitanya","mate","nashik","india","123123123");

insert into orders(orderid,date,cid,totalAmt) values
(101,"1999-2-2",1,10000),
(102,"1999-2-2",2,10000),
(103,"1999-2-2",3,10000),
(104,"1999-2-2",4,10000),
(105,"1999-2-2",5,10000);

describe customers;
describe orders;

select * from customers;
select * from orders;

SELECT 
    *
FROM
    orders
        JOIN
    customers ON orders.cid = customers.cid;

CREATE TABLE orderItem (
    pid INT PRIMARY KEY NOT NULL,
    unit_price INT,
    qty INT,
	orderid INT,
    FOREIGN KEY (orderid) REFERENCES orders (orderid)
);

CREATE TABLE product (
    pid INT,
    pname VARCHAR(100),
    supplierid INT,
    unit_price DOUBLE,
    FOREIGN KEY (pid) REFERENCES orderItem (pid)
);

INSERT INTO orderItem (pid, unit_price, qty, orderid) VALUES
(1, 500, 2, 101),
(2, 700, 1, 102),
(3, 300, 3, 103),
(4, 900, 2, 104),
(5, 400, 4, 105);

INSERT INTO product (pid, pname, supplierid, unit_price) VALUES
(1, 'Product A', 101, 500),
(2, 'Product B', 102, 700),
(3, 'Product C', 103, 300),
(4, 'Product D', 104, 900),
(5, 'Product E', 105, 400);

SELECT 
    pname, qty, product.unit_price, orders.orderid
FROM
    product
        JOIN
    orderItem ON product.pid = orderItem.pid
        JOIN
    orders ON orderItem.orderid = orders.orderid
ORDER BY orders.orderid;
