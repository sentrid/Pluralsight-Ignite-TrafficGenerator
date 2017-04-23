using System;
using System.Threading;
using System.Threading.Tasks;

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

        public void Update()
        {
            
        }

        private static FlightInformation AssembleFlightInfo()
        {
            return new FlightInformation()
            {
                Airspeed = 0,
                Altitude = 0,
                ArrivalAirport = "",
                CurrentTimeEnroute = TimeSpan.MinValue,
                DepartureAirport = "",
                FiledAltitude = 0,
                FlightNumber = "",
                FuelOnBoard = 0,
                GroundSpeed = 0,
                Heading = 0,
                TimeOffGate = DateTime.MinValue,
                TimeOffGround = DateTime.MinValue
            };
        }

        private async Task<int> UpdateAltitude()
        {
            return await Task.FromResult(0);
        }

        private Task<decimal[]> UpdatePosition()
        {
            return Task.FromResult(new[] {0.0M, 0.0M});
        }
    }
}