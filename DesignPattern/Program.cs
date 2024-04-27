using FactoryPattern;
using NvwaCreatePerson;
using SingleFactoryPattern;
using System.Runtime.CompilerServices;
using System.Configuration;
using System.Reflection;
using BuilderPattern;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* demo1
            IProduct iproduct;

            iproduct = Factory.ProduceFactory("Pie");

            Console.WriteLine("产品生产成功");
            */

            /*demo2 
            IPerson person;
            person = Nvwa.GetPerson("M");
            */


            /*Demo3
            ILogFactory logFactory;
            ILogger log;
            logFactory=new FileFactory();
            log = logFactory.Log();
            //*/
            //ILogFactory logFactory;
            //ILogger log;

            //string facttoryType = ConfigurationManager.AppSettings["FileFactory"];

            //logFactory = (ILogFactory)Assembly.Load("FactoryPattern").CreateInstance(facttoryType);
            //log = logFactory.Log();

            //Console.WriteLine("生成成功");

            //PCBuilder pCBuilder = new PCBuilder();
            //DesktopBuilder desktopBuilder = new DesktopBuilder();
            //Computer computer=new Computer(desktopBuilder);
            //computer.Construct();
            
            //使用反射机制的方式去实现
            ComputerBuilder builder;
            string facttoryType = ConfigurationManager.AppSettings["ServerBuilder"];

            builder = (ComputerBuilder)Assembly.Load("BuilderPattern").CreateInstance(facttoryType);
            DesktopBuilder desktopBuilder = new DesktopBuilder();
            Computer computer=new Computer(builder);
            computer.Construct();
            Console.WriteLine("生成成功");
        }
    }
}
