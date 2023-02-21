
using System;
using System.ComponentModel.DataAnnotations;

namespace arman_web2.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Write Your Name!")]
        public String? name { get; set; }

        [Required(ErrorMessage = "Please Write Your message!")]
        public String? message { get; set; }

        public DateTime? creation_date { get; set; }

    }
}

