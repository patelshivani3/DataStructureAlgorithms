using DataStructureAlgorithms.Permutation;
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
            string output = "";
            Console.WriteLine("\nEnter the String for Permutation : ");
            string s = Console.ReadLine();
            Console.WriteLine("\nPossible Strings Using Iteration Method : ");
            Iteration.Permutation_Using_Iteration_Method(s, output);
            Console.WriteLine("\nPossible Strings Using Recursion Method :");
            int n = s.Length;
            Recursion.Permutation_Using_Recursion_Method(s, 0, n - 1);
            Console.ReadLine();
        }
    }
}
