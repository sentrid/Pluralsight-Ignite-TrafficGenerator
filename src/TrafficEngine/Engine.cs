using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TrafficEngine
{
    /// <summary>
    ///     Class Engine.
    /// </summary>
    /// TODO Edit XML Comment Template for Engine
    public static class Engine
    {
        private static int _interval;
        private static int _maximumNumberOfFlights;

        private static readonly List<Task> Flights = new List<Task>();

        /// <summary>
        ///     Starts the traffic generation engine.
        /// </summary>
        /// <param name="maximumNumberOfFlights">The maximum number of flights.</param>
        /// <param name="interval">The interval in which to generate a new flight in milliseconds.</param>
        public static void Start(int maximumNumberOfFlights, int interval)
        {
            _maximumNumberOfFlights = maximumNumberOfFlights;
            _interval = interval;

            var timer = new Timer(x =>
            {
                if(Flights.Count <= _maximumNumberOfFlights)
                    Flights.Add(Task.Run(() => { Flight.Initialize(); }));
                
            }, null, 0, _interval);
            
            Task.WaitAll(Flights.ToArray());
        }
    }
}