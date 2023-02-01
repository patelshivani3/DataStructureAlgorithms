using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms
{
    internal class BubbleSort
    {
        public static void BubbleSortMethod()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            Console.WriteLine("\nGiven Array is :");
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Array is :");
            foreach (int p in arr)
            { 
                Console.Write(p + " ");
            }   
        }
    }
}
