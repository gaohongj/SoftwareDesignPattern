using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class DBFactory:ILogFactory
    {
        public ILogger Log() {
            ILogger Logger;
            Logger =new DBLogger();
            Logger.CreateLog("DB log has been record");
            return Logger;
        }
    }
}
