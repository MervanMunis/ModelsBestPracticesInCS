# Library Management System

## Contents
- [Overview](#overview)
- [File Structure](#file-structure)
- [Relations of Tables](#relations-of-tables)
- [Model Classes and Relationships](#model-classes-and-relationships)
  - [Author](#author)
  - [Book](#book)
  - [BookLocation](#booklocation)
  - [Category](#category)
  - [Department](#department)
  - [Employee](#employee)
  - [EmployeeAddress](#employeeaddress)
  - [Language](#language)
  - [LateFee](#latefee)
  - [Library](#library)
  - [LibraryAddress](#libraryaddress)
  - [Loan](#loan)
  - [Member](#member)
  - [MemberAddress](#memberaddress)
  - [Nationality](#nationality)
  - [Position](#position)
  - [Publisher](#publisher)
  - [PublisherAddress](#publisheraddress)
  - [Reservation](#reservation)
  - [Salary](#salary)
  - [WantedBook](#wantedbook)
- [Data Annotations and Attributes](#data-annotations-and-attributes)
- [Best Practices](#best-practices)
- [Why Use ICollection<> Instead of List<>](#why-use-icollection-instead-of-list)
- [Links of My Resources I Have Used So Far](#links-of-my-resources-i-have-used-so-far)
- [Summary](#summary)

## Overview
This Library Management System is a comprehensive project designed to manage a library's operations, including managing books, authors, members, employees, and various transactions such as book borrowings and reservations. The system is built using C# and Entity Framework Core, adhering to best practices in software development to ensure efficiency, scalability, and maintainability.

## File Structure
The project is structured to promote separation of concerns, modularity, and easy maintenance. The main components of the project are organized as follows:

### Models
- `Author.cs`
- `Book.cs`
- `BookLocation.cs`
- `Category.cs`
- `Department.cs`
- `Employee.cs`
- `EmployeeAddress.cs`
- `Language.cs`
- `LateFee.cs`
- `Library.cs`
- `LibraryAddress.cs`
- `Loan.cs`
- `Member.cs`
- `MemberAddress.cs`
- `Nationality.cs`
- `Position.cs`
- `Publisher.cs`
- `PublisherAddress.cs`
- `Reservation.cs`
- `Salary.cs`
- `WantedBook.cs`

### Data
- `LibraryContext.cs`

### Services
- (Service classes for business logic)

### Other directories and files as needed

## Relations of Tables
![Entity Relationship Diagram](https://github.com/MervanMunis/ModelsBestPracticesInCS/blob/master/Entity%20Relationship%20Diagram.png)

## Model Classes and Relationships
The model classes represent the entities in the library system and define their relationships. Below is a summary of each model class, its attributes, and the relationships between them.

### Author
Represents an author of books in the library system.
- **Attributes**: `AuthorId`, `FirstName`, `LastName`, `Description`, `BirthDate`, `Nationality`.
- **Relationships**: Many-to-Many with `Book`.

### Book
Represents a book in the library system.
- **Attributes**: `BookId`, `Title`, `Description`, `PageNumber`, `IsBorrowed`, `CopyNumber`, `ISBN`, `Library`, `BookLocation`, `Language`, `Publisher`.
- **Relationships**: Many-to-Many with `Category`, Many-to-Many with `Author`, One-to-Many with `Loan`, One-to-Many with `Reservation`.

### BookLocation
Represents the location of a book within the library.
- **Attributes**: `Id`, `HallNumber`, `ShelfName`, `ShelfNumber`.
- **Relationships**: One-to-Many with `Book`.

### Category
Represents a category of books.
- **Attributes**: `CategoryId`, `Name`.
- **Relationships**: Many-to-Many with `Book`.

### Department
Represents a department within the library.
- **Attributes**: `DepartmentId`, `Name`.
- **Relationships**: One-to-Many with `Employee`.

### Employee
Represents an employee of the library.
- **Attributes**: `EmployeeId`, `FirstName`, `LastName`, `DateOfBirth`, `HireDate`, `Library`, `Position`, `Salary`, `Department`.
- **Relationships**: One-to-Many with `EmployeeAddress`, One-to-Many with `Loan`.

### EmployeeAddress
Represents an address of a library employee.
- **Attributes**: `EmployeeAddressId`, `Street`, `City`, `State`, `PostalCode`.
- **Relationships**: Many-to-One with `Employee`.

### Language
Represents the language of a book.
- **Attributes**: `LanguageId`, `Name`.
- **Relationships**: One-to-Many with `Book`.

### LateFee
Represents a late fee charged to a member for overdue books.
- **Attributes**: `Id`, `FeePerDay`, `StartedDate`, `LoanId`.
- **Relationships**: Many-to-One with `Member`.

### Library
Represents a library.
- **Attributes**: `LibraryId`, `Name`.
- **Relationships**: One-to-Many with `LibraryAddress`, One-to-Many with `Book`, One-to-Many with `Employee`, One-to-Many with `Member`.

### LibraryAddress
Represents an address of a library.
- **Attributes**: `LibraryAddressId`, `Street`, `City`, `State`, `PostalCode`.
- **Relationships**: Many-to-One with `Library`.

### Loan
Represents a loan of a book to a member.
- **Attributes**: `Id`, `LoanedDate`, `DueDate`, `ReturnDate`.
- **Relationships**: Many-to-One with `Book`, Many-to-One with `Member`, Many-to-One with `Employee`.

### Member
Represents a member of the library.
- **Attributes**: `MemberId`, `FirstName`, `LastName`, `Email`, `Library`.
- **Relationships**: One-to-Many with `MemberAddress`, One-to-Many with `Loan`, One-to-Many with `Reservation`, One-to-Many with `LateFee`.

### MemberAddress
Represents an address of a library member.
- **Attributes**: `MemberAddressId`, `Street`, `City`, `State`, `PostalCode`.
- **Relationships**: Many-to-One with `Member`.

### Nationality
Represents the nationality of an author.
- **Attributes**: `Id`, `Name`.
- **Relationships**: One-to-Many with `Author`.

### Position
Represents the position of an employee.
- **Attributes**: `PositionId`, `Name`.
- **Relationships**: One-to-Many with `Employee`.

### Publisher
Represents a publisher of books.
- **Attributes**: `PublisherId`, `Name`, `PhoneNumber`.
- **Relationships**: One-to-Many with `Book`, One-to-Many with `PublisherAddress`.

### PublisherAddress
Represents an address of a publisher.
- **Attributes**: `Id`, `Street`, `City`, `State`, `PostalCode`.
- **Relationships**: Many-to-One with `Publisher`.

### Reservation
Represents a reservation of a book by a member.
- **Attributes**: `ReservationId`, `ReservationDate`, `CancellationDate`.
- **Relationships**: Many-to-One with `Book`, Many-to-One with `Member`.

### Salary
Represents the salary of an employee.
- **Attributes**: `SalaryId`, `Amount`.
- **Relationships**: One-to-Many with `Employee`.

### WantedBook
Represents a wanted book by a member.
- **Attributes**: `WantedBookId`, `Book`.
- **Relationships**: Many-to-One with `Book`.

## Data Annotations and Attributes
Data annotations are used to enforce validation and define database schema details directly in the model classes. Here are some commonly used attributes:
- **[Key]**: Specifies the primary key for the entity.
- **[Required]**: Marks a property as required.
- **[StringLength]**: Sets the maximum length of a string property.
- **[Range]**: Specifies the range of values allowed for a numeric property.
- **[DataType]**: Specifies the type of data, useful for dates and other formats.
- **[Phone]**: Validates that a property has a phone number format.
- **[EmailAddress]**: Validates that a property has an email address format.

## Best Practices
Several best practices have been followed in this project to ensure a clean, maintainable, and scalable codebase:
- **Encapsulation**: Properties are encapsulated with private setters and public getters.
- **Constructor Initialization**: Essential properties are initialized through constructors.
- **Navigation Properties**: Defined for entity relationships to facilitate efficient querying and data manipulation.
- **Dependency Injection**: The `LibraryContext` uses dependency injection for configuration, promoting testability and flexibility.
- **Fluent API**: Used for complex configurations that are not easily achievable through data annotations.

## Why Use ICollection<> Instead of List<>
Using `ICollection<>` for navigation properties is a best practice in Entity Framework Core for several reasons:
- **Abstraction**: `ICollection<>` is a more abstract type than `List<>`, providing more flexibility in the choice of collection type.
- **Lazy Loading**: Entity Framework can use `ICollection<>` to enable lazy loading of related entities.
- **EF Core Compatibility**: `ICollection<>` works better with EF Core's change tracking and navigation properties.

## Links of My Resources I Have Used So Far
1. [Tutorial: Create a complex data model - ASP.NET MVC with EF Core](https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/complex-data-model?view=aspnetcore-5.0#data-annotations)
2. [Creating and Configuring a Model](https://learn.microsoft.com/en-us/ef/core/modeling/#use-fluent-api-to-configure-a-model)
3. [Entity Framework Core: (Overview)](https://learn.microsoft.com/en-us/ef/core/)
4. [Code First Data Annotations](https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/data-annotations)
5. [Introduction to relationships](https://learn.microsoft.com/en-us/ef/core/modeling/relationships)

## Summary
This Library Management System leverages Entity Framework Core and C# to create a robust, efficient, and maintainable system for managing library operations. The use of data annotations, proper encapsulation, and best practices in class design and relationships ensures a scalable and reliable application. The project is structured to facilitate easy maintenance and future enhancements, making it an ideal solution for library management needs.
