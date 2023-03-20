int Text(string message)
{
    Console.WriteLine(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int [] GenerateArray(int Length, int minValue, int maxValue)
{
    int [] array = new int[Length];
    for(int i=0; i<Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]} ]");
}

int length = Text("Введите длину массива: ");
int min = Text("Введите начальное значение массива: ");
int max = Text("Введите максимальное значение массива: ");
int [] array = GenerateArray(length, min, max);
PrintArray(array);

