Console.WriteLine("Enter number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1==num2*num2)
{
    Console.WriteLine(num1 + " является квадратом " + num2);
}
else if  (num2==num1*num1)
{
    Console.WriteLine(num2 + " является квадратом " + num1);
}
else
{
    Console.WriteLine("Не являются квадратом");
}