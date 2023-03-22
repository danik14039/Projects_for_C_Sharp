// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int NumberInput(string msg)
{
    Console.WriteLine(msg);
    int ReadInput = int.Parse(Console.ReadLine());
    int result = ReadInput;
    return result;
}

int length = NumberInput("Введите длину массива: ");
int minValue = NumberInput("Введите минимальное значение массива: ");
int maxValue = NumberInput("Введите максимальное значение массива: ");
int [] array = new int [length];

for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(minValue, maxValue);
}

int max = array[0];
int min = array[0];

for (int j=0; j<array.Length; j++)
{
    if(array[j]>max)
    {
        max=array[j];
    }
    
    if(array[j]<min)
    {
        min=array[j];
    }
}

Console.WriteLine(String.Join(",", array));
Console.WriteLine($"Максимальное число массива равно = {max}");
Console.WriteLine($"Минимальное число массива равно = {min}");
Console.WriteLine($"Разница между максимальным и минимальным числом массива равна = {max-min}");
