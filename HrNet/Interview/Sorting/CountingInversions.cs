using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Sorting
{
    public class CountingInversions
    {
        protected int[] arr;
        protected int[] result;


        protected long _count = 0; 

        public long countInversions(int[] a)
        {
            _count = 0;
            int[] sorted = MergeSortList(a);
            long res = 0;
            res = _count;
            return res;
        }

        public int[] MergeSortList(int[] unsorted)
        {
            int[] sorted;
            if (unsorted.Length > 1)
            {

                int mid = unsorted.Length / 2;
                int[] left = new int[mid];
                int[] right = new int[unsorted.Length - mid];
                Array.Copy(unsorted, left, mid);
                Array.Copy(unsorted, mid, right, 0, right.Length);
                left = MergeSortList(left);
                right = MergeSortList(right);
                sorted = MergeLists(left, right);
            }
            else
            {
                sorted = unsorted; 
            }
            return sorted;
        }

        public int[] MergeLists(int[] Left, int[] Right)
        {
            int mergeCount = Left.Length + Right.Length;

            int[] merged = new int[mergeCount];
            int leftIndex = 0;
            int rightIndex = 0;
            int mergeIndex = 0;

            while (mergeIndex <= mergeCount - 1)
            {
                if (leftIndex <= Left.Length - 1 && rightIndex <= Right.Length - 1)
                {
                    if (Left[leftIndex] <= Right[rightIndex])
                    {
                        merged[mergeIndex++] = Left[leftIndex++];
                    }
                    else
                    {
                        merged[mergeIndex++] = Right[rightIndex++];
                        _count += Left.Length - leftIndex;
                    }
                }
                else if (leftIndex <= Left.Length - 1)
                {
                    merged[mergeIndex++] = Left[leftIndex++];
                }
                else if (rightIndex <= Right.Length - 1)
                {
                    merged[mergeIndex++] = Right[rightIndex++];
                }
            }

            return merged;
        }


        public int[] MergeLists2(Queue<int> Left, Queue<int> Right)
        {
            int[] merged = new int[Left.Count + Right.Count];
            int index = 0;

            while (Left.Count > 0 || Right.Count > 0)
            {
                if (Left.Count > 0 && Right.Count > 0)
                {
                    if (Left.First() <= Right.First())
                    {
                        merged[index++] = Left.Dequeue();
                    }
                    else
                    {
                        merged[index++] = Right.Dequeue();
                        _count += Left.Count;
                    }
                }
                else if (Left.Count > 0)
                {
                    merged[index++] = Left.Dequeue();
                }
                else if (Right.Count > 0)
                {
                    merged[index++] = Right.Dequeue();
                }

            }

            return merged;
        }


        public void MergeSort(int lo, int hi)
        {
            if (lo < hi)
            {
                //decimal lod = lo;
                //decimal hid = hi;
                //int mid = (int)Math.Ceiling( (lod + hid) / 2);
                int mid = (lo + hi) / 2;
                if (lo < mid)
                {
                    MergeSort(lo, mid);
                }

                if(mid + 1 < hi)
                {
                    MergeSort(mid + 1, hi);
                }

                Merge(lo, mid, mid + 1,  hi);
            }
        }

        public void Merge(int LeftStart, int LeftEnd, int RightStart, int RightEnd)
        {
            int resultIndex = LeftStart;
            int leftIndex = LeftStart;
            int rightIndex = RightStart;
            while(leftIndex <= LeftEnd && rightIndex <= RightEnd)
            {
                
                if (arr[leftIndex] < arr[rightIndex])
                {
                    result[resultIndex++] = arr[LeftStart++];
                }
                else
                {
                    result[resultIndex++] = arr[rightIndex++];
                }
            }

            for (int left = leftIndex; left <= LeftEnd; left++)
            {
                result[resultIndex++] = arr[left];
            }
            for (int right = rightIndex; right <= RightEnd; right++)
            {
                result[resultIndex++] = arr[right];
            }
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
                    _count++;
                }

            }

            int temp = arr[lo];
            arr[lo] = arr[j];
            arr[j] = temp;
            _count++;

            return j; //6, 4, 1, 10, 2, 5, 3, 7, 8
        }

    }

}
