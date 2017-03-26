using System.Threading;

namespace TrafficEngine
{
    public class Flight
    {
        private static readonly AutoResetEvent AutoResetEvent = new AutoResetEvent(false);
        private static FlightInformation _flightInformation;

        public static void Initialize()
        {
            _flightInformation = AssembleFlightInfo();
            AutoResetEvent.WaitOne();
        }

        private static FlightInformation AssembleFlightInfo()
        {
            return new FlightInformation();
        }
    }
}