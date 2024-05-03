using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgotovka2z
{
    internal class Book
    {
        Title title;
        Author author;
        Content content;
       public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }
        public void Show()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            title.Show();
            Console.ForegroundColor = ConsoleColor.White;
            author.Show();
            Console.ForegroundColor = ConsoleColor.Red;
            content.Show();
        }
    }
}
