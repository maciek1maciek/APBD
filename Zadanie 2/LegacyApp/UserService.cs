using System;

namespace LegacyApp
{
    public class UserService
    {

        private bool result = true;
        private ClientRepository clientRepository;
        private InterfaceFactory Factory;
        public bool AddUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId)
        { 
            result &= CheckEmpty(firstName, lastName);
            result &= CheckEmail(email);
            result &= CheckDateOfBirth(dateOfBirth);

            if (result != true)
            {
                return false;
            }
              
            var client = clientRepository.GetById(clientId);

            //
            var user = Factory.CreateUser(firstName, lastName, email, dateOfBirth, client);


            if (user.HasCreditLimit && user.CreditLimit < 500)
            {
                return false;
            }

            UserDataAccess.AddUser(user);
            return true;
        }

        public bool CheckEmpty(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                return false;
                Console.WriteLine("pusty");
            }
            return true;
        }
        
        public bool CheckEmail(string email)
        {
            if (!email.Contains("@") && !email.Contains("."))
            {
                return false;
            }
            return true;
        }

        public bool CheckDateOfBirth(DateTime dateOfBirth)
        {
            var now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;
            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;

            if (age < 21)
            {
                return false;
            }

            return true;
        }

        public UserService()
        {
            clientRepository = new ClientRepository();
            Factory = new Factory();
        }
    }
}
