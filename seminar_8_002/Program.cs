Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows,rows];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,10); 
        Console.Write(array[i,j]+ " ");
    }
    Console.WriteLine();
}
int [,] arraynew = new int [rows,rows];
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        arraynew[i,j] =array[j,i]; 
        Console.Write(arraynew[i,j]+ " ");
    }
    Console.WriteLine();
}