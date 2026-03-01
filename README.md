# assignment-books
CetStudentBook - Assignment: Books CRUD
This project is an extended version of the CetStudentBook application. The goal of this assignment was to implement a full CRUD (Create, Read, Update, Delete) system for a "Book" entity manually, without using any scaffolding tools.
Features Implemented
The following features have been implemented manually as per the assignment requirements:

Manual Controller & Views: Created BooksController and all Razor views (Index, Create, Edit, Delete) from scratch without auto-generation.

Book Model: Implemented a Book entity with fields: Id, Name, Author, PublishDate, PageCount, and IsSecondHand.

Data Validation: Added server-side and client-side validation using Data Annotations:

[Required] for all fields.

[StringLength] (2-200) for Name and Author.

[Range] (1-10000) for PageCount.

Database Integration: Integrated the Book model into ApplicationDbContext and applied Entity Framework Core Migrations.

Navigation: Added a "Books" link to the main navigation bar in the shared layout.

How to Run the Project Locally
Follow these steps to set up and run the project on your machine:

1. Clone the Repository
git clone https://github.com/melike6/assignment-books.git

Screenshots
1. Books List Page
<img width="1920" height="1080" alt="Ekran Görüntüsü (748)" src="https://github.com/user-attachments/assets/1b2dee93-b4ea-454c-8334-b9de7663f6b9" />
