using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }

        public Title Title { get { return this.title; } }

        public Author Author { get { return this.author; } }

        public Content Content { get { return this.content; } }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            title.Show();
            Console.ForegroundColor = ConsoleColor.Yellow;
            author.Show();
            Console.ForegroundColor = ConsoleColor.Gray;
            content.Show();
        }
    }
}
