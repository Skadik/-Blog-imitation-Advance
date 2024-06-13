using System;
using System.Collections.Generic;
using WindowsFormsAppInBlogImitation.Users;

namespace WindowsFormsAppInBlogImitation.Fixtures
{
    public class UserFixture
    {
        private string[] names = { "Петро", "Микола", "Ібрагім", "Богдан", "Джек"};

        public List<User> createUsers(int count)
        {
            Random rnd = new Random();
            List<User> users = new List<User>();

            for (int i = 0; i < count; i++)
            {
                users.Add(new User(names[rnd.Next(0, names.Length)], "admin", "example@gmail.com"));
            }

            return users;
        }
    }
}
