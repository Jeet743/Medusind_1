using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_assign
{
    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void getValues(string t1, string au1, string su1, int bid)
        {
            
            title = t1;
            author = au1;
            subject = su1;
            book_id = bid;
        }

        public void ShowValues()
        {
            Console.WriteLine("Title: {0}",title);
            Console.WriteLine("Author: {0}", author);
            Console.WriteLine("Subject: {0}", subject);
            Console.WriteLine("Book Id: {0}", book_id);
        }
    };

    internal class stru
    {
        static void Main(string[] args)
        {
           Books b1 = new Books();

            b1.getValues(".NET", "Banurekha", ".NET Full Course",4545);

            b1.ShowValues();

            Console.Read();

        }
    }
}
