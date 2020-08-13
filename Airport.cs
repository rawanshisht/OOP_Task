﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FlightTicket
{
    class Airport
    {
        public string Name { get; set; }
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



    }
}
