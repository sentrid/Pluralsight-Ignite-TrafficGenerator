using System.Threading;

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

        /// <summary>
        /// Starts the traffic generation engine.
        /// </summary>
        /// <param name="maximumNumberOfFlights">The maximum number of flights.</param>
        /// <param name="interval">The interval in which to generate a new flight in milliseconds.</param>
        public static void Start(int maximumNumberOfFlights, int interval)
        {
            _maximumNumberOfFlights = maximumNumberOfFlights;
            _interval = interval;

            var timer = new Timer(x =>
            {
                GenerateFlight();

            }, null, 0, _interval);
        }

        /// <summary>
        /// Generates the flight.
        /// </summary>
        /// TODO Edit XML Comment Template for GenerateFlight
        private static void GenerateFlight()
        {
            
        }
    }
}