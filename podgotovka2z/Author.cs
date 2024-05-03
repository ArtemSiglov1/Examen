using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgotovka2z
{
    internal class Author
    {
        string name;
        public Author(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine(name);
        }
        public static Author Init()
        {
            Console.WriteLine("Input author name");
            string name = Console.ReadLine();
            return new Author(name);
        }
    }
}
