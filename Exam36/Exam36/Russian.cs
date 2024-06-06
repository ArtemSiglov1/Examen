using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam36
{
    class Russian:Person
    {
        public Russian(string name):base(name) { }
        public override string SaysHello()
        {
            return $"Привет, {Name}";
        }
    }
}
