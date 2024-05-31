using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Raschet = new List<int>();
           Tovar tovar= Tovar.Init();
            Raschet.Add(Tovar.Raschet(tovar));
            Tovar tovar1 = Tovar.Init();
            Raschet.Add(Tovar.Raschet(tovar1));
            int z = 0;
            foreach(var item in Raschet)
            {
                z+= item;
            }
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
