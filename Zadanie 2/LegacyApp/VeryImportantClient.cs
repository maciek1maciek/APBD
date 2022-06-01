using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
{
    public class VeryImportantClient : User
    {

        public VeryImportantClient(string firstName, string lastName, string email, DateTime dateOfBirth, Client client) : base(firstName, lastName, email, dateOfBirth, client)
        {
            HasCreditLimit = false;
        }

    }
        
}
