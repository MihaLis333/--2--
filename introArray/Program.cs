﻿/* int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result)result = arg2;
    if(arg3 > result)result = arg3;
    return result;
}

int[] array = {11, 21, 31, 41, 551, 16, 71, 81, 91};

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(max); */

/* int[] array = {1, 2, 8, 3, 4, 5, 6, 7, 8};

int n = array.Length;
int find = 8;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
} */

/* В случае если в массиве есть два одинаковых элемента,
 а нам нужно показать только первый то используем команду - brake. */


 void FillArray(int[] collection)

 {
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index]= new Random().Next(1, 10);
        index++;
    }
 }

 void PrintArray(int[] col)
 {
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
 } 
int InexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 ставим если в массиве нет такого элемента то он будет выводить позицию -1.
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // этот оператор останавливает цикл после первого нахождения элемента, есл в массиве несколько одинаковых элементов.
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
array[0] = 4;
array[3] = 4; // таким образом мы добавляем принудительно нуждые нам элементы в позиции.
PrintArray(array);
Console.WriteLine();

int pos = InexOf(array, 444);
Console.WriteLine(pos); 