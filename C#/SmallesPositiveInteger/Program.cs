using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallesPositiveInteger
{
    class Program
    {
        static int findSmallestMissingNumber(int[] numberArray)
        {
            HashSet<int> objSortedNumber = new HashSet<int>();
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] > 0) objSortedNumber.Add(numberArray[i]);
            }

            int missingNumber = 1;
            while (objSortedNumber.Contains(missingNumber)) missingNumber++;
            return missingNumber;
        }
        static void Main(string[] args)
        {
            int[] numberArray = { 1, 3, 6, 4, 1, 2 };
            Console.WriteLine("Smallest Positive Integer : {0}", findSmallestMissingNumber(numberArray));
            Console.ReadKey();
        }
    }
}
