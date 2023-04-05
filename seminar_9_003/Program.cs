// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine("Введите число M");
// int n =int.Parse(Console.ReadLine());
// int result = GetResult(n);
// Console.Write($"{n} -> {result}");


// int GetResult(int n)
// {
//     if (n == 0) return 0;
//     else
//     {
        
//         GetResult(n - 1);
//         return n%10 + GetResult(n/10);
//     }
// }


Console.WriteLine("Введите число M");
int a  =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int b =int.Parse(Console.ReadLine());

int GetResult(int a, int b)
{
    if (b == 1) return a;
    return a*GetResult(a, b-1);
    
}
Console.WriteLine(GetResult(a,b));