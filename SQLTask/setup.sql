CREATE TABLE category (id INT identity PRIMARY KEY, name VARCHAR(100));
INSERT INTO category VALUES
  ('category1'),
  ('category2'),
  ('category3');
  
CREATE TABLE product (id INT identity PRIMARY KEY, name VARCHAR(100));
INSERT INTO product VALUES
  ('product1'),
  ('product2'),
  ('product3');

CREATE TABLE product_category (product_id INT, category_id INT);
INSERT INTO product_category VALUES
  (1,1),
  (1,2),
  (1,3),
  (2,2),
  (2,3);