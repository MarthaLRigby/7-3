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
        // Again, it's always better to use full names for your variables. In the case of constructors like this,
        // it's always better to use the full name in the constructor - so 
        // Book(string title, string author, string publisher, string isbn)
        // and then assign using e.g. this.title = title;
        {
            title = t;
            author = a;
            publisher = p;
            isbn = i;
        }
        public void displayBook()
        // In C#, methods are always written with capital letters at the start - so this method should be 
        // named as DisplayBook(). We use a Visual Studio plugin called Resharper that enforces this for us,
        // so don't worry about it too much, but it's always better to keep to the style for the language
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t",title,author,publisher,isbn);
        }
        // Even though the book does tell you to create a displayBook() method, it would probably be better
        // for this to override the ToString() method - then you can use it in other places and do things like
        // Console.WriteLine(book).
    }
}
