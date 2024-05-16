using System.ComponentModel.DataAnnotations;

namespace Booking.Api.Master.Repository.Entity
{
    public class EntityType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
