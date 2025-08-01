# Book Management API

This project is a Book Management API built using ASP.NET Core, implementing a relationship between Books and Authors.

## Project Structure

The project is organized into the following main components:

- ViewModels
- Controllers
- Models
- Data
- Docker

## Database

This project uses MySQL as the database. SQL scripts were extensively used for various purposes:

- Table creation and modification
- Data seeding
- Error correction
- Generating fake data for testing

## Entities

The two main entities in this project are:

1. Books
2. Authors

These entities have a one-to-many relationship, where one author can have multiple books.

## SQL Usage

This project heavily relies on SQL for database operations. While ORMs (Object-Relational Mappers) are commonly used in modern development, this project intentionally focuses on raw SQL to strengthen SQL skills. Some of the SQL operations performed include:

- Initial data retrieval scripts
- Error correction scripts
- Data manipulation and querying

## Learning Outcomes

This project provided an excellent opportunity to deepen SQL knowledge and skills. While ORMs are convenient, understanding and using SQL directly is crucial for database management and optimization.
