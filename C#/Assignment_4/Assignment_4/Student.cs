using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public abstract class Student
    {
        public string Name;
        public int StudentId;
        public double Grade;

        public abstract bool Ispassed(double grade);
    }

    class Undergraduate : Student
    {
        public override bool Ispassed(double grade)
        {
            if(grade > 70.0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }

    class Graduate : Student
    {
        public override bool Ispassed(double grade)
        {
            if (grade > 80.0)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }

    class Program1
    {
        private static void Main()
        {
            Student s;

            s = new Undergraduate();
            s = new Graduate();

            Console.WriteLine("Please Enter Name: ");
            s.Name = Console.ReadLine();

            Console.WriteLine("\nPlease Enter StudentId: ");
            s.StudentId = Convert.ToInt32(Console.Read());

            Console.WriteLine("\nPlease Enter Grade: ");
            s.Grade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Status : ",s.Ispassed(s.Grade));

            Console.ReadLine();
        }
    }
}
