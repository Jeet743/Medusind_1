using System;

namespace BookTrain 
{
    internal class Passenger : ApplicationException
    {
        public string name;
        public int age;

        public void TicketBooking(int no_of_tickets)
        {
            if(no_of_tickets > 2)
            {
                throw new Exception("Can Not Book More Than 2 Tickets");
            }
            else
            {
                Console.WriteLine("Ticked Booked Successfully..!!");
            }
        }
    }

    class Test
    {
        static void Main(string[] args) 
        {
            Passenger p = new Passenger();

            Console.WriteLine("\nPlease Enter Name: ");
            p.name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nPlease cEnter Passenger Age: ");
            p.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease Enter Number of Tickets: ");
            int no_of_tickets = Convert.ToInt32(Console.ReadLine());

            try
            {
                p.TicketBooking(no_of_tickets);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();


        }
    }
}