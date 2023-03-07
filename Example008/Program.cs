//Напишите программу, которая будет выдавать название дня недели по заданному номеру

Console.WriteLine("Введите число от 1 до 7");
int number1 = Convert.ToInt32(Console.ReadLine());

if(number1==1)
{
    Console.WriteLine("Monday");
}
else if(number1==2)
{
    Console.WriteLine("Tuesday");
}
else if(number1==3)
{
    Console.WriteLine("Wednesday");
}
else if(number1==4)
{
    Console.WriteLine("Thursday");
}
else if(number1==5)
{
    Console.WriteLine("Friday");
}
else if(number1==6)
{
    Console.WriteLine("Saturday");
}
else if(number1==7)
{
    Console.WriteLine("Sunday");
}

else
{
    Console.WriteLine("Такого дня недели у нас нет");
}