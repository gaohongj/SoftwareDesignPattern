using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleFactoryPattern
{
    public class Factory
    {
        public static IProduct ProduceFactory(string Type)
        {
            IProduct product = null;
            switch (Type)
            {
                case "Pie":
                    product = new PieChart();
                    product.CreateProduct();
                    break;
                case "Line":
                    product = new LineChart();
                    product.CreateProduct();
                    break;
                case "Histogram":
                    product = new HistogramChart();
                    product.CreateProduct();
                    break;
            }
            return product;
        }
    }
}
