using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AlgorithmsAssignment5
{
    class ShortestPath
    {
        static void Main(string[] args)
        {
            List<int>[] A = new List<int>[201];
            Populate(A);

            int[] explored = new int[201];
            AddNode(explored, A);

            for (int i = 1; i < 201; i++)
            {
                Console.WriteLine("node " + i + " = " + explored[i] + " ");
            }
                  
        }
        static void AddNode (int[] explored, List<int>[] A)
        {
            int greedyNode = 0;
            int greedyValue = 1000000;
            int root = 0;

            for (int count = 0; count < 200; count++)
            {

                for (int i = 1; i < 201; i++)
                {
                    if ((i == 1) || (explored[i] != 0))
                    {
                        for (int j = 1; j < A[i].Count; j += 2)
                        {
                            if (A[i][j + 1] + explored[i] < greedyValue && (explored[A[i][j]] == 0) && (A[i][j] != 1))
                            {
                                greedyValue = A[i][j + 1] + explored[i];
                                greedyNode = A[i][j];
                                root = i;
                            }
                        }
                    }
                    
                }
                //Console.WriteLine("node " + greedyNode + " = " + greedyValue);

                explored[greedyNode] = greedyValue;
                greedyValue = 1000000;
                
            }
        }         

        static void Populate(List<int>[] A)
        {
            string inValue;
            StreamReader inFile;
            try
            {
                inFile = new StreamReader("dijkstraData.txt");
                for (int i = 1; i < 201; i++)
                {
                    A[i] = new List<int>();
                    inValue = inFile.ReadLine();
                    string[] temp = inValue.Split(new char[] { ' ', ',', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string s in temp)
                    {
                        A[i].Add(int.Parse(s));                        
                    }
                }
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
