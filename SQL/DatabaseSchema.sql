CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100)
);

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(100)
);

CREATE TABLE ProductCategories (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

INSERT INTO Products (ProductID, ProductName)
VALUES (1, 'Product 1'),
       (2, 'Product 2'),
       (3, 'Product 3'),
       (4, 'Product 4');


INSERT INTO Categories (CategoryID, CategoryName)
VALUES (1, 'Category 1'),
       (2, 'Category 2'),
       (3, 'Category 3');

INSERT INTO ProductCategories (ProductID, CategoryID)
VALUES (1, 1), -- Продукт 1 принадлежит категории 1
       (1, 2), -- Продукт 1 принадлежит категории 2
       (2, 2), -- Продукт 2 принадлежит категории 2
       (3, 1), -- Продукт 3 принадлежит категории 1
       (3, 3); -- Продукт 3 принадлежит категории 3
