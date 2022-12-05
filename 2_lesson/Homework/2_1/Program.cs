// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

string SecondNum(int num)
{
        num /= 10;
        num %= 10;
        return $"Второе число: {num}";
}

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(SecondNum(num));
