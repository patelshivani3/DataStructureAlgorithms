using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms.Permutation
{
    internal class Iteration
    {
        public static void Permutation_Using_Iteration_Method(string s,string output)
        {
            string leftString, rightStrig, rest;
            if (s.Length == 0)
            {
                Console.Write(output + "  ");
                return;
            }

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                leftString = s.Substring(0, i);
                rightStrig = s.Substring(i + 1);
                rest = leftString + rightStrig;
                Permutation_Using_Iteration_Method(rest, output + ch);

            }
        }
    }
}
