using System;

namespace TrafficEngine
{
    public class FlightInformation
    {
        public string FlightNumber { get; set; }

        public string DepartureAirport { get; set; }

        public string ArrivalAirport { get; set; }

        public int FiledAltitude { get; set; }

        public int Altitude { get; set; }

        public int Heading { get; set; }

        public int Airspeed { get; set; }

        public int GroundSpeed { get; set; }

        public DateTime TimeOffGate { get; set; }

        public DateTime TimeOffGround { get; set; }

        public DateTime CurrentTimeEnroute { get; set; }

        public int FuelOnBoard { get; set; }
    }
}