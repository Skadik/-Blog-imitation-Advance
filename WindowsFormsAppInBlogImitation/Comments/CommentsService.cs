using System.Collections.Generic;

namespace WindowsFormsAppInBlogImitation.Comments
{
    public class CommentsService
    {
        private List<Comment> comments;
        public CommentsService()
        {
            comments = new List<Comment>();
        }

        public void createComent(string name, string description,int stars)
        {
            //comments.Add(new Comment(name, description, stars));
        }

        public void deleteComent(int commentID)
        {
            comments.Remove(comments.Find(comment => comment.getID() == commentID));
        }

        public List<Comment> getComments() => comments;
    }
}
