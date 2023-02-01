using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms
{
    internal class BinarySort
    {
        public static void BinarySearch()
        {

            int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            Console.WriteLine("\nNumbers in array is :");

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nChoose the Number from array:");
            int num = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            int last = array.Length - 1;

            while (first <= last)
            {
                int mid = (first + last) / 2;
                if (num == array[mid])
                {
                    Console.WriteLine("Index Position is : " + mid);
                    break;
                }
                else if (num < array[mid])
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
            }
        }
    }
}