// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool b = false;

int [] array = new int [8];
for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(0,5);
    if (num ==array[i])
    {
        b = true;
    }
}

if(b==true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
Console.WriteLine(String.Join(" ", array));




