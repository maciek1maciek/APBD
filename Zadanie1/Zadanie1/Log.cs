using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Log
    {
        public string path = "log.txt";

        public void addLog(string message)
        {
            using (FileStream objFilestream = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream))
                {
                    objStreamWriter.WriteLine(message);
                }
            }
        }


    }
}
