using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class DesktopBuilder : ComputerBuilder
    {
        public override void CreateCPU()
        {
            Console.WriteLine("CPU创建成功");
        }

        public override void CreateDisplay()
        {
            Console.WriteLine("显示器创建成功");
        }

        public override void CreateHardDisk()
        {
            Console.WriteLine("硬盘创建成功");
        }

        public override void CreateMemory()
        {
            Console.WriteLine("内存创建成功");
        }

        public override bool IsDisplay()
        {
            return true;
        }
    }
}
