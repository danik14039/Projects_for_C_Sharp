// . Напишите программу, которая на вход принимает одно число 
// (N), а на выходе показывает все целые числа в промежутке от -N до N


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int numberNeg = -1*number;
while(numberNeg<=number)
{
    Console.WriteLine(numberNeg);
    numberNeg=numberNeg+1;
}