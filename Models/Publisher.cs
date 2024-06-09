using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models
{
    public class Publisher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PublisherId { get; set; }

        [Required(ErrorMessage = "Publisher name is required.")]
        [StringLength(100, ErrorMessage = "Publisher name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        public int? PublishedYear { get; set; }

        [Phone(ErrorMessage = "Invalid phone number.")]
        [StringLength(20, ErrorMessage = "Phone number cannot be longer than 20 characters.")]
        public string PhoneNumber { get; set; }

        public ICollection<Book>? Books { get; set; } = new List<Book>();

        public ICollection<PublisherAddress>? Addresses { get; set; } = new List<PublisherAddress>();
    }
}
