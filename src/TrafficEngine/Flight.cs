using System.Threading;

namespace TrafficEngine
{
    public class Flight
    {
        private static readonly AutoResetEvent AutoResetEvent = new AutoResetEvent(false);

        public static FlightInformation FlightInformation { get; private set; }

        public static void Initialize()
        {
            FlightInformation = AssembleFlightInfo();
            AutoResetEvent.WaitOne();
        }

        private static FlightInformation AssembleFlightInfo()
        {
            return new FlightInformation();
        }
    }
}