
using System;
using System.ComponentModel.DataAnnotations;

namespace arman_web2.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public String? name { get; set; }
        [Required]
        [StringLength(500)]
        public String? message { get; set; }

        public DateTime? creation_date { get; set; }

    }
}

