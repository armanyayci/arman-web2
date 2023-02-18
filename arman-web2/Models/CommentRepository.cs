using System;
namespace arman_web2.Models
{
    public static class CommentRepository
    {

            private static List<Comment> _comment = new List<Comment>();

            public static List<Comment> comments
            {
                get
                {
                    return _comment;     //for seeing comments
                }
            }

            public static void AddComment(Comment comment)
            {
                _comment.Add(comment);   // for adding comments info from apply form 
            }
        }
    }
