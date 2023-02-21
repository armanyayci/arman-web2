namespace arman_web2.Models
{
    public class EFCommentRepository : ICommentRepository
    {

        private ApplicationDbContext _context;
        public EFCommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Comment> Comments => _context.Comments.OrderByDescending(d=>d.creation_date);

        public void CreateComment(Comment comment)
        {
            _context.Comments.Add(comment);  // sign product
            _context.SaveChanges();  // real registering
        }
    }
}
