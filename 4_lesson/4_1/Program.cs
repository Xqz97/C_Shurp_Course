// 1. Напишите программу, которая принимаетна вход число и выдаёт количество цифр в числе.
int InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

int AmouNum(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        int i = 0;
        while (n > 0)
        {
            n = n / 10;
            i++;
        }
        return i;
    }
}

int n = InputData("Введите число: ");
Console.WriteLine(AmouNum(n));
