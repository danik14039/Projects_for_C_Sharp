// Console.WriteLine("Enter number: ");
// string num = Console.ReadLine();
// char [] array = new char [num.Length];
// int sum = 0;

// for(int i=0; i<num.Length; i++)
// {
//     array[i] = num[i];
// }

// for (int count=0; count<array.Length; count++)
// {
//     sum = sum + array[count];
// }

// Console.Write(sum);

Console.WriteLine("Enter number: ");
string num = Console.ReadLine();
char [] array = num.ToCharArray();
int sum = 0;
for (int i=0; i<array.Length; i++)
{
    sum = sum + array[i];
}
Console.WriteLine(sum);