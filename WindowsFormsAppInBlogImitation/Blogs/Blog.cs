using System.Collections.Generic;
using WindowsFormsAppInBlogImitation.Users;

namespace WindowsFormsAppInBlogImitation.Blogs
{
    public class Blog
    {
        private List<Article> articles;
        private List<User> users;   
        public List<Article> getAllArticles() => articles;

        public Article getArticelsForID(int ArticleID)
        {
            return articles[ArticleID];
        }

        public void setArticles(List<Article> articles)
        {
            this.articles = articles;
        }

        public void setUsers(List<User> users)
        {
            this.users = users;
        }

        public Blog()
        {
            articles = new List<Article>();
            users = new List<User>();

        }
    }
}
