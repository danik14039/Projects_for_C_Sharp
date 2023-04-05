// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число");
int num =int.Parse(Console.ReadLine());

int count =1;

int PrintNumber()
{
  if(count>num)
  {
    return count;
  }
 
  Console.Write(count+" ");

  count++;

  return (PrintNumber());
}

PrintNumber();
