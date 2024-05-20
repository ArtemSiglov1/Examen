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
            Triangle<int> triangle = new Triangle<int>(4,5,6);
            Triangle<uint> triangle1 = new Triangle<uint>(6u, 7u, 8u);
            Triangle<double> triangle2 = new Triangle<double>(6.1,7.1,8.1);
            Console.WriteLine($"{triangle.ToString()}\n{triangle1.ToString()}\n{triangle2.ToString()}");
            Console.WriteLine($"{triangle.Sqare()},{triangle.TriangleTrue()}\n{triangle1.Sqare()},{triangle1.TriangleTrue()}\n{triangle2.Sqare()},{triangle2.TriangleTrue()}");
            Console.ReadLine();       
        }
    }
}
