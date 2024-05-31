using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>();
            colors.Add("black");
            colors.Add("yellow");
            Print(colors);
            Console.ReadLine();
            Console.Clear();
             ElemUp(colors);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine( colors.Count);
            Console.ReadLine();
            Console.Clear();
            colors.Add("white");
            Print(colors);
            Console.ReadLine();
            Console.Clear();
            colors.Insert(0, "gray");
            Print(colors);
            Console.ReadLine();
            Console.Clear();
            colors.RemoveAt(2);
            Print(colors);
            Console.ReadLine();
            Console.Clear();
            colors.Reverse();
            Print(colors);
            Console.ReadLine();
            Console.Clear();

        }
        public static void Print(List<string> list)
        {
            foreach(var color in list)
            {
                Console.WriteLine(color);
            }
        }
        public static void ElemUp(List<string> list)
        {
            for (var color =0;color<list.Count;color++)
            {
                Console.WriteLine(list[color].ToUpper());
            }
        }
    }
}
