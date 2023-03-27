// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = 0;
int num2 = 1;

int num3 = 1;
Console.WriteLine(num1);
Console.WriteLine(num2);
for (int i = 2; i < num; i++)
{
    num3 = num1 + num2;
    Console.WriteLine(num3);
    num1 = num2;
    num2 = num3;
}


//  Задача 45: Напишите программу, которая будет создавать копию 
//  заданного массива с помощью поэлементного копирования.

// int[] array = new int[]{6,7,321,15,0,7};
// int[] result = new int[array.Length];

// for (int i = 0; i < array.Length; i++)
// {
//    result[i] =array[i];
// }

// for (int i = 0; i < result.Length; i++)
// {
//    System.Console.WriteLine(result[i]);
// }
