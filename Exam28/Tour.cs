using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam28
{
    class Tour
    {
        string name;
        int price;
        int countDays;

        public Tour() { }
        public Tour(string name)
        {
            this.name = name;
        }
        public Tour(string name,int countDays):this(name)
        {
            this.countDays = countDays;
        }

        public void TourCalc()
        {
            name = "Минское море";
            price = 0;
            Console.WriteLine($"{name} {price}");
        }
        public void TourCalc(string name)
        {
            this.name = name;
            price = 50;
            countDays = 1;
            Console.WriteLine($"{this.name} {price} {countDays}");
        }
        public void TourCalc(string name,int countDays)
        {
            this.name = name;
            price = 50*countDays;
           this.countDays =countDays;
            Console.WriteLine($"{this.name} {price} {this.countDays}");
        }
       
    }
}
