/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

int InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

void Num(int m, int n)
{

    if (m > n) return;
    if (m % 2 != 0) m = m + 1;
    Console.Write($"{m} ");
    Num(m + 2, n);
}

int m = InputData("Введите m: ");
int n = InputData("Введите n: ");
Num(m,n);
