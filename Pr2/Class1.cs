using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    public class Class1
    {
        public void Task1()
        {
            Console.WriteLine("Enter integer a: ");
            int a = InputToInt();
            Console.WriteLine("Enter integer b: ");
            int b = InputToInt();
            Console.WriteLine("Enter integer c: ");
            int c = InputToInt();
            PrintIfInRange(a);
            PrintIfInRange(b);
            PrintIfInRange(c);
        }

        private int InputToInt()
        {
            return Int32.Parse(Console.ReadLine());
        }

        private void PrintIfInRange(int number)
        {
            if (number >= 0 && number <= 38)
            {
                Console.WriteLine($"{number} is in [0;38]");
            }
        }
    }
}
