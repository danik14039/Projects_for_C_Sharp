// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Input(string message)
{
    string value = String.Empty;
    bool isNumber = false;
    int number = 0;
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        value = Console.ReadLine();
        isNumber = int.TryParse(value, out number);
        if (isNumber == true)
        {
            result = number;
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число, введите число");
        }
    }
    return result;
}

int firstMatrixRow = Input("Введите количество строк первой матрицы");
int firstMatrixColumn = Input("Введите количество столбцов первой матрицы");
int secondMatrixRow = Input("Введите количество строк второй матрицы");
int secondMatrixColumn = Input("Введите количество столбцов второй матрицы");

int[,] firstMatrix = new int[firstMatrixRow, firstMatrixColumn];
int[,] secondMatrix = new int[secondMatrixRow, secondMatrixColumn];

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 4);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Первая матрица: ");
FillMatrix(firstMatrix);
PrintMatrix(firstMatrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
FillMatrix(secondMatrix);
PrintMatrix(secondMatrix);

Console.WriteLine();

if (firstMatrixColumn == secondMatrixRow)
{
    Console.WriteLine("Матрицы согласованы");
    Console.WriteLine("Произведение двух матриц равно: ");
    int sum = 0;
    int[,] multipliedMatrix = new int[firstMatrixRow, secondMatrixColumn];
    for (int i = 0; i < multipliedMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multipliedMatrix.GetLength(0); j++)
        {
            sum = 0;
            for (int k = 0; k < multipliedMatrix.GetLength(1); k++)
            {
                sum = sum + firstMatrix[i, k] * secondMatrix[k, j];
            }
            multipliedMatrix[i,j] = sum;
            Console.Write(multipliedMatrix[i, j] + " ");
        }

        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Матрицы не согласованы, для согласования матриц количество столбцов первой матрицы должны быть равны количество строк второй матрицы");
}

