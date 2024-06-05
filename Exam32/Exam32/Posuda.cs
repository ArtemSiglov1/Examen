using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exam32
{
    internal class Posuda : Tovar
    {
        public int Massa {  get; set; }
        public int Count { get; set; }
        public Posuda() { }
        public Posuda(string name, int price,int massa, int count):base(name,price)
        {
            Massa = massa;
            Count = count;
        }
        public override int CalcSum()
        {
            return Count*Price;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Count-{Count} Massa-{Massa} кг";
        }
    }
}
