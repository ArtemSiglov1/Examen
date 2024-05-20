using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam41
{
    class Point<ttype>
    {
        ttype x, y;
        public Point() { }
        public ttype X { get => x; set => x = value; }
        public ttype Y { get => y; set => y = value; }
        public Point(ttype x,ttype y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{x};{y}";
        }
    }
}
