using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    public class Class4
    {
        public void Task4()
        {
            int[] arr = new int[38];

            FillArray(arr);

            Console.WriteLine("Enter number M: ");
            int m = Int32.Parse(Console.ReadLine());

            int[] y = FilterArray(arr, m);

            Console.WriteLine("\nInitial array: ");
            PrintArray(arr);

            Console.WriteLine("\n\nOutput array: ");
            PrintArray(y);
        }

        private void FillArray(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
            }
        }

        private void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write($"{i},");
            }
        }

        private int[] FilterArray(int[] arr, int m)
        {
            int counter = 0;
            foreach (int i in arr)
            {
                if (Math.Abs(i) > m)
                {
                    counter++;
                }
            }
            int[] y = new int[counter];

            counter = 0;
            foreach (int i in arr)
            {
                if (Math.Abs(i) > m)
                {
                    y[counter] = i;
                    counter++;
                }
            }

            return y;
        }
    }
}
