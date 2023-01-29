using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Q5
    {
        public static void Main()
        {
            int[] marks = new int[10];

            Console.WriteLine("Please Enter 10 Marks: ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter Marks : ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Total
            int total = marks.Sum();
            Console.WriteLine("\n\nTotal Marks : " + total);

            // Avg
            double avg = (double)total / marks.Length;
            Console.WriteLine("\n\nAverage Is: " + avg);

            // Min & Max
            int min = marks.Min();
            int max = marks.Max();
            Console.WriteLine("\n\nMinimum : " + min);
            Console.WriteLine("\n\nMaximum : " + max);

            // ASC
            for(int i=0;i < marks.Length;i++)
            {
                for(int j=i+1;j < marks.Length;j++)
                {
                    if (marks[i] > marks[j])
                    {
                        var v1 = marks[j];
                        marks[j] = marks[i];
                        marks[i] = v1;
                    }
                }
                Console.WriteLine("\n\nArray In Ascending Order : ");
                for (i = 0; i < marks.Length; i++)
                {
                    Console.WriteLine(marks[i]);
                }
            }

            // DESC
            for (int i = 0; i < marks.Length; i++)
            {
                for (int j = i + 1; j < marks.Length; j++)
                {
                    if (marks[i] < marks[j])
                    {
                        var temp = marks[j];
                        marks[j] = marks[i];
                        marks[i] = temp;
                    }
                }
            }
            Console.WriteLine("\n\nArray In Descending Order : ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.ReadLine();
        }
    }    
}
