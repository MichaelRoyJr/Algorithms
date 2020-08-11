using System;
using System.IO;

namespace AlgorithmsAssignment6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int medianSum = 0;
            StreamReader inFile = new StreamReader("Median.txt");
            string inValue;
            int count = 0;
            int medianValue;
            int inInt;
            MinHeap lowerHalf = new MinHeap();              //function as max-heap
            MinHeap upperHalf = new MinHeap();

            while ((inValue = inFile.ReadLine()) != null)
            {
                count++;
                inInt = int.Parse(inValue);

                if (lowerHalf.Size == upperHalf.Size)
                {
                    if (upperHalf.Size != 0 && inInt > upperHalf.GetMin())
                    {
                        upperHalf.Insert(inInt);
                    }
                    else
                    {
                        lowerHalf.Insert(-inInt);
                    }
                }
                else if (lowerHalf.Size > upperHalf.Size)
                {
                    if ((upperHalf.Size == 0 && inInt >= -lowerHalf.GetMin()) || inInt >= -lowerHalf.GetMin())
                    {
                        upperHalf.Insert(inInt);
                    }
                    else
                    {
                        upperHalf.Insert(-lowerHalf.ExtractMin());
                        lowerHalf.Insert(-inInt);
                    }
                }
                else
                {
                    if ((lowerHalf.Size == 0 && inInt <= upperHalf.GetMin()) || inInt <= upperHalf.GetMin())
                    {
                        lowerHalf.Insert(-inInt);
                    }
                    else
                    {
                        lowerHalf.Insert(-upperHalf.ExtractMin());
                        upperHalf.Insert(inInt);
                    }
                }

                if (count % 2 != 0)
                {
                    if (upperHalf.Size > lowerHalf.Size)
                        medianValue = upperHalf.GetMin();
                    else
                        medianValue = -lowerHalf.GetMin();
                }
                else
                    medianValue = -lowerHalf.GetMin();
                medianSum += medianValue;                
            }

            inFile.Close();
            Console.WriteLine("The sum of the medians mod10000 is: " + medianSum % 10000);
        }
    }
}