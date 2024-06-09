using Microsoft.EntityFrameworkCore;
using LibrarySystem.Models;

namespace LibrarySystem.Data
{
    public class LibrarySystemContext : DbContext
    {
        public LibrarySystemContext(DbContextOptions<LibrarySystemContext> options)
            : base(options)
        {
        }
        public DbSet<Book>? Book { get; set; }
        public DbSet<Category>? Category { get; set; }
        public DbSet<Language>? Language { get; set; }
        public DbSet<Loan>? Loan { get; set; }
        public DbSet<Member>? Member { get; set; }
        public DbSet<Employee>? Employee { get; set; }
        public DbSet<Publisher>? Publisher { get; set; }
        public DbSet<Reservation>? Reservation { get; set; }
        public DbSet<Nationality>? Nationality { get; set; }
        public DbSet<Position>? Position { get; set; }
        public DbSet<Salary>? Salary { get; set; }
        public DbSet<WantedBook>? WantedBook { get; set; }
        public DbSet<EmployeeAddress>? EmployeeAddress { get; set; }
        public DbSet<MemberAddress>? MemberAddress { get; set; }
        public DbSet<PublisherAddress>? PublisherAddress { get; set; }
        public DbSet<LateFee>? LateFee { get; set; }
        public DbSet<Department>? Department { get; set; }
        public DbSet<BookLocation>? BookLocation { get; set; }
        public DbSet<Library>? Library { get; set; }
        public DbSet<LibraryAddress>? LibraryAddress { get; set; }
        public DbSet<Author>? Author { get; set; }

    }
}