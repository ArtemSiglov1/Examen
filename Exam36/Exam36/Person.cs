using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam36
{
    abstract class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

       
        public abstract string SaysHello();

    }
}
