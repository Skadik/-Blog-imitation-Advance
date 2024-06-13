using System;
using System.Collections.Generic;
using WindowsFormsAppInBlogImitation.Comments;
using WindowsFormsAppInBlogImitation.Users;

namespace WindowsFormsAppInBlogImitation.Fixtures
{
    public class CommentFixture
    {
        public static List<Comment> createComments(List<User> users, int count)
        {
            Random rnd = new Random();
            List<Comment> comments = new List<Comment>();

            for (int i = 0; i < count; i++)
            {
                comments.Add(new Comment(users[rnd.Next(0, users.Count)], "description" + i, rnd.Next(1, 6)));
            }

            return comments;
        }
    }
}
