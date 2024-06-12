using System.Windows.Forms;
using WindowsFormsAppInBlogImitation.Blogs;

namespace WindowsFormsAppInBlogImitation.CreatorForShowArticle
{
    public class Creator
    {
        public TextBox createTextBox(int Y, string discription)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(930, Y + 70);
            textBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            textBox.Multiline = true;
            textBox.Name = "textBox1";
            textBox.Size = new System.Drawing.Size(600, 91);
            textBox.TabIndex = 0;
            textBox.Text = discription;
            textBox.ReadOnly = true;
            return textBox;
        }

        public Label createLabelTitle(int Y, string titleText)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(930, Y + 25);
            label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label.Name = "label2";
            label.Size = new System.Drawing.Size(109, 25);
            label.TabIndex = 5;
            label.Text = titleText;
            return label;
        }

        public Label createLabelID(int Y, int ID)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(1480, Y);
            label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label.Name = "label2";
            label.Size = new System.Drawing.Size(109, 25);
            label.TabIndex = 5;
            label.Text = "ID :" + ID;
            return label;
        }

        public Label createLabelUserName(int Y, string nameText)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(930, Y);
            label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label.Name = "label2";
            label.Size = new System.Drawing.Size(109, 25);
            label.TabIndex = 5;
            label.Text = nameText;
            return label;
        }
    }
}
