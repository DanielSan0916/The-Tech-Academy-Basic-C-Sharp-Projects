using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarInsurance.Models
{
    [Table("Insurees")]
    public class Insuree
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required, StringLength(50)]
        public string EmailAddress { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int CarYear { get; set; }

        [Required, StringLength(50)]
        public string CarMake { get; set; }

        [Required, StringLength(50)]
        public string CarModel { get; set; }

        [Required]
        public bool DUI { get; set; }

        [Required]
        public int SpeedingTickets { get; set; }

        [Required]
        public bool CoverageType { get; set; }

        public decimal? Quote { get; set; }
    }
}