using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleFactoryPattern
{
    public class LineChart : IProduct
    {
        public void CreateProduct()
        {
            Console.WriteLine("LineChart创建成功");
        }
    }
}
