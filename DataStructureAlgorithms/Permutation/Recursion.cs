using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithms.Permutation
{
    internal class Recursion
    {
        public static void Permutation_Using_Recursion_Method(String str, int startIndex, int endIndex)
        {
            if (startIndex == endIndex)
                Console.Write(str + "  ");
            else
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    str = Swap(str, startIndex, i);
                    Permutation_Using_Recursion_Method(str, startIndex + 1, endIndex);
                    str = Swap(str, startIndex, i);
                }
            }
        }
        public static string Swap(String a,int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
