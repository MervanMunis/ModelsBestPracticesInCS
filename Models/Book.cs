using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models
{
    public class Book 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(200, ErrorMessage = "Title cannot be longer than 200 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(2000, ErrorMessage = "Description cannot be longer than 2000 characters.")]
        public string Description { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Page number must be greater than zero.")]
        public int PageNumber { get; set; }

        public bool IsBorrowed { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Copies available cannot be negative.")]
        public int CopyNumber { get; set; }

        [Required(ErrorMessage = "ISBN is required.")]
        [StringLength(20, ErrorMessage = "ISBN cannot be longer than 20 characters.")]
        public string ISBN { get; set; }

        public Library? Library { get; set; }
        public BookLocation? BookLocation { get; set; }
        public Language? Language { get; set; }
        public Publisher? Publisher { get; set; }

        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public ICollection<Loan>? Loans { get; set; } = new List<Loan>();
        public ICollection<Reservation>? Reservations { get; set; } = new List<Reservation>();
        public ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}
