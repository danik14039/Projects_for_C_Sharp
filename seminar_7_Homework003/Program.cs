// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] matrix = new int [4, 3];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(-5, 5);
        Console.Write(matrix[i,j] + "   ");
    }
    Console.WriteLine();
}

double sum = 0;
double avg = 0;
double [] array = new double [matrix.GetLength(1)];

for (int i = 0; i < matrix.GetLength(1); i++)
{
    sum = 0;
    for(int j = 0; j < matrix.GetLength(0); j++)
    {
        sum=sum+matrix[j,i];
    }
    
    avg = Math.Round((sum/matrix.GetLength(0)),3);
    array[i] = avg;
}
Console.WriteLine(String.Join(";", array));
