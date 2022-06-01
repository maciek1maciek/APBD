using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
{
    interface InterfaceFactory
    {
        User CreateUser(string firstName, string lastName, string email, DateTime dateOfBirth, Client client);
    }
}
