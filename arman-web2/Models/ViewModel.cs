using X.PagedList;

namespace arman_web2.Models
{
    public class ViewModel
    {
        public Comment comment { get; set; }

        public IPagedList<Comment> comments { get; set; }
    }
}
