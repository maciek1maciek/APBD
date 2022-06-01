using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
{
    internal class ImportantClient : User
    {
        public ImportantClient(string firstName, string lastName, string email, DateTime dateOfBirth, Client client) : base(firstName, lastName, email, dateOfBirth, client)
        {
            using (var userCreditService = new UserCreditService())
            {
                CreditLimit = userCreditService.GetCreditLimit(firstName, lastName, dateOfBirth) * 2;
            }
        }
    }
}
