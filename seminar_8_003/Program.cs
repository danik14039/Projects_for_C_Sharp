// Задача 59: Задайте двумерный массив из целых чисел.
//  Напишите программу, которая удалит строку и столбец, 
//  на пересечении которых расположен наименьший элемент массива.

Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк:");
int colomns = Convert.ToInt32(Console.ReadLine());

int minValue = int.MaxValue;
int minIndexRows=0;
int minIndexColomns=0;

int [,] array = new int [rows,rows];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,10); 
        Console.Write(array[i,j]+ " ");

        if (minValue>array[i,j])
        {
         minValue=array[i,j];
         minIndexRows=i;
         minIndexColomns=j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
   if (i!=minIndexRows)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        if (j!=minIndexColomns)
        {
         Console.Write(array[i,j]+" ");
        }
      }
   }
    
    Console.WriteLine();
}