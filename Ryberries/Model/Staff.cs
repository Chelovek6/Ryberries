using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryberries.Model
{
    internal class Staff
    {
        public int StaffArticle;
        public string Name;
        public string Position;
        public string EmploymentContract;
        public string Password;
        public bool IsAdmin;

        public Staff(int staffArticle, string name, string position, string employmentContract, string password, bool isAdmin)
        {
            StaffArticle = staffArticle;
            Name = name;
            Position = position;
            EmploymentContract = employmentContract;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}
