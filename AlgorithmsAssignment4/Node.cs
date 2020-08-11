using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAssignment4
{
    class Node
    {
        private int number;
        private bool explored;
        private int f;
        private List<int> edges;
        private List<int> edgesReverse;
        
        public Node()
        {
            explored = false;
            f = -1;
            edges = new List<int>();
            edgesReverse = new List<int>();
        }
        public Node(int number)
        {
            this.number = number;
            explored = false;
            f = -1;
            edges = new List<int>();
            edgesReverse = new List<int>();
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public bool Explored
        {
            get
            {
                return explored;
            }
            set
            {
                explored = value;
            }
        }

       public int F
       {
            get
            {
                return f;
            }
            set
            {
                f = value;
            }
       }

        public List<int> Edges
        {
            get
            {
                return edges;
            }
            set
            {
                edges = value;
            }
        }

        public List<int> EdgesReverse
        {
            get
            {
                return edgesReverse;
            }
            set
            {
                edgesReverse = value;
            }
        }
    }
}
