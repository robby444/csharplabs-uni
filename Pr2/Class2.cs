using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    public class Class2
    {
        public void Task2()
        {
            Console.WriteLine("Enter side a: ");
            int a = InputToInt();
            Console.WriteLine("Enter side b: ");
            int b = InputToInt();
            Console.WriteLine("Enter side c: ");
            int c = InputToInt();
            if ((a <= 0) || (b <= 0) || (c <= 0))
            {
                Console.WriteLine("Sides should be positive integers!");
            }
            else if ((a + b < c) || (a + c < b) || (b + c < a))
            {
                Console.WriteLine("Triangle doesnt exist!");
            }
            else
            {
                int perimeter = a + b + c;
                double area = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
                GetTriangleType(a, b, c);
            }
        }

        private int InputToInt()
        {
            return Int32.Parse(Console.ReadLine());
        }

        private void GetTriangleType(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Трикутник рівносторонній");
            }
            else if (a != b && b != c && c != a)
            {
                Console.WriteLine("Трикутник різносторонній");
            }
            else
            {
                Console.WriteLine("Трикутник рівнобедренний");
            }
        }
    }
}
