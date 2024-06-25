using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyContactAPI.Models
{

    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [NotMapped]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [NotMapped]
        public DateTime UpdatedAt { get; set; }

        public virtual void SetUpdated()
        {
            UpdatedAt = DateTime.UtcNow;

        }
    }
}
