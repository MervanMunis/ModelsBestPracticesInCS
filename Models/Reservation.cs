using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservationId { get; set; }

        [Required(ErrorMessage = "Reservation date is required.")]
        [DataType(DataType.Date)]
        public DateTime ReservationDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CancellationDate { get; set; }

        public Member Member { get; set; }

        public Book Book { get; set; }
    }
}
