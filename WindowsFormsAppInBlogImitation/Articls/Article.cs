using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using WindowsFormsAppInBlogImitation.Comments;

namespace WindowsFormsAppInBlogImitation.Blogs
{
    public class Article
    {
        private static int countID = 0;
        private int ID;
        private string title;
        private string userName;
        private string description;
        private List<Comment> comments;

        public Article(string title, string userName,string description)
        {
            this.ID = countID;
            this.title = title;
            this.userName = userName;
            this.description = description;
        }
    }
}
