using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam42
{
    class Triangle<ttype>
    {
        ttype a, b, c;

        public ttype A { get => a; set =>  a=value<(dynamic)0?(dynamic)0:value; }
        public ttype B { get => b; set => b = value < (dynamic)0 ? (dynamic)0 : value; }
        public ttype C { get => c; set => c = value < (dynamic)0 ? (dynamic)0 : value; }
        public Triangle() { }
        public Triangle(ttype a, ttype b, ttype c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override string ToString()
        {
            return $"A {a},B {b},C {c}";
        }
        public double Sqare()
        {
            double p=(double)((dynamic)a+ b + c)/2;
            return Math.Sqrt(p * ((dynamic)p - a) * ((dynamic)p - b) * ((dynamic)p - c));
        }
        public string TriangleTrue()
        {
            if (a < (dynamic)b + c && b < (dynamic)a + c && c < (dynamic)a + b)
            {return "Треугольник существует";
            }
            else
            {
                return"Треугольник не существует";
            }
        }
    }
}
