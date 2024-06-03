using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9
{
    internal class GoodPupil:Pupil
    {
        public GoodPupil(string firstName) : base(firstName) { }
        public override void Study()
        {
            Console.WriteLine($"{FirstName} учится хорошо!");
        }
        public override void Read()
        {
            Console.WriteLine($"{FirstName} читает достаточно быстро!");
        }
        public override void Write()
        {
            Console.WriteLine($"{FirstName} пишет с небольшими ошибками!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{FirstName} отдыхает, смотря телевизор!");
        }

    }
}
