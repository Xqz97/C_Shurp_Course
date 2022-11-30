// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите первое число: ");

int  num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int  num2 = int.Parse(Console.ReadLine());

if (num2 == num1*num1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}