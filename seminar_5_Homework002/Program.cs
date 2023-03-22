// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int [5];
int sum = 0;

for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(0, 15);
    if (i%2==1)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine(String.Join(",", array));
Console.WriteLine(sum);