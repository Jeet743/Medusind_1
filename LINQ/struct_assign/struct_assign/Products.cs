using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_assign
{
    public class Product
    {

        public int Productid { get; set; }
        public string Productname { get; set; }
        public double Price { get; set; }
    }

    class Products
    {
        static void Main()
        {
            List<Product> plist = new List<Product>();
            Console.WriteLine("Please Enter Product Details: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please Enter Product Details For Product " + (i + 1));

                Console.WriteLine("Please Enter Product Id:");
                int productId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter Product Name:");
                string productName = Console.ReadLine();

                Console.WriteLine("Please Enter Product Price:");
                double productPrice = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("----------------------------------------------------");

                Product p = new Product
                {
                    Productid = productId,
                    Productname = productName,
                    Price = productPrice

                };

                plist.Add(p);
            }

            plist.Sort((x, y) => x.Price.CompareTo(y.Price));

            Console.WriteLine("\nSorted Products based on Price:");
            foreach (Product p in plist)
            {
                Console.WriteLine("Product Id: " + p.Productid + " Product Name: " + p.Productname + " Price: " + p.Price);
            }

            Console.ReadLine();

        }
    }
}


