using WindowsFormsAppInBlogImitation.Users;

namespace WindowsFormsAppInBlogImitation.Comments
{
    public class Comment
    {
        private static int countID = 0;
        private int ID;
        private int stars;
        private User user;
        private string description;

        public int getID() => ID;
        public User getUser() => user;
        public string getDescription() => description;
        public void setDescription(string description)
        {
            this.description = description;
        }


        public int getStars() => stars;
        public void setstars(int stars)
        {
            this.stars = stars;
        }

        public Comment(User user, string description, int stars)
        {
            this.ID = countID++;
            this.stars = stars;
            this.user = user;
            this.description = description;
        }
    }
}
