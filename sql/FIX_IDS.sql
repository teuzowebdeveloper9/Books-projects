CREATE TABLE books_temp (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Title VARCHAR(255),
    Description TEXT,
    launch DATETIME,
    AuthorId INT
);


INSERT INTO books_temp (Title, Description, launch, AuthorId)
SELECT Title, Description, launch, AuthorId FROM books ORDER BY Id;


DROP TABLE books;


RENAME TABLE books_temp TO books;
