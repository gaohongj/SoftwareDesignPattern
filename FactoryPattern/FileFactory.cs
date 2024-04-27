using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FileFactory:ILogFactory
    {
        public ILogger Log() {
            ILogger Logger;
            Logger =new FileLogger();
            Logger.CreateLog("File log has been record");
            return Logger;
        }
    }
}
