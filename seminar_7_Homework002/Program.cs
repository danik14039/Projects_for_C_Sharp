// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int Input(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int [,] matrix = new int [10, 10];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0, 10);
        // Console.Write(matrix[i,j] + "   "); //ToDo раскомментировать для проверки кода
    }
    // Console.WriteLine(); //ToDo раскомментировать для проверки кода
}

int userRow = Input("Введите позицию строки: ");
int userColumn = Input("Введите позицию столбца: ");
bool check = false;
int userNumber = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if ((i+1==userRow)&&(j+1==userColumn))
        {
            userNumber = matrix[i,j];
            check = true;
        }
       
    }
}

if (check==true)
{
    Console.WriteLine($"Такое значение есть в массиве, оно равно {userNumber}");
}
else 
{
    Console.WriteLine("Такого значения в массиве нет");
}
