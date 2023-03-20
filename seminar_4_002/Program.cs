// Напишите программу, принимает на вход число и показывает количество цифр в числе
// First variant
// Console.WriteLine("Enter number: ");
// string num = Console.ReadLine();
// Console.WriteLine(num.Length);

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

while(num>0)
{
    num/=10;
    count++;
}
Console.WriteLine($"Number length equal to = {count}");
