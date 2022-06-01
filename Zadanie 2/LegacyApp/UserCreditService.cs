using System;

namespace LegacyApp
{
    public class UserCreditService : AbstractUserCreditSerive, IDisposable
    {
        public override void Dispose()
        {
            //...
        }

        public override int GetCreditLimit(string firstName, string lastName, DateTime dateOfBirth)
        {
            //Fetching the data...
            return 10000;
        }

    }
}