using System;
using System.Collections.Generic;
using System.IO;

namespace FlightTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.GetCustomers();

            Ticket ticket = new Ticket();
            ticket.getTickets("1");

            Copoun copoun = new Copoun();
            copoun.getTCopouns();
        }
    }
}
