// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt (string message)
{
    Console.WriteLine(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int Power(int num1, int num2)
{
    int power = 1;
    for(int i = 0; i<num2; i++)
    {
        power = power*num1;
    }
    return power;
}

bool ValidateNum2(int num2)
{
    if (num2<0)
    {
        Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int number1 = Prompt("Enter number 1: ");
int number2 = Prompt("Enter number 2: ");
if(ValidateNum2(number2))
{
    Console.WriteLine($"Число {number1} в степени {number2} равно {Power(number1,number2)}");
}