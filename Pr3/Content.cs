using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    internal class Content
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { this.text = value; }
        }

        public Content(string text)
        {
            this.text = text;
        }

        public void Show()
        {
            Console.WriteLine(text);
        }
    }
}
