using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam43
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment<int> segment = new Segment<int>(4,4,-4,-4);
            Console.WriteLine(segment.ToString());
            Console.WriteLine(segment.LenghtSegment());
            Segment<long> segment1 = new Segment<long>(2, 2, 6, 6);
            Console.WriteLine(segment1.ToString());
            Console.WriteLine(segment1.LenghtSegment());
            Segment<double> segment2 = new Segment<double>(3.3,4.4,1.1,6.6);
            Console.WriteLine(segment2.ToString());
            Console.WriteLine(segment2.LenghtSegment());
            Console.ReadLine();


        }
    }
}
