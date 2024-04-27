using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleFactoryPattern
{
    public class HistogramChart : IProduct
    {
        public void CreateProduct()
        {
            Console.WriteLine("HistogramChart创建成功");
        }
    }
}
