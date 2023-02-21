namespace arman_web2.Models
{
    public interface ICommentRepository
    {
        IQueryable<Comment> Comments { get; }

        void CreateComment(Comment comment);   // add data to the db 

    }
}
