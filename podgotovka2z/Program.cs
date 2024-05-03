using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgotovka2z
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(Title.Init(), Author.Init(), Content.Init());
            book.Show();
            Console.Read();
        }
    }
}
