using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm.Stack
{
    public class Stack
    {
        public int MaxSize { get; set; }
        public string[] StackArray { get; set; }
        public int Top { get; set; }

        public Stack(int size)
        {
            this.MaxSize = size;
            this.StackArray = new string[size];
            this.Top = -1;
        }

        public void Push(string text)
        {
            Top++;
            StackArray[Top] = text;
        }

        public string Pop() 
        {
            int old_top = Top;
            Top--;
            return StackArray[old_top];
        }

        public string Peek()
        {
            return StackArray[Top];
        }
    }
}
