# Restaurant-Management-System-MySql-
A simple Restaurant management System with visual studio C#  ( With MySQL data base)  .


# Great Opportunity for beginners to learn how mysql data base works with C# visual studio .


# Program Features 

1. Test the Database connection 
2. Add Customer
3. Create Order
4. Search Customer Name
5. Show Tabels and their data
6. Delete any row from any table


# EXE FILE LOCATION :       Restaurant\Restaurant\New folder\Restaurant\Restaurant\bin\Release\Restaurant.exe



# Important Note : The database maynot connect when you test it in the application.

1. You have to download MYSQL.
2. Open Mysql workbench and start a server  (Set the password to : killgrave) , which is the password that is written in the code of the program.
3. and recreate my database ny executing this codes in mysql workbench .

5. first create the database :  -------------------------------------------->                CREATE DATABASE restaurantdb;




6. then click on the restaurantdb and then execute this code---------------->                 

CREATE TABLE customers (
    CustomerID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Address VARCHAR(255)
);

7. then this ---------------------------->


CREATE TABLE menu (
    MenuID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL
);



8. then this ------------------>

CREATE TABLE orders (
    OrderID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    OrderDate DATETIME NOT NULL DEFAULT NOW(),
    TotalAmount DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID) ON DELETE CASCADE
);


9.then this--------------------------------> 



CREATE TABLE orderdetails (
    OrderDetailID INT AUTO_INCREMENT PRIMARY KEY,
    OrderID INT NOT NULL,
    MenuID INT NOT NULL,
    Quantity INT NOT NULL,
    Subtotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES orders(OrderID) ON DELETE CASCADE,
    FOREIGN KEY (MenuID) REFERENCES menu(MenuID) ON DELETE CASCADE
);


10. you can also give the database some data --------------------->



-- Insert into customers
INSERT INTO customers (Name, Phone, Email, Address) VALUES
('John Doe', '1234567890', 'john@example.com', '123 Elm St'),
('Jane Smith', '0987654321', 'jane@example.com', '456 Oak St');

-- Insert into menu
INSERT INTO menu (Name, Price) VALUES
('Pizza', 10.50),
('Burger', 8.75),
('Pasta', 12.00);

-- Insert into orders
INSERT INTO orders (CustomerID, TotalAmount) VALUES
(1, 50.00),
(2, 30.00);

-- Insert into orderdetails
INSERT INTO orderdetails (OrderID, MenuID, Quantity, Subtotal) VALUES
(1, 1, 2, 21.00),
(1, 2, 3, 26.25),
(2, 3, 2, 24.00);




# Remember
The whole point of this program is for you to become familiar with mysql/C# , I hope you find it usefull .








                   

