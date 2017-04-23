using System;
using System.Threading;
using TrafficEngine;

namespace TrafficClr
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
                    case "flights":
                        break;
                    case "interval":
                        break;
                    default:
                        ShowHelp();
                        break;
                }
            }

            Engine.Start(10, 20);

            WaitGate.WaitOne();
        }

        private static void ShowHelp()
        {
            Console.WriteLine();
        }
    }
}
