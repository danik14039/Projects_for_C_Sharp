// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Input(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int rows = Input("Введите количество строк: ");
int columns = Input("Введите количество столбцов: ");
int minValue = Input("Введите минимальное значение двумерного массива: ");
int maxValue = Input("Введите максимальное значение двумерного массива: ");

double [,] matrix = new double [rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(minValue, maxValue) + Math.Round((new Random().NextDouble()),1);
        Console.Write(matrix[i,j] + "   ");
    }
    Console.WriteLine();
}