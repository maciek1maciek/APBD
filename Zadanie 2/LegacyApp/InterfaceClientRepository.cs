using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
{
    internal interface InterfaceClientRepository
    {
        Client GetById(int clientId);
    }
}
