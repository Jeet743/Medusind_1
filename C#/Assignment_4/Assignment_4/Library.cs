using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Library
    { 
    }

    public class Concession
    {
        public void CalculateConcession(int age) 
        {
            const int totalfare = 500;

            if (age <= 5) 
            {
                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if (age > 60)
            {
                int p;
                p = totalfare * 30 / 100;
                Console.WriteLine("Senior Citizen" + p);
            }
            else 
            {
                Console.WriteLine("Print Ticket Booked : "+ totalfare);
            }
        }
    }
}
