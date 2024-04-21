using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FileLogger : ILogger
    {
        public void CreateLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
