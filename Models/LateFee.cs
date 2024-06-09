using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models
{
    public class LateFee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fee per day must be a positive value.")]
        public decimal? FeePerDay { get; set; }

        [Required(ErrorMessage = "Started date is required.")]
        public DateTime StartedDate { get; set; }

        public int LoanId { get; set; }
        public Member Member { get; set; }
    }
}
