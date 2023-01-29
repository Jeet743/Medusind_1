using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class ScolarShip
    {
        public int totalmarks;
        public float fees;

        public float Merit(int x, float y)
        {
            if(x >= 70 && y <= 80)
            {
                return (y * 20) / 100;
            }
            else if (x > 80 && x <= 90)
            {
                return (y * 30) / 100;
            }
            else if (x > 90)
            {
                return (y * 50) / 100;
            }
            else
            {
                return 0;
            }

        }

        static void Main(String[]args)
        {
            ScolarShip s = new ScolarShip();
            
            Console.Write("\nPlease Enter Total Marks : ");
            s.totalmarks = int.Parse(Console.ReadLine());

            Console.Write("\nPlese Enter Fess : ");
            s.fees = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nScholarship Amount is : " + s.Merit(s.totalmarks, s.fees));
            Console.ReadLine();
        }

    }
}
