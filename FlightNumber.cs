using System;
using System.Collections.Generic;
using System.Text;

namespace FlightTicket
{
    class FlightNumber
    {
        public string Departure { get; set; } 
        public string Description { get; set; }
        public string Airline { get; set; }
        public List<Flight> Flights { get; set; }

        public Airport Start { get; set; }
        public Airport End { get; set; }


    }
}
