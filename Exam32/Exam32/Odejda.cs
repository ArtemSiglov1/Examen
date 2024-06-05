using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam32
{
    internal class Odejda:Tovar
    {
        public string Color {  get; set; }
        public int Count {  get; set; }
        public Odejda() { }
        public Odejda(string name, int price, string color, int count) : base(name,price)
        {
            Color = color;
            Count = count;
        }
        public override int CalcSum()
        { 
            return Count*Price;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Count-{Count} Color-{Color}";
        }
    }
}
