using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm.Queue
{
    public class Queue
    {
        public int MaxSize { get; set; }
        public int[] QueueArray { get; set; }
        public int Front { get; set; }
        public int Rear { get; set; }
        public int NItems {  get; set; }

        public Queue(int size) 
        { 
            this.MaxSize = size;
            this.QueueArray = new int[size];
            Front = 0;
            Rear = -1;
            NItems = 0;
        }

        public void Enqueue(int data)
        {
            Rear++;
            QueueArray[Front] = data;
            NItems++;
        }

        public int Dequeue()
        {
            int old_front = Front;
            Front++;
            if (Front == MaxSize)
            {
                Front = 0;
            }
            NItems--;
            return old_front;
        }

        public int Peek() 
        { 
            return QueueArray[Front];
        }
    }
}
