using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam42
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle<int> triangle = new Triangle<int>(1,2,3);
            Triangle<uint> triangle1 = new Triangle<uint>(2u, 3u, 4u);
            Triangle<double> triangle2 = new Triangle<double>(4.5,5.5,6.5);
            Console.WriteLine($"{triangle.ToString()}\n{triangle1.ToString()}\n{triangle2.ToString()}");
            Console.WriteLine($"{triangle.Sqare()},{triangle.TriangleTrue()}\n{triangle1.Sqare()},{triangle1.TriangleTrue()}\n{triangle2.Sqare()},{triangle2.TriangleTrue()}");
            Console.ReadLine();       
        }
    }
}
