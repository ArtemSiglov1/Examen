using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgotovka2z
{
    internal class Title
    {
        string titleName;
        public Title(string titleName)
        {
            this.titleName = titleName;
        }

        public void Show()
        {
            Console.WriteLine(titleName);
        }
        public static Title Init()
        {
            Console.WriteLine("Input title name");
            string name = Console.ReadLine();
            return new Title(name);
        }
    }
}
