using System;
using System.Collections.Generic;
using WindowsFormsAppInBlogImitation.Blogs;
using WindowsFormsAppInBlogImitation.Users;

namespace WindowsFormsAppInBlogImitation.Fixtures
{
    public class ArticleFixture
    {
        public static List<Article> createArticles(List<User> users, int count)
        {
            Random rand = new Random();
            List<Article> articles = new List<Article>();

            for (int i = 0; i < count; i++)
            {
                Article article = new Article("Title " + i, users[rand.Next(0, users.Count)], "Text " + i);
                article.setComments(CommentFixture.createComments(users, rand.Next(1, 15)));

                articles.Add(article);
            }

            return articles;
        }
    }
}
