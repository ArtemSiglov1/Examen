using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam36
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>() { new Russian("Артём"),new Ukraine("Микола"),new American("David")};
            foreach(var item in person)
            {
                Console.WriteLine(item.SaysHello());
            }
            Console.ReadKey();
        }
    }
}
