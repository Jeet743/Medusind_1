using System;
using System.Security.Claims;
using System.Xml.Linq;


namespace Assignment_2
{
    class Student
    {
        public int rollno;
        public string name;
        public int classN;
        public string sem;
        public string branch;
        public int[] marks = new int[5];
        

        public Student(int rollno1, string name1, int classN1, string sem1, string branch1)
        {
            rollno = rollno1;
            name = name1;
            classN = classN1;
            sem = sem1;
            branch = branch1;
        }

        public void GetMarks(int sub1, int sub2, int sub3, int sub4, int sub5)
        {
            marks[0] = sub1;
            marks[1] = sub2;
            marks[2] = sub3;
            marks[3] = sub4;
            marks[4] = sub5;
        }

        public void DisplayResult()
        {
            int sum = 0;
            for(int i=0;i < 5;i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("Failed");
                    return;
                }
                sum = sum + marks[i];
            }

            int avg = sum / 5;
            if(avg < 50)
            {
                Console.WriteLine("Failed");
            }
            else 
            {
                Console.WriteLine("Passed");
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("Roll No: " + rollno);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class: " + classN);
            Console.WriteLine("Semester: " + sem);
            Console.WriteLine("Branch: " + branch);
            Console.Write("Marks: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Student s = new Student(101, "Jeet", 1, "2", "IMCA");
            s.GetMarks(89, 78, 67, 45, 77);
            s.DisplayResult();
            //Console.WriteLine(s.rollno);
            //Console.WriteLine(s.name);
            //Console.WriteLine(s.classN);
            //Console.WriteLine(s.sem);
            //Console.WriteLine(s.branch);
            s.DisplayData();
            Console.ReadLine();
        }
    }
}
