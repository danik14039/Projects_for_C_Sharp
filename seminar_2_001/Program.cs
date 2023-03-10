int num = new Random().Next(100,999);
Console.WriteLine(num);
int a = num/100;
int b = a/10;
int c = num%10;
int result = a*10+c;
Console.WriteLine(result);