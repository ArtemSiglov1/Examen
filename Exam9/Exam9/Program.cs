using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pupil> pupils = new List<Pupil>() { new ExcelentPupil("Siglov"), new GoodPupil("Sidorov"), new BadPupil("Ivanov"), new GoodPupil("Ushakov") };
            foreach(var pupil in pupils)
            {
                pupil.Print();
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
