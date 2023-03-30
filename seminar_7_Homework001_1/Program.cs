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

int rows = Input("Введите количество строк: ");
int columns = Input("Введите количество столбцов: ");
// int minValue = Input("Введите минимальное значение двумерного массива: ");
// int maxValue = Input("Введите максимальное значение двумерного массива: ");



int [,] matrix = new int [rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0, 10);
        // Console.Write(matrix[i,j] + "   ");
    }
    // Console.WriteLine();
}

int userNumber = Input("Введите свое число: ");
bool checkNumber = false;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i,j]==userNumber) {checkNumber=true;}
    }
}

if (checkNumber==true) {Console.WriteLine("Ваше число есть в массиве");}
else if (checkNumber==false) {Console.WriteLine("Вашего числа нет в массиве");}