using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
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