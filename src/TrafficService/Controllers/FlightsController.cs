using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, 
// visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TrafficService.Controllers
{
    [Route("api/[controller]")]
    public class FlightsController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] {"value1", "value2"};
        }

        [HttpGet]
        [Route("start")]
        public void Start()
        {
            return;
        }

        [HttpGet]
        [Route("start/{totalFlights}/{startFlightsInterval}")]
        public void Start(int totalFlights, int startFlightsInterval)
        {
            return;
        }
    }
}