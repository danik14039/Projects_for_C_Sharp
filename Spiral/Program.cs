// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = new int[4, 4]; // матрица 4х4
int k = 1; // счетчик заполнения
int i = 0; // строка
int j = 0; // столбцы

// Заполнение матрицы

for (j = 0; j < 4; j++)  // 1 string
{
    matrix[0, j] = k;
    k++;
}

for (i = 1; i < 4; i++) // 4 column
{
    matrix[i, 3] = k;
    k++;
}

for (j = 2; j > 0; j--) // 4 string
{
    matrix[3, j] = k;
    k++;
}

for (i = 3; i > 0; i--) // 1 column
{
    matrix[i, 0] = k;
    k++;
}

for (j = 1; j < 3; j++) // 2 string
{
    matrix[1,j]=k;
    k++;
}

for (j = 2; j > 0; j--) // 3 string
{
    matrix[2,j] = k;
    k++;
}



// Вывод матрицы
for (i = 0; i < matrix.GetLength(0); i++)
{
    for (j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i,j]/10==0)
        {
            Console.Write("0"+matrix[i, j] + " ");
        }
        else
        {
            Console.Write(matrix[i, j] + " ");
        }
    }
    Console.WriteLine();
}