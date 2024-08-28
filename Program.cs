//Array Insertions and Deletions

//Array Declaration
int[] intArray = new int[8];

//size of the array
int length = 0;

///fill the array
for (int i = 0; i < 6; i++)
{
    intArray[length] = i + 1;
    length++;
}

//ARRAY INSERTION AT END
//intArray[length] = 8;
//length++;


//ARRAY INSERTION AT START

//move each elements in an array down 
for (int i = 6; i >= 0; i--)
{
    intArray[i + 1] = intArray[i];
}
intArray[0] = 8;
int value = 0;