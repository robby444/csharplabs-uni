using System;

namespace Pr2.CodeFile1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Task 1===");
            Class1 c1 = new Class1();
            c1.Task1();
            Console.WriteLine();

            Console.WriteLine("===Task 2===");
            Class2 c2 = new Class2();
            c2.Task2();
            Console.WriteLine();

            Console.WriteLine("===Task 3===");
            Class3 c3 = new Class3();
            c3.Task3();
            Console.WriteLine();

            Console.WriteLine("===Task 4===");
            Class4 c4 = new Class4();
            c4.Task4();
            Console.WriteLine();
        }
    }
}