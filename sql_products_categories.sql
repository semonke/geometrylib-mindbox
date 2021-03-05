USE store;

SELECT Products.Name AS ProductName, Categories.Name AS CategoryName
FROM Products
LEFT JOIN ProductsToCategories ON ProductsToCategories.Product_Id = Products.Id
LEFT JOIN Categories ON Categories.Id = ProductsToCategories.Category_Id