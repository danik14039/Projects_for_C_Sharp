// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

while (true)
{
    Console.WriteLine("Введите пятизначное число");
    string num = Console.ReadLine();
    
    if(num.Length!=5)
    {
        Console.WriteLine("Это не пятизначное число");
    }
    if(num.Length==5)
    {
        char first = num[0];
        char second = num[1];
        char fourth = num[3];
        char fifth = num[4];
        if((first==fifth)&&(second==fourth))
        {
            Console.WriteLine("Это число является палидромом");
            break;
        }
        else
        {
            Console.WriteLine("Это число не является палидромом");
            break;
        }
    }   
}
