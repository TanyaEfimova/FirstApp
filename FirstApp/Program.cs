using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Worker worker = new Worker();
            ((IWorker)worker).Build();
        }
    }

    public interface IWorker
    {
        public void Build();
    }

    public class Worker : IWorker
    {
        void IWorker.Build()
        {
            throw new NotImplementedException();
        }
    }
}
