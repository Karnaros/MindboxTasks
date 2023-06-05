SELECT product.*, category.*
FROM product
LEFT JOIN product_category ON (product.id = product_id)
LEFT JOIN category ON (category_id = category.id);