using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class G2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("\nPlease Enter A String: ");
            string s = Console.ReadLine();

            Console.WriteLine("\nPlease Enter A Character To Be Count: ");
            char letter = Convert.ToChar(Console.ReadLine());

            int count = 0;

            foreach (char c in s)
            {
                if(c == letter)
                {
                    count++;
                }
            }

            Console.WriteLine($"The Letter {letter} Appers {count} Times In The String");
            Console.ReadLine();


        }
    }
}
