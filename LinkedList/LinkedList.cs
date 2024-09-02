using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm.LinkedList
{
    public class LinkedList
    {
        public Node? First { get; set; }
        public void InsertFirst(int data)
        {
            //create new node
            var newNode = new Node();
            //insert the data in the node
            newNode.Data = data;
            //put the old node into the newNode.Next
            newNode.Next = First;
            //make the new node the head
            First = newNode;
        }

        public Node DeleteFirst()
        {
            //create a node variable and assign the first node to it
            Node temp = First;

            //assign the head to the next node
            First = First.Next;

            // return the old head
            return temp;
        }

        public void InsertLast(int data)
        {
            var current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            var newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
            
        }

        public void DisplayList()
        {
            var current = First;
            while (current != null)
            {
                current.DisplayData();
                current = current.Next;
            }
        }
    }
}
