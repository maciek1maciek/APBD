using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
{
    public class Factory : InterfaceFactory
    {
        public User CreateUser(string firstName, string lastName, string email, DateTime dateOfBirth, Client client)
        {
            User user;
            switch (client.Name)
            {
                case "VeryImportantClient":
                    user = new VeryImportantClient(firstName, lastName, email, dateOfBirth, client);
                    break;
                case "ImportantClient":
                    user = new ImportantClient(firstName, lastName, email, dateOfBirth, client);
                    break;
                default:
                    user = new NormalClient(firstName, lastName, email, dateOfBirth, client);
                    break;
            }
            return user;
        }
    }
}
