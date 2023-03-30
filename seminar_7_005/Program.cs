// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Введите число:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int columns = Convert.ToInt32(Console.ReadLine());

int sum=0;
int arrayLength=0;
int [,] array = new int [rows,columns];

if(rows>=columns)
{
   arrayLength=columns;
}
else
{
    arrayLength=rows;
}

int [] array2 = new int [arrayLength];

for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      array[i,j]=new Random().Next(0,10);

      if (i==j)
      {
         sum+=array[i,j];
         array2[j]=array[i,j];
      }
      Console.Write(array[i,j]+" ");
   }
   Console.WriteLine();
}
Console.WriteLine("Сумма элементов  главной диагонали равна:");

for (int i = 0; i < array2.Length; i++)
{
   Console.Write(array2[i]+"+");
}
Console.WriteLine("="+sum);