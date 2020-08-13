using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FlightTicket
{
    class Ticket
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
        public List<Copoun> copoun { get; set; }
        public void getTickets(String custID)
        {
            var arr = File.ReadLines(@"D:\OOP\FlightTicket\FlightTicket\Tickets.txt").Select(l => l.Split(',')[0]).ToList();
            Console.WriteLine("CUSTOMER'S TICKETS DETAILS");
            for(int i=0; i<arr.Count; i++)
            {
                if(arr[i] == custID)
                {
                    string[] lines = File.ReadAllLines(@"D:\OOP\FlightTicket\FlightTicket\Tickets.txt");
                    Console.WriteLine(lines[i]);


                }
            }
        }
    }
}
