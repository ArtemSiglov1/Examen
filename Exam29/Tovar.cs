using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam29
{
    class Tovar
    {
        string name;
        int price;
        int count;

        public Tovar(string name, int price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public string Name { get; set; }
        public int Price { get => price; set => price = value <= 1 && value >= 20 ? 0 : value; }
        public int Count { get => count; set => count = value <= 0 && value >= 10 ? 0 : value; }
        public static int Raschet(Tovar tovar)
        {
            return tovar.price * tovar.count;
        }
        
        public static Tovar Init()
        {
            string name=Console.ReadLine();
            int price=int.Parse(Console.ReadLine());
            int count=int.Parse(Console.ReadLine());
            return new Tovar(name, price, count);
        }
    }
}
