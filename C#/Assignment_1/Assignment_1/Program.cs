using System;


namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cheack_equal();
            positive_negative p1 = new positive_negative();
            p1.posnega();

        }

        // 1. Write a C# Sharp program to accept two integers and check whether they are equal or not. 
        static void cheack_equal()
        {
            int no1, no2;

            Console.Write("Please Enter Number 1: ");
            no1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter Number 2: ");
            no2 = Convert.ToInt32(Console.ReadLine());

            if (no1 == no2)
            {
                Console.WriteLine("{0} and {1} are equal.\n", no1, no2);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not equal.\n", no1, no2);
            }
            Console.Read();
        }
    }

    // 2. 
    class positive_negative
    {
        public void posnega()
        {
            int n;
            Console.WriteLine("Please Enter A Number: ");
            n = Convert.ToInt32(Console.ReadLine());

            if(n>=0)
            {
                Console.WriteLine("{0} is a positive number.", n);
            }
            else 
            {
                Console.WriteLine("{0} is a negative number.", n);
            }
            Console.Read();
        }
    }
}


