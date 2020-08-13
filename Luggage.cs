using System;
using System.Collections.Generic;
using System.Text;

namespace FlightTicket
{
    class Luggage
    {
        string id;

        public string Id
        {
            set
            {
                Guid guid = Guid.NewGuid();
                id = guid.ToString();
            }
            get
            {
                return id;
            }
        }
        public int Weight { get; set; }

    }
}
