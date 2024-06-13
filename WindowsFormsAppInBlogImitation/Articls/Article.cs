using System.Collections.Generic;
using WindowsFormsAppInBlogImitation.Comments;
using WindowsFormsAppInBlogImitation.Users;

namespace WindowsFormsAppInBlogImitation.Blogs
{
    public class Article
    {
        private static int countID = 0;
        private int ID;
        private string title;
        private User user;
        private string description;
        private List<Comment> comments;

        public User getUser() => user;
        public string getDescription() => description;
        public string getTitle() => title;
        public int getArticleID() => ID;

        public void setComments(List<Comment> comments)
        {
            this.comments = comments;
        }
        public void addNewComment(User user, string description, int stars)
        {
            comments.Add(new Comment(user, description, stars));
        }

        public void deleteComment(int commentID)
        {
            comments.RemoveAll(comment => comment.getID() == commentID);
        }

        public List<Comment> getComments() => comments;

        public Article(string title, User user, string description)
        {
            this.ID = countID++;
            this.title = title;
            this.user = user;
            this.description = description;
            this.comments = new List<Comment>();
            //comments.createComent("Адольф", "Ну це і діч", 1);
            //comments.createComent("GURU", "Чудове інтервью", 5);
            //comments.createComent("Zebra 223", "Чудва гра бажаю ларіанам надхнення і си лробити такі ігри", 5);
            //comments.createComent("dedliparkurkiller228", "увевувевуосас", 3);
            //comments.createComent("molokosos", "Цей чувак в обладунках просто мем", 4);
        }
    }
}
