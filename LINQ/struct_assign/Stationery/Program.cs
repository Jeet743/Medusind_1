using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string>();

            while (true)
            {
                Console.WriteLine("1..Add Stationery");
                Console.WriteLine("2..Display Stationery");
                Console.WriteLine("3..Exit");

                Console.WriteLine("Please Enter Your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please Enter Stationery Name: ");
                        string st = Console.ReadLine();
                        Console.WriteLine("Please Enter Price: ");
                        string p = Convert.ToString(Console.ReadLine());
                        s.Add(st);
                        s.Add(p);
                        Console.WriteLine("Added..!!");
                        break;

                    case 2:
                        Console.WriteLine("The List Is: ");
                        foreach (string item in s)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                
            }
        }
    }
}
