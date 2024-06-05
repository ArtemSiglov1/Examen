using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tovar> tovars = new List<Tovar>() { new Obuv("Krosses",1200,2,43), new Odejda("Maika",300,"Black-White",10), new Posuda("Tarelki",200,1,2) };
            foreach(var item in tovars)
            {
                Console.WriteLine($"{item.ToString()}\n{item.CalcSum()}");
            }
            Console.ReadLine();
        }
    }
}
