using System.ComponentModel.DataAnnotations;
using X.PagedList;

namespace arman_web2.Models
{
    public class ViewModel
    {

        //public Comment comment { get; set; }

        [Required(ErrorMessage = "Please Write Your Name!")]
        [StringLength(50, ErrorMessage = "The Name must be no more than 50 characters.")]
        public String ?name { get; set; }

        [Required(ErrorMessage = "Please Write Your message!")]
        [StringLength(500, ErrorMessage = "The message must be no more than 500 characters.")]
        public String ?message { get; set; }

        public IPagedList<Comment> ?comments { get; set; }
    }
}
