using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    internal class Title
    {
        private string text;

        public Title(string text)
        {
            this.text = text;
        }

        public void Show()
        {
            Console.WriteLine(text);
        }
    }
}
