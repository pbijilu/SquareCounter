В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Поскольку имеем отношение многие ко многим, мы имеем три таблицы - Products с полями id и name, Categories с аналогичными полями, и таблица со связями id двух других таблиц - ProductsToCategory с полями productId и categoryId.

Для вывода всех пар нам понадобится использовать два LEFT JOIN:

SELECT Products.name, Categories.name FROM Products
LEFT JOIN ProductToCategory ON Products.id = ProductToCategory.productId
LEFT JOIN Categories ON ProductToCategory.categoryId = Categories.id