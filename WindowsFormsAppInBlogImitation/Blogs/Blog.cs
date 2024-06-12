using System.Collections.Generic;
using WindowsFormsAppInBlogImitation.Users;

namespace WindowsFormsAppInBlogImitation.Blogs
{
    public class Blog
    {
        private List<Article> articles;
        private UserService userService;
        public List<Article> getAllArticles() => articles;

        public Article getArticelsForID(int ArticleID)
        {
            return articles[ArticleID];
        }

        public Blog()
        {
            userService = new UserService();
            articles = new List<Article>
            {
                new Article("Свен Вінке о Baldur's Gate 3, порівняннях с CD Projekt та майбутнє студії",userService.getUsers()[0].getName(),"https://youtu.be/MW846h6FyU4"),
                new Article("Свен Вінке о Baldur's Gate 3, порівняннях с CD Projekt та майбутнє студії","Robert Purchese","https://youtu.be/MW846h6FyU4"),
                new Article("Свен Вінке о Baldur's Gate 3, порівняннях с CD Projekt та майбутнє студії","Robert Purchese","https://youtu.be/MW846h6FyU4"),
                new Article("Свен Вінке о Baldur's Gate 3, порівняннях с CD Projekt та майбутнє студії","Robert Purchese","https://youtu.be/MW846h6FyU4"),
                new Article("Свен Вінке о Baldur's Gate 3, порівняннях с CD Projekt та майбутнє студії","Robert Purchese","https://youtu.be/MW846h6FyU4"),
                new Article("Свен Вінке о Baldur's Gate 3, порівняннях с CD Projekt та майбутнє студії","Robert Purchese","https://youtu.be/MW846h6FyU4"),
            };
          
        }
    }
}
