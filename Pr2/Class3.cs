using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    public class Class3
    {
        public void Task3()
        {
            int[] arr = new int[10];
            FillArray(arr);
            PrintArray(arr);
            int min = FindMinMax(arr)[0];
            int max = FindMinMax(arr)[1];
            Console.WriteLine($"\nmin: {min}");
            Console.WriteLine($"max: {max}");
        }

        private void FillArray(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
            }
        }

        private void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write($"{i},");
            }
        }

        private int[] FindMinMax(int[] arr)
        {
            int min = 100;
            int max = 0;
            foreach (int i in arr)
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
            }
            int[] result = new int[] {min, max};
            return result;
        }
    }
}
