namespace WindowsFormsAppInBlogImitation.Users
{
    public class User
    {
        private static int countID = 0;  
        private int ID;
        private string name;
        private string email;
        private string password;

        public int getID() =>  ID; 
        public string getName() => name;
        public string getEmail() => email;
        public string getPassword() => password;

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setName(string name)
        {
            this.name= name;
        }

        public User(string name,string password, string email)
        {
            ID = countID++;
            this.name = name;
            this.email = email;
            this.password = password;
        }
    }
}
