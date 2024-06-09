namespace WindowsFormsAppInBlogImitation.Comments
{
    public class Comment
    {
        private static int countID = 0;
        private int ID;
        private int stars;
        private string name;
        private string description;

        public int getID() => ID;
        public string getName() => name;
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

        public Comment(string name, string description, int stars)
        {
            this.ID = countID++;
            this.stars = stars;
            this.name = name;
            this.description = description;
        }
    }
}
