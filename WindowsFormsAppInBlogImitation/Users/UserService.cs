using System.Collections.Generic;

namespace WindowsFormsAppInBlogImitation.Users
{
    public class UserService
    {
        List<User> users;
        public UserService()
        {
            users = new List<User>();
        }

        public void createUser(string userName,string email,string userPassword)
        {
            users.Add(new User(userName,email,userPassword));
        }

        public void deleteUser(int userID)
        {
            users.Remove(users.Find(user => user.getID() == userID));
        }

        public string registerPussword(string password)
        {
            return password;
        }

        public string registerEmail(string email)
        {
            return email;
        }

        public List<User> getUsers() => users;
    }
}
