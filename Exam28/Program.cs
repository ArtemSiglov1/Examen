using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam28
{
    class Program
    {
        static void Main(string[] args)
        {
            Tour tour = new Tour();
           
            Tour tour1 = new Tour("Gawai");

            Tour tour2 = new Tour("Efiopia", 10);
            tour.TourCalc();

            tour1.TourCalc("Gawaiii");

            tour2.TourCalc("Efiopiaiii", 10);
            Console.ReadLine();
        }
    }
}
