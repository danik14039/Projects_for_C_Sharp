// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

void FillMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] table = new int [3,4];
FillMatrix(table);
PrintMatrix(table);
Console.WriteLine();
int sum = 0;
int min = int.MaxValue;
int minValueIndex=0;

for (int i = 0; i < table.GetLength(0); i++)
{
    sum=0;
    for (int j = 0; j < table.GetLength(1); j++)
    {
        sum+=table[i,j];
    }
    if (sum<min)
    {
        min=sum;
        minValueIndex=i;
    }
}
Console.WriteLine();
Console.WriteLine($"Строка с минимальной суммой элементов №{minValueIndex+1}. Сумма элементов строки равна {min}");