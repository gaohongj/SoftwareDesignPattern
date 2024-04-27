using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class ComputerBuilder
    {
        public abstract void CreateCPU();
        public abstract void CreateMemory();
        public abstract void CreateHardDisk();
        public abstract void CreateDisplay();
        public abstract bool IsDisplay();
    }
}
