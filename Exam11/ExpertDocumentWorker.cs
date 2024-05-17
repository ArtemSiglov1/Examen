using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam11
{
    class ExpertDocumentWorker:ProDocumentWorker
    {
        
        public override void SaveDoc()
        {
            Console.WriteLine("Документ сохранен в новом формате"); ;
        }
    }
}
