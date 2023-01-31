using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consession;

namespace ConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int Age;
            Console.Write("Please Enter Name : ");
            Name = Console.ReadLine();

            Console.Write("Please Enter Age : ");
            Age = int.Parse(Console.ReadLine());

            Consession1 c = new Consession1();
            Console.WriteLine("------------------------");
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            c.CalculateConcession(Age);
            Console.ReadLine();
        }
    }
}
