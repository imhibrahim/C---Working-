using System.ComponentModel.DataAnnotations;

namespace myAPI.model
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
