using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models
{
    public class BookLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Hall number is required.")]
        public int HallNumber { get; set; }

        [Required(ErrorMessage = "Shelf name is required.")]
        [StringLength(100, ErrorMessage = "Shelf name cannot be longer than 100 characters.")]
        public string ShelfName { get; set; }

        [Required(ErrorMessage = "Shelf number is required.")]
        public int ShelfNumber { get; set; }

        public ICollection<Book>? Books { get; set; } = new List<Book>();
    }
}
