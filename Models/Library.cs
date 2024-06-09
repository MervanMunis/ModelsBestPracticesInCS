using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models
{
    public class Library
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibraryId { get; set; }

        [Required(ErrorMessage = "Library name is required.")]
        [StringLength(200, ErrorMessage = "Library name cannot be longer than 200 characters.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Library address is required.")]
        public ICollection<LibraryAddress> Addresses { get; set; } = new List<LibraryAddress>();

        public ICollection<Book> Books { get; set; } = new List<Book>();

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public ICollection<Member> Members { get; set; } = new List<Member>();
    }
}
