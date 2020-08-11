using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacuumCleanerWorld
{
    class Environment
    {
        private int height;
        private int width;
        private int size;
        private bool[] board;
        private int position;
        private int score = 0;

        public Environment(int x, int y)
        {
            width = x;
            height = y;
            Size = x * y;
            board = new bool[Size];
        }
        //default constructor assumes 2 spaces
        public Environment()
        {
            width = 2;
            height = 1;
            Size = 2;
            board = new bool[2];
        }

        public void SetDirt(List<int> dirtySquares)
        {
            foreach (int square in dirtySquares)
            {
                board[square] = true;
            }
        }
        public void SetDirt()
        {
            Random generator = new Random();
            int quantity = generator.Next(Size);
            int dirtySpot;
            for (int i=0; i < quantity; i++)
            {
                dirtySpot = generator.Next(Size);
                if (!board[dirtySpot])
                    board[dirtySpot] = true;
                else
                    i--;
            }
        }
        public void SetInitialPosition(int start)
        {
            position = start;
        }
        public void SetInitialPosition()
        {
            Random generator = new Random();
            position = generator.Next(Size);
        }

        //allowed actions
        public void Left()
        {
            if (position % width != 0)
                position--;
        }
        public void Right()
        {
            if (position % width != width - 1)
                position++;
        }
        public void Suck()
        {
            board[position] = false;
        }

        //sensors
        public bool IsDirty()
        {
            return board[position];
        }

        public void Run()
        {
            for (int i=0; i < 1000; i++)
            {
                this.ReflexAgent();
                foreach (bool square in board)
                    if (!square)
                        score++;
            }
        }
        private void ReflexAgent()
            //assumes default two-space environment
        {
            if (board[position])
                this.Suck();
            else if (position == 0)
                this.Right();
            else
                this.Left();
        }
        
        //properties
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public bool[] Board { get => board; set => board = value; }
        public int Position { get => position; set => position = value; }
        public int Score { get => score; set => score = value; }
        public int Size { get => size; set => size = value; }
    }
}
