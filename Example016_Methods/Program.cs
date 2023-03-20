string message = "Напомним, перед выборами в стране упростили процедуру регистрации политических партий." + 
"В частности, регистрационный порог снижен в четыре раза, с 20 до 5 тысяч членов." + 
"С 600 до 200 человек сократилась минимальная численность региональных представительств партий." +  
" К слову, процент прохождения партий в Мажилис в этот раз тоже снизили - с 7 до 5 процентов.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    for (int i=0; i<text.Length; i++)
    {
        if(text[i]==oldValue) result=result+$"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newMessage = Replace(message, '7','8');
Console.WriteLine(newMessage);
Console.WriteLine();
newMessage = Replace(newMessage, ' ', '|');
Console.WriteLine(newMessage);
Console.WriteLine();
newMessage = Replace(newMessage, 'п', 'П');
Console.WriteLine(newMessage);