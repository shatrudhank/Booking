using System.ComponentModel.DataAnnotations;

namespace Booking.Api.Master.Repository.Entity
{
    public class Country
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public short Code {  get; set; }

        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }
    }
}
