using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleFactoryPattern
{
    public class PieChart: IProduct
    {
        public void CreateProduct()
        {
            Console.WriteLine("PieChart创建成功");
        }
    }
}
