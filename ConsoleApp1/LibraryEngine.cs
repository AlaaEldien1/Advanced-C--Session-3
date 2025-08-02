using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> Lbooks, BookFunctionPointer fptr)
        {
            foreach (Book book in Lbooks)
            {

                Console.WriteLine(fptr(book));

            }
        }
        //public static void ProcessBooks(List<Book> Lbooks, Func<Book, string> fptr)
        //{
        //    foreach (Book book in Lbooks)
        //    {

        //        Console.WriteLine(fptr(book));

        //    }
        //}
    }
}
       

