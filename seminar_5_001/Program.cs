// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int [] array = new int [12];

int posSum = 0;
int negSum = 0;

for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    if (array[i]>0)
    {
        posSum = posSum + array[i];
    }
    else if(array[i]<0)
    {
        negSum = negSum + array[i];
    }
}
Console.Write(String.Join(",", array));
Console.WriteLine();
Console.WriteLine($"Сумма положительных {posSum}");
Console.WriteLine($"Сумма отрицательных {negSum}");
