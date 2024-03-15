using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryberries.Model
{
    internal class User
    {
        public int UserArticle;
        public string FullName;
        public string Email;
        public string PhoneNumber;
        public string Password;

        public User(int userArticle, string fullName, string email, string phoneNumber, string password)
        {
            UserArticle = userArticle;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }
    }
}
