using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n1.Permutation\n2.Binary Sort\n3.Insertion Sort\n4.Bubble Sort\n5.Prime Number Betwween 1 to 1000");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                     Console.WriteLine("\nEnter the String for Permutation : ");
                    string s = Console.ReadLine();
                    Console.WriteLine("\nPossible Strings Are : ");
                    int n = s.Length;
                    Permutation.PermutationOfString(s, 0, n - 1);
                    break;

                case 2:
                    BinarySort.BinarySearch();
                    break;

                case 3:
                    InsertionSort.Insertion();
                    break;
                    
                case 4:
                    BubbleSort.BubbleSortMethod();
                    break;

                case 5:
                    PrimeNumber.Number();
                    break;

                default:
                    Console.WriteLine("\nChoose From Given Options Only...");
                    break;
            }
            
            

            Console.ReadLine();
        }
    }
}
