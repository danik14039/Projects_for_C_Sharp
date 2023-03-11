// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int num = new Random().Next(10,200);
Console.WriteLine(num);
string str = Convert.ToString(num);

if (str.Length<3)
{
    Console.WriteLine("Третьего цифры нет");
}
else
{
    char thirdChar = str[2];
    Console.WriteLine(thirdChar);
}