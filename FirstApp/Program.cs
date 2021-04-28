using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Build();
        }
    }

    public interface IWorker
    {
        public void Build();
    }

    public class Worker : IWorker
    {
        public void Build()
        {
            throw new NotImplementedException();
        }
    }
}
