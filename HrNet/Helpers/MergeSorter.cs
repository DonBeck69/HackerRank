using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Helpers
{
    public class MergeSorter
    {
        //private int[] _unsorted;
        //private int[] _sorted;

        public MergeSorter()
        {
            //_unsorted = unsorted;
            //_sorted = new int[_unsorted.Length];
        }

        //public MergeSorter(int[] unsorted)
        //{
        //    _unsorted = unsorted;
        //    _sorted = new int[_unsorted.Length];
        //}
        public int[] Sort (int[] unsorted)
        {

            //MergeSort(0, unsorted.Length - 1);
            return MergeSortList(unsorted);
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
                        //_count += Left.Length - leftIndex;
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

        /*
        private void MergeSort(int low, int high )
        {
            int highCheck = 2;
            double highLow = Convert.ToDouble(high + low);
            if (highLow % 2 > 0)
            {
                highCheck = 3;
            }
            int mid = Convert.ToInt32(Math.Ceiling(highLow / 2F));
            if (mid - low > 2 && high - mid > highCheck)
            {
                MergeSort(low, mid - 1);
                MergeSort(mid, high);
            }

            Merge(low, mid, high);

        }

        private void Merge(int low, int mid, int high)
        {
            int li = low;
            int ri = mid;
            int si = low;

            while(si <= high)
            {
                if (_unsorted[li] < _unsorted[ri] && li < mid)
                {
                    _sorted[si++] = _unsorted[li++];
                }
                else if (_unsorted[li] > _unsorted[ri] && ri <= high)
                {
                    _sorted[si++] = _unsorted[ri++];
                }
                else if (ri > high && li < mid)
                {
                    _sorted[si++] = _unsorted[li++];
                }
                else if (li == mid && ri <= high)
                {
                    _sorted[si++] = _unsorted[ri++];
                }
            }
        }

        */
    }
}
