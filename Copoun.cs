using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FlightTicket
{
    class Copoun
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
        public string TicketId { get; set; }
        public List<Luggage> Luggage { get; set; }

        public void getTCopouns()
        {
            string[] lines = File.ReadAllLines(@"D:\OOP\FlightTicket\FlightTicket\Copouns.txt");
            List<Customer> custList = new List<Customer>();
            Console.WriteLine("CUSTOMER'S COPOUNS DETAILS");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }

    }
}
