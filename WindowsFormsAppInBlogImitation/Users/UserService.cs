using System.Collections.Generic;

namespace WindowsFormsAppInBlogImitation.Users
{
    public class UserService
    {
        private static List<User> users;
        public UserService()
        {
            users = new List<User>();
        }

        public void createUser(string userName,string userPassword, string email)
        {
            users.Add(new User(userName, userPassword,email));
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

        public static List<User> getUsers() => users;
    }
}
