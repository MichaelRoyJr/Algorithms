﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuickSortComparisonCounter
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            string inValue;
            int i = 0;
            int[] testArray = new int[10000];
            int total = 0;

            //populate array from file
            try
            {
                StreamReader inputFile = new StreamReader("QuickSort.txt");
                while ((inValue = inputFile.ReadLine()) != null)
                {
                    testArray[i] = int.Parse(inValue);
                    i++;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("i = " + i);
            //total = ChoosePivot(0, i, ref testArray);
            Sort(0, i, ref testArray, ref total);


            Console.WriteLine("Total comparisons = " + total);


        }

        static void Sort(int left, int right, ref int[] testArray, ref int total)
        {

            if (right - left > 1)
            {
                total += (right - left - 1);

                int pivot = ChoosePivot(left, right, ref testArray);
                //Console.WriteLine("Pivot is " + pivot);

                int i = left + 1;
                int temp;

                //pivot using median element
                temp = testArray[left];
                testArray[left] = testArray[pivot];
                testArray[pivot] = temp;
                pivot = left;



                for (int j = left + 1; j < right; j++)
                {
                    if (testArray[j] < testArray[pivot])
                    {
                        temp = testArray[i];
                        testArray[i] = testArray[j];
                        testArray[j] = temp;
                        i++;
                    }
                }
                temp = testArray[left];
                testArray[left] = testArray[i - 1];
                testArray[i - 1] = temp;

                Sort(left, i - 1, ref testArray, ref total);
                Sort(i, right, ref testArray, ref total);
            }


        }
        static int ChoosePivot(int left, int right, ref int[] testArray)
        {
            /*pivot point chosen to be the median of the first, last, and 
             * middle elements of the segment of the array currently being
             * sorted.  This increases the odds of selecting a pivot in 
             * the 25 - 75 percentile range that will keep the algorithm's
             * average runtime at O(n log n).  */
            int middle;
            if ((right - left) % 2 == 0)
            {
                middle = (right + left) / 2 - 1;
            }
            else
            {
                middle = (right + left - 1) / 2;
            }

            if (testArray[left] < testArray[middle])
            {
                if (testArray[middle] < testArray[right - 1])
                    return middle;
                else
                {
                    if (testArray[left] < testArray[right - 1])
                        return right - 1;
                    else
                        return left;
                }
            }
            else
            {
                if (testArray[left] < testArray[right - 1])
                    return left;
                else
                {
                    if (testArray[middle] < testArray[right - 1])
                        return right - 1;
                    else
                        return middle;
                }
            }
        }
    }
}
