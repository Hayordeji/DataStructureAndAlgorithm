//Array Insertions and Deletions

//Array Declaration
using DataStructureAndAlgorithm.LinkedList;
using DataStructureAndAlgorithm.Queue;
using DataStructureAndAlgorithm.Stack;
using System.Collections.Generic;

//int[] intArray = new int[8];

////size of the array
//int length = 0;

/////fill the array
//for (int i = 0; i < 8; i++)
//{
//    intArray[length] = i + 1;
//    length++;
//}

//ARRAY INSERTION AT END
//intArray[length] = 8;
//length++;


//ARRAY INSERTION AT START
////move each elements in an array down 
//for (int i = 6; i >= 0; i--)
//{
//    intArray[i + 1] = intArray[i];
//}
//intArray[0] = 8;
////dummy code
//int value = 0;

//LINEAR SEARCH
//bool LinearSearch(int[] intArray, int key)
//{
//    for (int i = 0;i < intArray.Length;i++)
//    {
//        if (intArray[i] == key)
//        {
//            return true;
//        }
//    }
//    return false;
//}

//Console.WriteLine(LinearSearch(intArray, 5));

//LINKED LIST AND ITS IMPLEMENTATION

//LinkedList linkedList = new LinkedList();

//linkedList.InsertFirst(1);
//linkedList.InsertFirst(2);
//linkedList.InsertFirst(3);
//linkedList.InsertFirst(4);
//linkedList.InsertFirst(5);

//linkedList.DeleteFirst();
//linkedList.DeleteFirst();

//linkedList.InsertLast(44);
//linkedList.DisplayList();

//Console.WriteLine("I love you");

////STACK AND ITS IMPLEMENTATION
//Stack stack = new Stack(10);

//for (int i = 0; i < 3; i++)
//{
//    stack.Push("Ayodeji");
//    stack.Push("Anu");
//    stack.Push("Ife");
//}

//stack.Pop();
//stack.Pop();

//stack.Peek();


////QUEUE AND IT'S IMPLEMENTATION

//Queue queue = new Queue(10);

//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);
//queue.Enqueue(4);
//queue.Enqueue(5);
//queue.Enqueue(6);

//queue.Dequeue();
//queue.Dequeue();
//queue.Enqueue(100);

//queue.Peek();




////BINARY SEARCH AND ITS IMPLEMENTATION
//var result = BinarySearch(intArray, 12);
//Console.WriteLine(result);

//int BinarySearch(int[] intArray, int value)
//{
//    int start = 0;
//    int end = intArray.Length - 1;

//    while (start < end)
//    {
//        int midpoint = (start + end) / 2;
//        if (intArray[midpoint] == value)
//        {
//            return intArray[midpoint];
//        }
//        else if (intArray[midpoint] < value) 
//        { 
//            start = midpoint + 1;
//        }
//        else 
//        { 
//            end = midpoint;
//        }
//    }
//    return -1;  
//}

int[] intArray = { 5, 20, 89, 42, 12, 16, 18, 21, 49, 38, 43, 51, 54 };
Console.WriteLine(BubbleSort(intArray));
int[] BubbleSort(int[] intArray)
{
    int temp = 0;
    for (int pointer = 0;  pointer < intArray.Length - 1; pointer++)
    {
        for (int sort = 0; sort < intArray.Length - 1; sort++)
        {
            if (intArray[sort] > intArray[sort + 1])
            {
                temp = intArray[sort + 1];
                intArray[sort + 1] = intArray[sort];
                intArray[sort] = temp;
            }
        }
    }
    return intArray;
}
int joker = 4;