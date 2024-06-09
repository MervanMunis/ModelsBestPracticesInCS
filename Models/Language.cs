using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models
{
    public class Language
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LanguageId { get; set; }

        [Required(ErrorMessage = "Language name is required.")]
        [StringLength(100, ErrorMessage = "Language name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        public ICollection<Book>? Books { get; set; } = new List<Book>();
    }
}
