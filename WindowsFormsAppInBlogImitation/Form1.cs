using System;
using WindowsFormsAppInBlogImitation.Users;
using System.Windows.Forms;
using WindowsFormsAppInBlogImitation.Blogs;
using System.Collections.Generic;
using WindowsFormsAppInBlogImitation.Fixtures;

namespace WindowsFormsAppInBlogImitation
{
    public partial class Form1 : Form
    {
        private UserService userService;
        private Blog blog;
        public Form1()
        {
            InitializeComponent();
            userService = new UserService();

            blog = new Blog();
            List<User> users = (new UserFixture()).createUsers(12);
            blog.setUsers(users);

            blog.setArticles(ArticleFixture.createArticles(users, 30));

            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0 || textBox1.Text.Length < 4)
            {
                MessageBox.Show("Довжина імені  маленька");
            }
            else if (textBox2.Text.Trim().Length == 0 || textBox2.Text.Length < 8)
            {
                MessageBox.Show("Довжина пароля дорівнює нулю");
            }
            else if (textBox3.Text.Trim().Length == 0 )
            {
                MessageBox.Show("Довжина email null"); // не подобається викликати меседж бокси
            }
            else
            {
                userService.createUser(textBox1.Text, textBox2.Text, textBox3.Text);
                this.Close();
            }
        }
    }
}
