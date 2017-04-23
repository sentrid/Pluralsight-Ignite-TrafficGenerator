using System.Threading;
using TrafficEngine;

namespace CommandLineInterface
{
    public class Program
    {
        private static readonly AutoResetEvent WaitGate = new AutoResetEvent(false);

        public static void Main(string[] args)
        {
            // Parse command line argument
            foreach (var arg in args)
            {
                switch (arg)
                {
                    case "start":

                        break;
                }
            }

            Engine.Start(10, 20);

            WaitGate.WaitOne();
        }
    }
}