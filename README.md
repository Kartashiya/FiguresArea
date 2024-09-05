# Figure
Библиотека Figure для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно:
- юнит-тесты
- вычисление площади фигур без знания типа фигуры
- проверка является ли треугольник прямоугольным

Запрос следующего задания (результат находится в изображении Задание №3.png):
SELECT p.Products_Name, c.Category_Name
FROM Products p
LEFT JOIN ProductCategories pc ON p.ID_Products = pc.ID_Products
LEFT JOIN Category c ON pc.ID_Category = c.ID_Category;
