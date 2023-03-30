// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициенты k1, b1 для первой прямой y=k1x+b1");
int k1 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите коэффициенты k2, b2 для второй прямой y=k2x+b2");
int k2 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());

double y = (k1*b2 - k2*b1)/(k1 - k2);
double x = (y - b1)/k1;

Console.WriteLine($"Координаты пересечения двух прямых ({x}:{y})");