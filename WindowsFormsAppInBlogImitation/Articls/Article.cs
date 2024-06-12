﻿using System.Collections.Generic;
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
        private CommentsService comments;

        public string getUserName() => userName;
        public string getDescription() => description;
        public string getTitle() => title;
        public int getArticleID() => ID;

        public CommentsService getCommentsService() => comments;

        public Article(string title, string userName,string description)
        {
            this.ID = countID++;
            this.title = title;
            this.userName = userName;
            this.description = description;
            this.comments = new CommentsService();
        }
    }
}
