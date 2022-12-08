// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

int Sum(int n)
{
    int i = 1;
    int results = 0;
    while (i <= n)
    {
        results += i;
        i++;
    }
    return results;
}

int n = InputData("Введите число n: ");
Console.WriteLine(Sum(n));
