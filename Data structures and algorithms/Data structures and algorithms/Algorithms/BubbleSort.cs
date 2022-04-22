using System;
using System.Collections.Generic;
using System.Text;

namespace Data_structures_and_algorithms.Algorithms
{
    internal class BubbleSort
    {
        static int[] arr3 = { 17, 3, 18, 5, 9, 16 };
        

        public static void Do()
        {
            int n = arr3.Length;
            for (int i = 0; i < n -1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr3[j] > arr3[j + 1])
                    {
                        int temp = arr3[j];
                        arr3[j] = arr3[j + 1];
                        arr3[j + 1] = temp;
                    }
                }
            }

            foreach (int num in arr3)
            {
                Console.WriteLine(num + " ");
            }
        }
    }
}
