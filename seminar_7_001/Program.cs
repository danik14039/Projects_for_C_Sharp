﻿// Задача 46: Задайте двумерный массив размером m×n, заполненный
//  случайными целыми числами.
// m = 3, n = 4.
// 1  4  8  19
// 5  -2 33 -2
// 77 3  8   1

Console.WriteLine("Введите число:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows,columns];

for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      array[i,j]=new Random().Next(0,10);
      Console.Write(array[i,j]+" ");
   }
   Console.WriteLine();
}