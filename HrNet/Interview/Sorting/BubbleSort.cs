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

        public void StartSort(ref int[] a)
        {
            arr = a;
            QuickSort(0, a.Length);

        }

        public void QuickSort(int lo, int hi)
        {
            if (lo < hi)
            {
                int j = Partition(lo, hi);
                QuickSort(lo, j);
                QuickSort(j + 1, hi);
            }

        }

        protected int[] arr;


        public int Partition(int lo, int hi)
        {
            int pivot = arr[lo];
            int i = lo;
            int j = hi;
            while (i < j)
            {
                do
                {
                    i++;
                } while (i < hi && arr[i] <= pivot);

                do
                {
                    j--;
                } while (j >= lo && arr[j] > pivot);

                if (i < j)
                {
                    int inttemp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = inttemp;
                }

            }

            int temp = arr[lo];
            arr[lo] = arr[j];
            arr[j] = temp;


            return j; //6, 4, 1, 10, 2, 5, 3, 7, 8
        }


    }
}
