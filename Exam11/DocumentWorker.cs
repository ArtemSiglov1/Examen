using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam11
{
    class DocumentWorker
    {
        public virtual void OpenDoc()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDoc()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDoc()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}
