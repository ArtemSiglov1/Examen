using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam4z
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("3300", "Moldova", "Tiraspol", "Krasnodonskaya", 36, 25);
            Console.WriteLine(address.ToString());
            Console.ReadLine();
        }
    }
}
