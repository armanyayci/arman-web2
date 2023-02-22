using System.ComponentModel.DataAnnotations;

namespace arman_web2.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        [StringLength(500)]
        public string? message { get; set; }
    }
}
