using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam43
{
    class Segment<ttype>
    {
        ttype x1, x2, y1, y2;

        public ttype X1 { get => x1; set => x1 = value; }
        public ttype X2 { get => x2; set => x2 = value; }
        public ttype Y1 { get => y1; set => y1 = value; }
        public ttype Y2 { get => y2; set => y2 = value; }
        public Segment() { }
        public Segment(ttype x1, ttype y1,ttype x2,ttype y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public override string ToString()
        {
            return $"A({x1};{y1}),B({x2};{y2})";
        }
        public double LenghtSegment()
        {
            return Math.Sqrt(Math.Pow((dynamic)x2 - x1, 2) + Math.Pow((dynamic)y2 - y1, 2));
        }
    }
}
