using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_250207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books("Harry Potter", "J.K. Rowling", 1997, 300, 5000);
            Books book2 = new Books("The Lord of the Rings", "J.R.R. Tolkien");

            Console.WriteLine(book1.IncreasePrice(2500));
            Console.WriteLine(book1.PagesLeft(250));
            Console.WriteLine(book1.discount(25));

            book2.Year = 1954;
            book2.Pages = 1000;
            book2.Price = 9800;

            Console.WriteLine(book1.Title);
            Console.WriteLine(book1.Author);
            Console.WriteLine(book1.Year);
            Console.WriteLine(book1.Pages);
            Console.WriteLine(book1.Price);

            Console.WriteLine("\n");

            Console.WriteLine(book2.Title);
            Console.WriteLine(book2.Author);
            Console.WriteLine(book2.Year);
            Console.WriteLine(book2.Pages);
            Console.WriteLine(book2.Price);

            Console.ReadKey();
        }
    }
}
