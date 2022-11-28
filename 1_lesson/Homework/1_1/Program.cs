// Задача 1: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b){
    Console.WriteLine("Первое число больше");
}
else if (a < b)
{
    Console.WriteLine("Второе число больше");
}
else
{
    Console.WriteLine("Числа равны");
}