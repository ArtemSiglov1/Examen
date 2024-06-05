using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam32
{
    internal class Obuv:Tovar
    {
        public int Count {  get; set; }
        public double Size {  get; set; }
        public Obuv() { }
        public Obuv(string name,int price,int count, double size):base(name,price)
        {
            Count = count;
            Size = size;
        }
        public override int CalcSum()
        {
            return Price*Count;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Count-{Count} Size-{Size}";
        }
    }
}
