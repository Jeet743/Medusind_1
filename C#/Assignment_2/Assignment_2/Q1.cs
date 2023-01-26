/*
 
Strings Assignment:

1.	Write a program in C# to accept a word from the user and display the length of it.
2.	Write a program in C# to accept a word from the user and display the reverse of it. 
3.	Write a program in C# to accept two words from user and find out if they are same.
 
*/

using System;
using System.Collections;


namespace Assignment_2
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            Q1 p = new Q1();
          
            p.rev();
        }

        // Write a program in C# to accept a word from the user and display the length of it.
        public void length()
        {
            string str;
            Console.WriteLine("Please Enter A String: ");
            str = Console.ReadLine();

            Console.WriteLine("Your String Is: " + str);
            Console.WriteLine("Length Of String Is: " + str.Length);
            Console.Read();
        }

        // Write a program in C# to accept a word from the user and display the reverse of it. 
        public void rev()
        {
            Console.Write("Please Enter A Word : ");
            string oS = Console.ReadLine();

            string rS = "";
            for (int i = oS.Length - 1; i >= 0; i--)
            {
                rS += oS[i];
            }
            Console.Write($"Reverse Word Is : {rS} ");
            Console.ReadLine();
        }

        // Write a program in C# to accept two words from user and find out if they are same.
        public void same()
        {
            string str1, str2;

            Console.WriteLine("Please Enter A String: ");
            str1 = Console.ReadLine();

            Console.WriteLine("Please Enter A String: ");
            str2 = Console.ReadLine();

            if (str1 == str2)
            {
                Console.WriteLine("Strings Are Equal..!!");
            }
            else
            {
                Console.WriteLine("String Are Not Equal..!!");
            }
            Console.Read();
        }
    }
}

    

