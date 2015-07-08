using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tTrack the ticket\n\n");
            Tickets obj = new Tickets();
            obj.TicketGenerator();
            obj.TellAnnie();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Tickets
    {
        public int ticket;
        public int ticketsToSell;
        public int ticketSold;
       
	   public int TicketGenerator()
        {
            Random rnd = new Random();
            ticket = rnd.Next(1, 100);
            Console.WriteLine("Got {0} cine tickets ",ticket);
            return ticket;
        }
		
        public int TellAnnie()
        {
            Console.WriteLine("Enter the number of tickets you want to buy");
            ticketSold= Convert.ToInt32(Console.ReadLine());
            ticketsToSell = ticket - ticketSold;
            Console.WriteLine("Annie you have to sell {0}", ticketsToSell);
            return ticketsToSell;
        }
        
    }
}
