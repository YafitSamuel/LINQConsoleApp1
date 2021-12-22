using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsoleApp1
{
    public class Book
    {
        public string bookName;
        public string writer;
        public int numOfPages;
     public Book(string bookName, string writer, int numOfPages)
        {
            this.bookName = bookName;
            this.writer = writer;
            this.numOfPages = numOfPages;
        }
    }
}
