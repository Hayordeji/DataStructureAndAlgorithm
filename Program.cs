//Array Insertions and Deletions

//Array Declaration
using DataStructureAndAlgorithm.LinkedList;
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

LinkedList linkedList = new LinkedList();

linkedList.InsertFirst(1);
linkedList.InsertFirst(2);
linkedList.InsertFirst(3);
linkedList.InsertFirst(4);
linkedList.InsertFirst(5);

linkedList.DeleteFirst();
linkedList.DeleteFirst();

linkedList.InsertLast(44);
linkedList.DisplayList();

Console.WriteLine("I love you");
