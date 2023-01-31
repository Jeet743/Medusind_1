using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consession
{
    public class Consession1
    {
        const int Totalfare = 500;
        public void CalculateConcession(int age)
        {
            if (age <= 5)
            {
                Console.WriteLine("Little Champs- Free Ticket");
            }
            else if(age > 60)
            {
                Console.WriteLine("Senior Citizen totalfare : Rs=" + (Totalfare - ((Totalfare * 30) / 100)));
            }
            else
            {
                Console.WriteLine("Price Ticket Booked: Rs=" + Totalfare);
            }
        }
    }
}
