using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9
{
    internal class BadPupil:Pupil
    {
        public BadPupil(string firstName) : base(firstName) { }
        public override void Study()
        {
            Console.WriteLine($"{FirstName} учится плохо!");
        }
        public override void Read()
        {
            Console.WriteLine($"{FirstName} читает очень медленно!");
        }
        public override void Write()
        {
            Console.WriteLine($"{FirstName} пишет с большим количеством ошибок!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{FirstName} отдыхает, играя в компьютерные игры!");
        }

    }
}
