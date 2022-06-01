using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
{
    public abstract class AbstractUserCreditSerive : IDisposable
    {
        public abstract void Dispose();

        public abstract int GetCreditLimit(string firstName, string lastName, DateTime dateOfBirth);
    }
}
