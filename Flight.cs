using System;
using System.Collections.Generic;
using System.Text;

namespace FlightTicket
{
    class Flight
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
        public List<Copoun> Copouns { get; set; }


    }
}

