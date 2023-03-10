//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Enter number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1%num2==0)
{
    Console.WriteLine("Кратны");
}
else
{
    Console.WriteLine($"Не кратны, остаток от деления равен {num1%num2}");
}