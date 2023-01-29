using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Name: ");
            string fn = Console.ReadLine();

            Console.WriteLine("Please Enter Last Name: ");
            string ln = Console.ReadLine();

            Display(fn,ln);
        }

        public static void Display(string firstname, string lastname)
        {
            Console.WriteLine("-----UPPER CASE-----");
            Console.WriteLine(firstname.ToUpper());
            Console.WriteLine(lastname.ToUpper());

            Console.WriteLine("-----LOWER CASE-----");
            Console.WriteLine(firstname.ToLower());
            Console.WriteLine(lastname.ToLower());
            Console.Read();
        }
    }
}
