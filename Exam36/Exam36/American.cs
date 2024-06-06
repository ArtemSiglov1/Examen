using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam36
{
    class American:Person
    {
        public American(string name) : base(name) { }
        public override string SaysHello()
        {
            return $"Hi, {Name}";
        }
    }
}
