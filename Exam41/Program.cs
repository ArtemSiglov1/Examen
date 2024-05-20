using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam41
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> point = new Point<int>(2,2);
            Point<uint> point1 = new Point<uint>(5,5);
            Point<double> point2 = new Point<double>(7.1, 7.1);
            Console.WriteLine($"A({point})\nB({point1})\nC({point2})");
            Console.ReadLine();
        }
    }
}
