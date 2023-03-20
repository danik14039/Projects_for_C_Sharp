Console.WriteLine("Введите число:");
int number =Convert.ToInt32(Console.ReadLine());
int count = 1000;

while (number/count!=0)
{
    count=count*10;
}
if(number/100==0)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    Console.WriteLine($"Третья цифра равна {(number%(count/100))/(count/1000)}");
}