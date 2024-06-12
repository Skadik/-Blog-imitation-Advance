using System;
using System.Windows.Forms;
using WindowsFormsAppInBlogImitation.Blogs;

namespace WindowsFormsAppInBlogImitation
{
    public partial class ChoiceArticle : Form
    {
        private Blog blog;
        public ChoiceArticle()
        {
            InitializeComponent();
            blog = new Blog();
            textBox2.Text = blog.getAllArticles().Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                new ShowArticle(blog.getArticelsForID(Int32.Parse(textBox1.Text))).ShowDialog();
            }
            else if (radioButton2.Checked)
            {
                new ShowArticle(blog.getAllArticles()).ShowDialog();
            }
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Controls.Add(this.textBox1);
                this.Controls.Add(this.label2);
                this.Controls.Add(this.textBox2);
                Controls.Add(this.label1);
            }
            else if (!radioButton1.Checked)
            {
                Controls.Remove(this.textBox1);
                Controls.Remove(this.label1);
                Controls.Remove(this.textBox2);
                Controls.Remove(this.label2);
            }
        }
    }
}
