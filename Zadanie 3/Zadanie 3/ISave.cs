using System.Collections.Generic;
using Zadanie_3.Models;

namespace Zadanie_3
{
    public interface ISave
    {
        
        void SaveList(List <Student> students, string path);
    }
}
