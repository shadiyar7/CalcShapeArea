Hi, Решил положит решение - задачки положит в Readme файл. 

К примеру, у нас есть две таблицы:

Products (Продукты):

ProductID (ID продукта)
ProductName (Имя продукта)
Categories (Категории):

CategoryID (ID категории)
CategoryName (Имя категории)
Связующая таблица (многие ко многим):

ProductCategories (Продукт-Категория):
ProductID (ID продукта)
CategoryID (ID категории)

вот Sql запрос 

SELECT 
    p.ProductName, 
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID;
