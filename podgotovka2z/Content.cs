using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgotovka2z
{
    internal class Content
    {
        string nameContent;
        public Content(string nameContent)
        {
            this.nameContent = nameContent;
        }

        public void Show()
        {
            Console.WriteLine(nameContent);
        }
        public static Content Init()
        {
            Console.WriteLine("Input content name");
            string name = Console.ReadLine();
            return new Content(name);
        }
    }
}
