using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgot1z
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = Rectangle.Init();
            Console.WriteLine( rectangle.Area());
            Console.WriteLine( rectangle.Perimetr());
            Console.ReadLine();
        }
    }
}
