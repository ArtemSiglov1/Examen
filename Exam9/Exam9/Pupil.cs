using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9
{
    abstract class Pupil
    {
        public string FirstName { get; set; }
        public Pupil(string firstName)
        {
            FirstName = firstName;
        }
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
        public void Print()
        {
            Console.WriteLine($"Ученик {FirstName}:");
        }
    }
}
