namespace BuilderPattern
{
    public class Computer
    {
        public ComputerBuilder computerBuilder;

        public Computer(ComputerBuilder builder)
        {
            this.computerBuilder = builder;
        }
        public ComputerBuilder Construct()
        {
            computerBuilder.CreateCPU();
            computerBuilder.CreateHardDisk();
            computerBuilder.CreateMemory();
            if (computerBuilder.IsDisplay())
            {
                computerBuilder.CreateDisplay();
            }
            var Type = computerBuilder.GetType().Name;
           
            Console.WriteLine("{0}生产成功", Type);
            return computerBuilder;
        }
    }
}
