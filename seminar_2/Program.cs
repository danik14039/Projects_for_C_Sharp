//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = new Random().Next(10,100);
Console.WriteLine(num);

int dec = num/10;
int single = num%10;

if (dec>single)
{
    Console.WriteLine("Наибольшее число: "+ dec);
}
else
{
    Console.WriteLine("Наибольшее число: "+ single);
}
