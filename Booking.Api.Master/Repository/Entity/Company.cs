using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Booking.Api.Master.Repository.Entity
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = "";

        [ForeignKey("EntityType")]
        public int EntityTypeId { get; set; }

        [MaxLength(500)]
        public string? BaseLocation { get; set; }

        [MaxLength(20)]
        public string? GstIn { get; set; }

        [Required]
        public DateTime DateOfIncorporation { get; set; }

        [ForeignKey("Country")]
        public int CountryOfInCorporation { get; set; }

        public string? CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual EntityType EntityType { get; set; }
        public virtual Country Country { get; set; }
    }
}
