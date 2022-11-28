// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int i = 0;

if ( a <= 1)
{
    Console.WriteLine ("Введенный диапазон не включает четные числа"); 
}
else if (a % 2 == 0)
{
    while ( i < a)
        {
             Console.Write($"{i+2}, ");
             i += 2; 
        }
}
else if (a % 2 > 0)
{
    a -= 1; 
    while ( i < a)
        {
            Console.Write($"{i+2}, ");
            i += 2; 
        }
}
