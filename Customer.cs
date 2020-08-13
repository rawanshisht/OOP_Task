using System;
using System.Collections.Generic;
using System.IO;

namespace FlightTicket
{
    class Customer
    {
        string id;

        public string Id { get {
                return id;
            } 
            set {
                id = Guid.NewGuid().ToString();
            }
        }
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; }
        public Customer()
        {

        }
        
        public void GetCustomers()
        { //read from file
            string[] lines = File.ReadAllLines(@"D:\OOP\FlightTicket\FlightTicket\Customers.txt");
            List<Customer> custList = new List<Customer>();
            Console.WriteLine("ALL CUSTOMERS");

            foreach (string line in lines) {
                Console.WriteLine(line);
            } 
        }
    }
}
