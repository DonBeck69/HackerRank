using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Sorting
{
    public class BubbleSort
    {
        public int countSwaps(ref int[] a)
        {
            bool sorted = false;
            int swapCount = 0;


            while(sorted == false)
            {
                bool sortCheck = true;
                for (int index = 0; index <= a.Length - 2; index++)
                {
                    if (a[index] > a[index + 1])
                    {
                        int val2 = a[index];
                        a[index] = a[index + 1];
                        a[index + 1] = val2;
                        swapCount++;
                        sortCheck = false;
                    }
                }
                sorted = sortCheck;
            }

            Console.WriteLine($"Array is sorted in {swapCount} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[a.Length - 1]}");

            return swapCount;

        }

    }
}
