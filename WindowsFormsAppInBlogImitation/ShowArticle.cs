using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsAppInBlogImitation.Blogs;
using WindowsFormsAppInBlogImitation.CreatorForShowArticle;

namespace WindowsFormsAppInBlogImitation
{
    public partial class ShowArticle : Form
    {
        public static int Y = 25;
        private List<TextBox> textBoxs;
        public ShowArticle(List<Article> list)
        {
            InitializeComponent();
            textBoxs = new List<TextBox>();
            foreach (Article article in list)
            {
                showArticl(article);
                foreach (var coment in article.getCommentsService().getComments())
                {
                    textBox2.Text = coment.getDescription();
                }
            }  
            scalingAll();
        }

        public ShowArticle(Article article)
        {
            InitializeComponent();
            textBoxs = new List<TextBox>();
            showArticl(article);
            foreach (var coment in article.getCommentsService().getComments())
            {
                label3.Text = coment.getName() + "======" + "Зірки: " + coment.getStars();
                textBox2.Text = "\n" + coment.getDescription();
            }
            scalingAll();
        }

        private void showArticl(Article article)
        {
            Creator creator = new Creator();
            TextBox textBox = creator.createTextBox(ShowArticle.Y, article.getDescription());
            Controls.Add(creator.createLabelTitle(ShowArticle.Y, article.getTitle()));
            Controls.Add(creator.createLabelID(ShowArticle.Y, article.getArticleID()));
            Controls.Add(creator.createLabelUserName(ShowArticle.Y, article.getUserName()));
            Controls.Add(textBox);
            textBoxs.Add(textBox);
            ShowArticle.Y = textBox.Location.Y + textBox.Size.Height;
        }

        private void scalingForm()
        {
            this.ClientSize = new System.Drawing.Size(button2.Location.X + button2.Width + 25, button2.Location.Y + button2.Height + 25);
        }

        private void scalingButton()
        {
            button1.Location = new System.Drawing.Point(932, Y);
            button2.Location = new System.Drawing.Point(1351, Y);
        }

        private void scalingID()
        {
            textBox1.Location = new System.Drawing.Point(button1.Location.X + button1.Size.Width, button1.Location.Y + 30);
            label2.Location = new System.Drawing.Point(button1.Location.X + button1.Size.Width + 25, button1.Location.Y);
        }

        private void scalingAll()
        {
            scalingButton();
            scalingID();
            scalingForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxs[Int32.Parse(textBox1.Text)].ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}