using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmsAssignment4
{
    class SCC
    {
        static int[] f = new int[875715];
        static Stack<int> searchStack = new Stack<int>();
        static int size = 0;
        static void Main(string[] args)
        {
            Node[] G = new Node[875715];
            for(int i = 1; i < 875715; i++)
            {
                G[i] = new Node(i);
            }
            string inValue;
            StreamReader inFile = new StreamReader("SCC.txt");
            while ((inValue = inFile.ReadLine()) != null)
            {
                string[] pair = inValue.Split(' ');
                G[int.Parse(pair[0])].Edges.Add(int.Parse(pair[1]));
                G[int.Parse(pair[1])].EdgesReverse.Add(int.Parse(pair[0]));
            }

            Console.WriteLine("Array populated");

            //test for data structure population
            //foreach (int edge in G[5].Edges)
            //{
            //    Console.WriteLine(edge);
            //}

            int fCounter = 1;
            //int size = 0;
            int[] largestSCC = { 0, 0, 0, 0, 0 };

            //first pass to find order
            for (int i = 1; i < G.Length; i++)
            {
                if (!G[i].Explored)
                {
                    searchStack.Push(i);
                    depthFirstTraversal(G[i], G, ref fCounter, true);
                }
            }

            Console.WriteLine("Reverse pass completed");

            //reset explored status
            for (int i = 1; i < G.Length; i++)
            {
                G[i].Explored = false;
            }

            Console.WriteLine("Explored status reset");

            //second pass to count size of each SCC
            for(int i = f.Length - 1; i > 0; i--)
            {
                if (!G[f[i]].Explored)
                {
                    size = 0;
                    searchStack.Push(f[i]);
                    depthFirstTraversal(G[f[i]], G, ref fCounter, false);
                    if (size > largestSCC[0])
                    {
                        largestSCC[0] = size;
                        Array.Sort(largestSCC);
                    }
                }
            }

            //view largest SCC sizes
            foreach(int SCCSize in largestSCC)
            {
                Console.WriteLine(SCCSize);
            }
            Console.ReadKey();

        }

        static void depthFirstTraversal(Node root, Node[] graph, ref int fCounter, bool reverse)
        {
            while (searchStack.Count > 0)
            {
                graph[searchStack.Peek()].Explored = true;
                if (reverse)
                {
                    if (IsEffectiveTerminal(graph[searchStack.Peek()], graph, reverse)) 
                    {
                        f[fCounter] = searchStack.Peek();
                        fCounter++;
                        searchStack.Pop();
                    }
                    else
                    {
                        foreach (int edge in graph[searchStack.Peek()].EdgesReverse)
                        {
                            if (!graph[edge].Explored)
                            {
                                searchStack.Push(edge);
                                graph[edge].Explored = true;
                            }
                        }
                    }                
                }
                else
                {
                    //Console.WriteLine("size: " + size);
                    if (IsEffectiveTerminal(graph[searchStack.Peek()], graph, reverse))
                    {
                        size++;
                        searchStack.Pop();
                    }
                    else
                    {
                        foreach (int edge in graph[searchStack.Peek()].Edges)
                        {
                            if (!graph[edge].Explored)
                            {
                                searchStack.Push(edge);
                                graph[edge].Explored = true;
                            }
                        }
                    }
                }               
            }            
        }

        static bool IsEffectiveTerminal(Node test, Node[] graph, bool reverse)
        {
            if (reverse)
            {
                if (test.EdgesReverse.Count == 0)
                    return true;
                else
                {
                    foreach(int edge in test.EdgesReverse)
                    {
                        if (!graph[edge].Explored)
                            return false;
                    }
                    return true;
                }
            }
            else
            {
                if (test.Edges.Count == 0)
                    return true;
                else
                {
                    foreach (int edge in test.Edges)
                    {
                        if (!graph[edge].Explored)
                            return false;
                    }
                    return true;
                }
            }
            
        }
    }
}
