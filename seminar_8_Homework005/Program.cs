// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



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


int row = Input("Введите размерность массива");
int col = row;
int[,] table = new int[row, col];
int N = table.GetLength(0);
int M = table.GetLength(1);
int k = 1;
int num = 0;
while (k <= N * M)
{
    for (int m = 0; m < N; m++)
    {
        int i = 0;
        if (i == N - (N - m))
        {
            for (int j = 0; j < M; j++)
            {
                table[i, j] = k++;
                num = table[i, j];
                int count = 0;
                while (num > 0)
                {
                    num = num / 10;
                    count++;
                }
                if (count == 1)
                {
                    Console.Write($"0{table[i, j]} ");
                }
                else
                {
                    Console.Write($"{table[i, j]} ");
                }
            }
            Console.WriteLine();
        }

    }
}