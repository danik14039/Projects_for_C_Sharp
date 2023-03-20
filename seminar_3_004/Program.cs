// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите координаты 1 точки X, Y : ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты 2 точки X, Y : ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double c = Math.Round((Math.Sqrt((Math.Pow((x2-x1),2))+Math.Pow((y2-y1),2))),2);
Console.WriteLine(c);