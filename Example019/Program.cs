Console.WriteLine("Введите число:");
string number = Console.ReadLine();

int sum = 0;
for (int i = 0; i < number.Length; i++)
{
  string str =Convert.ToString(number[i]);
  int num1 = Convert.ToInt32(str);
  
  sum = sum + num1;
}
Console.WriteLine(sum);