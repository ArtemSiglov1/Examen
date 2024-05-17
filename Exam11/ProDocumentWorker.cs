using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam11
{
    class ProDocumentWorker:DocumentWorker
    {
        
        public override void EditDoc()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDoc()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}
