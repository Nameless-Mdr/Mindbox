SELECT p.ProductName, ISNULL(c.CategoryName, 'No Category') AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.Id
ORDER BY p.ProductName;