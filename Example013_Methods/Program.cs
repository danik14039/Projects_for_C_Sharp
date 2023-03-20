// Виды методов
// Вид№1 ничего не принимает, ничего не возвращает

void Method1()
{
    Console.WriteLine("My text...");
}
// Method1();

// Вид №2 Что-то принимает, ничего не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg:"Text message...");

void Method21(string msg, int count)
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
        
    }
}
// Method21(msg:"Text message 2 ...", count: 2);

// Вид №3 Ничего не принимают, что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид №4 Что-то принимают, что-то возвращают

string Method4(int count, string text)
{
    int i=0;
    string result = String.Empty;

    while(i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);