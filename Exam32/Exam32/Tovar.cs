using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam32
{
    abstract class Tovar
    {
        public string Name { get; set; }
        public int Price {  get; set; }
        public Tovar() { }
        public Tovar(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public abstract int CalcSum();
        public override string ToString()
        {
            return $"Name-{Name} Price-{Price}";
        }
    }
}
