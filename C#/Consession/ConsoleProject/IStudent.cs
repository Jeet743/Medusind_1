using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }

        void ShowDetails();
    }

    class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("-----Dayscholar Details-----");
            Console.WriteLine("Student Id : " + StudentId);
            Console.WriteLine("Student Name : " + Name);
        }
    }

    class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("-----Residental Details------");
            Console.WriteLine("Student Id : " + StudentId);
            Console.WriteLine("Student Name : " + Name);
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            IStudent s;
            
            Console.WriteLine("Please Enter Dayscholar Details ");
            s = new Dayscholar();

            Console.Write("Please Enter Student Id : ");
            s.StudentId = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Name : ");
            s.Name = Console.ReadLine();

            s.ShowDetails();

            Console.WriteLine("---------------------------------");
            
            Console.WriteLine("Please Enter Resident Details: ");
            s = new Resident();

            Console.Write("Please Enter Student Id : ");
            s.StudentId = int.Parse(Console.ReadLine());
            
            Console.Write("Please Enter Name : ");
            s.Name = Console.ReadLine();
            
            s.ShowDetails();
            
            Console.Read();
        }
    }
}
