using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
{
    internal class NormalClient : User
    {
        public NormalClient(string firstName, string lastName, string email, DateTime dateOfBirth, Client client) : base(firstName, lastName, email, dateOfBirth, client)
        {
            HasCreditLimit = true;
            using (var userCreditService = new UserCreditService())
            {
                CreditLimit = userCreditService.GetCreditLimit(firstName, lastName, dateOfBirth);
            }
        }

    }
}
