using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(0.311, 0.285, 28.29);
            Converter converter1 = new Converter(2.627, 3.487, 0.035);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1-Из BYN\n2-В BYN\n0-Exit");
                int choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.WriteLine($"Текущий курс-{converter.ToString()}");
                        while (true)
                        {
                            double count = 0 ;
                            Console.WriteLine("1-Usd,2-Eur,3-Rub,0-Exit");
                            int choise1 = int.Parse(Console.ReadLine());
                            if (choise1 != 0)
                            {
                                Console.WriteLine("Введите сумму в BYN:");
                                 count= double.Parse(Console.ReadLine());
                            }
                            switch (choise1)
                            {
                                case 1:
                                    Console.WriteLine($"Сумма в долларах:{count * converter.Usd}"); break;
                                case 2:
                                    Console.WriteLine($"Сумма в долларах:{count * converter.Eur}"); break;
                                case 3:
                                    Console.WriteLine($"Сумма в долларах:{count * converter.Rub}"); break;
                                case 0: return;
                                default:
                                    Console.WriteLine("again"); break;
                            }
                        }
                    case 2:
                        Console.WriteLine($"Текущий курс-{converter1.ToString()}");
                        while (true)
                        {
                            double count = 0;
                            Console.WriteLine("1-Usd,2-Eur,3-Rub,0-Exit");
                            int choise1 = int.Parse(Console.ReadLine());
                            if (choise1 != 0)
                            {
                                Console.WriteLine("Введите сумму в BYN:");
                                count = double.Parse(Console.ReadLine());
                            }
                            switch (choise1)
                            {
                                case 1:
                                    Console.WriteLine($"Сумма в долларах:{count * converter1.Usd}"); break;
                                case 2:
                                    Console.WriteLine($"Сумма в долларах:{count * converter1.Eur}"); break;
                                case 3:
                                    Console.WriteLine($"Сумма в долларах:{count * converter1.Rub}"); break;
                                case 0: return;
                                default:
                                    Console.WriteLine("again"); break;
                            }
                        }
                       
                    case 0:flag = false;break;
                    default:
                        Console.WriteLine("Again");break;
                }
            }
        }

    }
}
