// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = 0;
Console.WriteLine("Какое количество цифр вы хотите ввести: ");
int len = int.Parse(Console.ReadLine());

int [] arr = new int [len];

for(int i=0; i<len; i++)
{
    Console.WriteLine("Введите число отрицательное или положительное: ");
    int num = Convert.ToInt32(Console.ReadLine());
    arr[i] = num;
    if(arr[i]>0)
    {
        count++;
    }
}

Console.WriteLine($"Вы ввели следующий ряд цифр {String.Join(",", arr)} из них больше нуля {count} " );