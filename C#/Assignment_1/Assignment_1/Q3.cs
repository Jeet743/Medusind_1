using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Q3
    {
        public static void Main()
        {
            int n1, n2;
            char expression;

            Console.Write("Please Enter Number 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter Expression : ");
            expression = Convert.ToChar(Console.ReadLine());

            Console.Write("Please Enter Number 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if(expression == '+')
            {
                Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
            }

            else if (expression == '-')
            {
                Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2);
            }

            else if (expression == '*')
            {
                Console.WriteLine("{0} * {1} = {2}", n1, n2, n1 * n2);
            }

            else if (expression == '/')
            {
                Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2);
            }

            else
            {
                Console.WriteLine("Wrong Expression!!");
            }
            Console.ReadLine();
        }
    }
}
