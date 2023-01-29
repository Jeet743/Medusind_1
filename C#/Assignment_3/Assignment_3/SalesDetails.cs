using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class SalesDetails
    {
        public int SalesNo;
        public int ProductNo;
        public float price;
        public DateTime dateofsale;
        public int qty;
        public float TotalAmount;

        public SalesDetails(int salesno, int productno, float price, DateTime dos,int qty) 
        {
            this.SalesNo = salesno;
            this.ProductNo = productno;
            this.price = price;
            this.dateofsale = dos;
            this.qty = qty;
            Sales(this.qty,this.price);
        }

        void Sales(int qty, float price)
        {
            this.TotalAmount = qty * price;
        }

        public void ShowData()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Sales No : {this.SalesNo}");
            Console.WriteLine($"Product No : {this.ProductNo}");
            Console.WriteLine($"Product Price : {this.price}");
            Console.WriteLine("Sales Date : ", this.dateofsale);
            Console.WriteLine($"Product Quantity : {this.qty}");
            Console.WriteLine($"Total Amount : {this.TotalAmount}");
        }

        static void Main()
        {
            Console.Write("Please Enter Sales No : ");
            int SalesNo = int.Parse(Console.ReadLine());

            Console.Write("\nPlease Enter Product No : ");
            int ProductNo = int.Parse(Console.ReadLine());
            
            Console.Write("\nPlease Enter Price : ");
            float Price = float.Parse(Console.ReadLine());
            
            Console.Write("\nPlease Enter Sales Date : ");
            DateTime DateOfSale = DateTime.Parse(Console.ReadLine());

            Console.Write("\nPlease Enter Product Quantity : ");
            int Qty = int.Parse(Console.ReadLine());
            
            SalesDetails s = new SalesDetails(SalesNo, ProductNo, Price, DateOfSale, Qty);
            s.ShowData();
            Console.ReadLine();

        }
    }
}
