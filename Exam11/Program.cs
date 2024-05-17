using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("У вас есть ключ допступа про или эксперт\n1-pro\n2-exp\n3-free redact");
            char choise = char.Parse(Console.ReadLine());
            switch (choise)
            {
                case '1':string key = Console.ReadLine();
                    ProDocumentWorker proDocument = new ProDocumentWorker();
                    while (true)
                    {
                        Console.WriteLine();
                        int choise1 = int.Parse(Console.ReadLine());
                        switch (choise1)
                        {
                            case 1:proDocument.OpenDoc();break;
                            case 2:proDocument.EditDoc();break;
                            case 3:proDocument.SaveDoc();break;
                            case 0:return;
                            default: Console.WriteLine("again"); break;
                        }
                    }
                case '2':
                    string key1 = Console.ReadLine();
                    ExpertDocumentWorker expDocument = new ExpertDocumentWorker();
                    while (true)
                    {
                        Console.WriteLine();
                        int choise1 = int.Parse(Console.ReadLine());
                        switch (choise1)
                        {
                            case 1: expDocument.OpenDoc(); break;
                            case 2: expDocument.EditDoc(); break;
                            case 3: expDocument.SaveDoc(); break;
                            case 0: return;
                            default: Console.WriteLine("again"); break;
                        }
                    }
                case '3':DocumentWorker documentWorker = new DocumentWorker();
                    while (true)
                    {
                        Console.WriteLine();
                        int choise1 = int.Parse(Console.ReadLine());
                        switch (choise1)
                        {
                            case 1: documentWorker.OpenDoc(); break;
                            case 2: documentWorker.EditDoc(); break;
                            case 3: documentWorker.SaveDoc(); break;
                            case 0: return;
                            default: Console.WriteLine("again");break;
                        }
                    }
                default: Console.WriteLine("again"); break;
            }
        }
    }
}
