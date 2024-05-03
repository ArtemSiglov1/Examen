using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgot1z
{
    internal class Rectangle
    {
        double side1,side2;

        public double Side1 { get => side1;  }
        public double Side2 { get => side2; }
        public Rectangle() { }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double Area()=>side1*side2;
        public double Perimetr() => (side1 + side2) * 2;
        public static Rectangle Init()
        {
            Console.WriteLine("side 1");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("side 2");
            double side2 = double.Parse(Console.ReadLine());
            return new Rectangle(side1,side2);
        }
    }
}
