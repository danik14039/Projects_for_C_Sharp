// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
double count=number;

double PrintNumber(double result)
{
    
    if (count==1) {return count;}
    Console.Write(count+" ");
    count--;
    return (PrintNumber(result));
    
}
// PrintNumber(number);
Console.WriteLine(PrintNumber(number));


