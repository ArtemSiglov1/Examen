using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
    internal class Converter
    {
        double usd, eur, rub;
        public Converter(double usd,double eur,double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
      
        public double Usd { get => usd; set => usd = value; }
        public double Eur { get => eur; set => eur = value; }
        public double Rub { get => rub; set => rub = value; }
        public override string ToString()
        {
            return $"Usd-{usd}\nEur-{eur}\nRub-{rub}";
        }


    }
}
