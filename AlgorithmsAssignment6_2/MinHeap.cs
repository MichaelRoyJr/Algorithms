namespace AlgorithmsAssignment6_2
{
    class MinHeap
    {
        private int[] heap;
        private int size;
        
        public MinHeap()
        {
            heap = new int[5000];
            size = 0;
        }

        public void Insert(int item) 
        {
            heap[size] = item;
            BubbleUp(size);
            size++;
        }

        public int ExtractMin()
        {
            int min = heap[0];
            size--;
            heap[0] = heap[size];
            BubbleDown(0);
            return min;
        }

        public int GetMin()
        {
            return heap[0];
        }

        private void BubbleUp(int item)
        {
            if (heap[item] < heap[(item-1)/2] && item > 0)
            {
                int temp = heap[item];
                heap[item] = heap[(item - 1) / 2];
                heap[(item - 1) / 2] = temp;
                BubbleUp((item - 1) / 2);
            }
        }
        private void BubbleDown(int item)
        {
            if (2*item+1 < size && heap[item] > heap[2 * item + 1])                    //left child exists and is less
            {
                if (2 *item+2 < size && heap[item] > heap[2 * item + 2])                //right child exists and is less
                {
                    if (heap[2 * item + 1] > heap[2 * item + 2])                           //bubble on lesser value
                    {
                        int temp = heap[item];
                        heap[item] = heap[2 * item + 2];
                        heap[2 * item + 2] = temp;
                        BubbleDown(2 * item + 2);
                    }
                    else
                    {
                        int temp = heap[item];
                        heap[item] = heap[2 * item + 1];
                        heap[2 * item + 1] = temp;
                        BubbleDown(2 * item + 1);
                    }
                }
                else                                                                    //only left child
                {
                    int temp = heap[item];
                        heap[item] = heap[2 * item + 1];
                        heap[2 * item + 1] = temp;
                        BubbleDown(2 * item + 1);
                }
            }
            else if (2 * item + 2 < size && heap[item] > heap[2 * item + 2])
            {
                int temp = heap[item];
                heap[item] = heap[2 * item + 2];
                heap[2 * item + 2] = temp;
                BubbleDown(2 * item + 2);
            }           
        }

        public int Size
        {
            get
            {
                return size;
            }
        }

        public override string ToString()
        {
            string heapString = "";
            for (int i = 0; i < size; i++)
            {
                heapString += heap[i] + " ";
            }
            return heapString;
        }
    }
}