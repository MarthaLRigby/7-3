using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string publisher = "O\'Reilly";
            Book one = new Book("Programming C# 3.0", "Jesse Liberty and Donald Xie", publisher, "9780596527433");
            Book two = new Book("C# 3.0 In a Nutshell", "Joseph Albahari and Ben Albahari", publisher, "9780596527570");
            Book three = new Book("C# 3.0 Cookbook", "Jay Hilyard and Stephen Teilhet", publisher, "9780596516109");
            one.displayBook();
            two.displayBook();
            three.displayBook();
        }
    }
    class Book
    {
        private string title;
        private string author;
        private string publisher;
        private string isbn;
        public Book(string t, string a, string p, string i)
        {
            title = t;
            author = a;
            publisher = p;
            isbn = i;
        }
        public void displayBook()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t",title,author,publisher,isbn);
        }
    }
}
