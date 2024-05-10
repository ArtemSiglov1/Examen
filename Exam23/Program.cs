using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine("Каким цветом вывести текст");
            foreach (Pat.Colors colors in Enum.GetValues(typeof(Pat.Colors)))
            {
                Console.WriteLine($"{(int)colors} - {colors}");
            }
            Console.WriteLine("Введите цифру цвета:");
            int color = int.Parse(Console.ReadLine());
            Pat.Print(str,color);
            Console.ReadLine();
        }
    }
}
