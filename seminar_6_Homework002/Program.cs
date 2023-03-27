Console.WriteLine("Введите коэффициенты k1, b1 для первой прямой y=k1x+b1");
int k1 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите коэффициенты k2, b2 для второй прямой y=k2x+b2");
int k2 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());

double y = (k1*b2 - k2*b1)/(k1 - k2);
double x = (y - b1)/k1;

Console.WriteLine(y);

Console.WriteLine($"Координаты пересечения двух прямых ({x}:{y})");