using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9
{
    internal class ExcelentPupil:Pupil
    {
        public ExcelentPupil(string firstName):base(firstName) { }
        public override void Study()
        {
            Console.WriteLine($"{FirstName} учится отлично!") ;
        }
        public override void Read()
        {
            Console.WriteLine($"{FirstName} читает очень быстро!") ;
        }
        public override void Write()
        {
            Console.WriteLine($"{FirstName} пишет без ошибок!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{FirstName} отдыхает, играя в шахматы!");
        }
    }
}
