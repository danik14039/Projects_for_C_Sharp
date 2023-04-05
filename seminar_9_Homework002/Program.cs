// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter number M");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number N");
int N = int.Parse(Console.ReadLine());
int sum = 0;

int GetSum(int a, int b)
{
    if(a>b) return sum;
    
    sum = sum+a;
    a++;
    return GetSum(a,b);
    
}

Console.WriteLine(GetSum(M,N));