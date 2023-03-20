// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введи четверь");
int number = Convert.ToInt32(Console.ReadLine());

switch(number)
{
    case 1:
    {
        Console.Write("X>0 и Y>0");
        break;
    }
    case 2:
    {
        Console.Write("X<0 и Y>0");
        break;
    }
    case 3:
    {
        Console.Write("X<0 и Y<0");
        break;
    }
    case 4:
    {
        Console.Write("X>0 и Y<0");
        break;
    }

    default:
    {
        Console.Write("Такой четверти нет");
        break;
    }
    
}