using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    internal class Employee
    {
        public int EmployeeId;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string city;
    }

    class emp
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>
            {
                new Employee { EmployeeId = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 06, 08), city = "Mumbai" },
                new Employee { EmployeeId = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 08, 20), DOJ = new DateTime(2012, 07, 07), city = "Mumbai" },

                new Employee { EmployeeId = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 04, 12), city = "Pune" },
                new Employee { EmployeeId = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 06, 03), DOJ = new DateTime(2016, 02, 02), city = "Pune" },

                new Employee { EmployeeId = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 03, 08), DOJ = new DateTime(2016, 02, 02), city = "Mumbai" },
                new Employee { EmployeeId = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 07), DOJ = new DateTime(2014, 08, 08), city = "Chennai" },

                new Employee { EmployeeId = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 02), DOJ = new DateTime(2015, 06, 01), city = "Mumbai" },
                new Employee { EmployeeId = 1008, FirstName = "Rahul", LastName = "Dubay", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 06), city = "Chennai" },

                new Employee { EmployeeId = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 08, 12), DOJ = new DateTime(2014, 12, 03), city = "Chennai" },
                new Employee { EmployeeId = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 04, 12), DOJ = new DateTime(2016, 01, 02), city = "Pune" },

            };

            // a. Display detail of all the employee
            Console.WriteLine("-------------------------------QUERY : 01------------------------------------------\n");
            var r = from I in list
                    select I;

            foreach (Employee e in r)
            {
                Console.WriteLine($"Employee ID: {e.EmployeeId} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB} | DOJ: {e.DOJ} | City: {e.city}");
                Console.WriteLine("\n--------------\n");
            }

            // b. Display details of all the employee whose location is not Mumbai
            Console.WriteLine("\n------------------------------QUERY : 02--------------------------------------\n");
            var a = from I in list
                    where I.city != "Mumbai"
                    select I;

            foreach (Employee e in a)
            {
                Console.WriteLine($"Employee ID: {e.EmployeeId} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB} | DOJ: {e.DOJ} | City: {e.city}");
                Console.WriteLine("\n--------------\n");
            }

            // c. Display details of all the employee whose title is AsstManager
            Console.WriteLine("\n------------------------------QUERY : 03--------------------------------------\n");
            IEnumerable<Employee> l = from I in list
                                      where I.Title == "AsstManager"
                                      select I;

            foreach (Employee e in l)
            {
                Console.WriteLine($"Employee ID: {e.EmployeeId} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB} | DOJ: {e.DOJ} | City: {e.city}");
                Console.WriteLine("\n--------------\n");
            }

            // d. Display details of all the employee whose Last Name start with S
            Console.WriteLine("\n------------------------------QUERY : 04--------------------------------------\n");
            IEnumerable<Employee> l1 = from I in list
                                      where I.LastName.StartsWith("S")
                                      select I;

            foreach (Employee e in l1)
            {
                Console.WriteLine($"Employee ID: {e.EmployeeId} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB} | DOJ: {e.DOJ} | City: {e.city}");
                Console.WriteLine("\n--------------\n");
            }

            // e. Display a list of all the employee who have joined before 1/1/2015
            Console.WriteLine("\n------------------------------QUERY : 05--------------------------------------\n");
            var r1 = from I in list
                    where I.DOJ < DateTime.Parse("1/1/2015")
                    select I;

            foreach (Employee e in r1)
            {
                Console.WriteLine($"Employee ID: {e.EmployeeId} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB} | DOJ: {e.DOJ} | City: {e.city}");
                Console.WriteLine("\n--------------\n");
            }

            // f.Display a list of all the employee whose date of birth is after 1 / 1 / 1990
            Console.WriteLine("\n------------------------------QUERY : 06--------------------------------------\n");
            var r2 = from I in list
                     where I.DOJ > DateTime.Parse("1/1/1990")
                     select I;

            foreach (Employee e in r2)
            {
                Console.WriteLine($"Employee ID: {e.EmployeeId} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB} | DOJ: {e.DOJ} | City: {e.city}");
                Console.WriteLine("\n--------------\n");
            }

            // g. Display a list of all the employee whose designation is Consultant and Associate
            Console.WriteLine("\n------------------------------QUERY : 07--------------------------------------\n");
            var r3 = from I in list
                     where I.Title == "Consultant" || I.Title == "Associate"
                     select I;

            foreach (Employee e in r3)
            {
                Console.WriteLine($"Employee ID: {e.EmployeeId} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB} | DOJ: {e.DOJ} | City: {e.city}");
                Console.WriteLine("\n--------------\n");
            }

            // h.Display total number of employees
            Console.WriteLine("\n------------------------------QUERY : 08--------------------------------------\n");
            var r4 = from I in list
                     select I;

            Console.WriteLine($"Total Employee: {r4.Count()}");
            Console.WriteLine("\n-----------------------------------\n");

            //  i.Display total number of employees belonging to “Chennai”
            Console.WriteLine("\n------------------------------QUERY : 09--------------------------------------\n");
            var r5 = from I in list
                     where I.city == "Chennai"
                     select I;

            Console.WriteLine($"Total Employee: {r4.Count()}");
            Console.WriteLine("\n-----------------------------------\n");

            // j. Display highest employee id from the list
            Console.WriteLine("\n------------------------------QUERY : 10--------------------------------------\n");
            var r6 = list.Max(e => e.EmployeeId);

            Console.WriteLine(r6);


            // k.Display total number of employee who have joined after 1 / 1 / 2015
            Console.WriteLine("\n------------------------------QUERY : 11--------------------------------------\n");
            var r7 = from I in list
                     where I.DOJ > DateTime.Parse("1/1/2015")
                     select I;

            foreach (Employee e in r7)
            {
                Console.WriteLine($"Employee ID: {e.EmployeeId} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB} | DOJ: {e.DOJ} | City: {e.city}");
                Console.WriteLine("\n--------------\n");
            }


            // l.Display total number of employee whose designation is not “Associate”
            Console.WriteLine("\n------------------------------QUERY : 12--------------------------------------\n");
            var r8 = from I in list
                     where I.Title != "Associate"
                     select I;

            foreach (Employee e in r8)
            {
                Console.WriteLine($"Employee ID: {e.EmployeeId} | FirstName: {e.FirstName} | LastName: {e.LastName} | Title: {e.Title} | DOB: {e.DOB} | DOJ: {e.DOJ} | City: {e.city}");
                Console.WriteLine("\n--------------\n");
            }

            // m. Display total number of employee based on City
            Console.WriteLine("\n------------------------------QUERY : 13--------------------------------------\n");
            var r9 = from I in list.GroupBy(e => e.city)
                     select new
                     {
                         cityname = I.First().city,
                         ccount = I.Count()
                     };
            

            foreach (var e in r9)
            {
                Console.WriteLine($"City Name : {e.cityname} | Total Employee :  {e.ccount}");
            }

            // n. Display total number of employee based on city and title
            Console.WriteLine("\n------------------------------QUERY : 14--------------------------------------\n");
            var r10 = from I in list.GroupBy(e => e.city)
                     select new
                     {
                         cityname = I.First().city,
                         t = I.First().Title,
                         ccount = I.Count()
                     };

            foreach (var e in r10)
            {
                Console.WriteLine($"City Name : {e.cityname} | Title : {e.t}| Total Employee :  {e.ccount} ");
            }

            // o. Display total number of employee who is youngest in the list
            Console.WriteLine("\n------------------------------QUERY : 15--------------------------------------\n");
            var r11 = from I in list
                      where I.DOB > DateTime.Parse("1/1/1992")
                      select I;

            Console.WriteLine($"Total Youngest :  {r11.Count()}");

            Console.ReadLine();
        }
    }
}
