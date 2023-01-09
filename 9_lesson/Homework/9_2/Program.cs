/*
Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

int Num(int m, int n)
{
    if (m > n) return 0;
    return Num(m + 1, n) + m;
}
int m = InputData("Введите M: ");
int n = InputData("Введите N: ");
Console.WriteLine(Num(m,n));

