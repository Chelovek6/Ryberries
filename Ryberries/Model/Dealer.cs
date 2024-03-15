using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryberries.Model
{
    internal class Dealer
    {
        public int DealerArticle;
        public string OrganizationName;
        public string Email;
        public string PhoneNumber;

        public Dealer(int dealerArticle, string organizationName, string email, string phoneNumber)
        {
            DealerArticle = dealerArticle;
            OrganizationName = organizationName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
