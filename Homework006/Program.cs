﻿//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index<length)
    {
        array[index] = new Random().Next(1,100);
        index+=1;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int pos = 0;
    while (pos<count)
    {
        Console.WriteLine(collection[pos]);
        pos+=1;
    }
}

int[] array = new int[3];
FillArray(array);
PrintArray(array);

int max = 0;
int i = 0;
int list = array.Length;
while(i<list)
{
    if (array[i]>max)
    {
        max=array[i];
    }
    i+=1;
}
Console.WriteLine("Максимальное число:" + max);

