using System;
namespace arman_web2.Models
{
    public static class CommentRepository
    {

            private static List<Comment> _comment = new List<Comment>();

        static CommentRepository()
        {
            _comment = new List<Comment>()
            {
                    new Comment() { name = "ZORMAN1", message = "ASP.NET Core MVC1", creation_date=DateTime.Now },
                    new Comment() { name = "ZORMAN2", message = "ASP.NET Core MVC2", creation_date=DateTime.Now},
                    new Comment() { name = "ZORMAN3", message = "ASP.NET Core MVC3", creation_date=DateTime.Now},
                    new Comment() { name = "ZORMAN4", message = "ASP.NET Core MVC4", creation_date=DateTime.Now}
        };
        }

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
