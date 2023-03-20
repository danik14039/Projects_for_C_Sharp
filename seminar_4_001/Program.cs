// Задача 24: Напишите программу, которая принимает
// на вход число (А) и выдает сумму числел от 1 до А

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumNum()
{
    int sum = 0;
    int i=0;
    
    while(i<num)
    {
        i++;
        sum = sum + i;
    }
    return sum;
}

// int number = GetSumNum();
// Console.WriteLine(number);
Console.WriteLine(GetSumNum());