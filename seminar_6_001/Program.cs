// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1=num;
int i = 0;
while(num1>0)
{
    num1=num1/2;
    i++;
}
int[] array = new int[i];

for (int j = 0; j < i; j++)
{
    array[i-j-1]=num%2;
    num=num/2;
}
    
Console.WriteLine(String.Join("",array));


Console.WriteLine("Number = ");
int n = Convert.ToInt32(Console.ReadLine());
string counter = "";

while (n >= 1)
{
   counter = (n % 2) + counter;
   n = n / 2;
}
Console.WriteLine(counter);