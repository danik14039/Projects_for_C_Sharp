// Задача 53: Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int colums = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows,colums];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,10); 
        Console.Write(array[i,j]+ " ");
    }
    Console.WriteLine();
}

int maxIndex = array.GetLength(0)-1;

for (int j = 0; j < array.GetLength(1); j++)
{
   int temp=array[0,j];
   array[0,j]=array[maxIndex,j];
   array[maxIndex,j]=temp;
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        
        Console.Write(array[i,j]+ " ");
    }
    Console.WriteLine();
}

