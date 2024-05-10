using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam37
{
    /// <summary>
    /// 1 объявление делегата
    /// </summary>
    /// <param name="a">сторона а</param>
    /// <param name="b">сторона b</param>
    /// <param name="c">сторона с</param>
    /// <returns>площадь</returns>
    public delegate double Message(double a,double b,double c);
    static class CalcS
    {
       public static double Area(double a, double b, double c)
        {
            if (a < b + c && b < a + c && c < a + b)
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else { return 0; }
        }
       
    }
}
