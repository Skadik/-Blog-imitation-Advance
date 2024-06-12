using System;
using WindowsFormsAppInBlogImitation.Users;
using System.Windows.Forms;

namespace WindowsFormsAppInBlogImitation
{
    public partial class Form1 : Form
    {
        private UserService userService;
        public Form1()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Довжина імені дорівнює нулю");
            }
            else if (textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Довжина пароля дорівнює нулю");
            }
            else if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Довжина пароля дорівнює нулю"); // не подобається викликати меседж бокси
            }
            else
            {
                userService.createUser(textBox1.Text, textBox2.Text, textBox3.Text);
                this.Close();
            }
        }
    }
}
