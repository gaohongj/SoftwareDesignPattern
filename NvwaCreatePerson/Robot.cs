using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvwaCreatePerson
{
    public class Robot : IPerson
    {
        public void Person()
        {
            Console.WriteLine("Robot created successfully");
        }
    }
}
