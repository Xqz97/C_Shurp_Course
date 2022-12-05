/*  Задача 1: Напишите программу, которая принимает на вход пятизначное 
    число и проверяет, является ли оно палиндромом.
    14212 -> нет 
    23432 -> да 
    12821 -> да
*/

int InputData(string message)
{
Console.Write(message);
var s = Console.ReadLine();
int a = s == null ? 0 : int.Parse(s);
return a;
}

void Polindrom(int num)
{
    if ((num % 10 == num / 100000) || (num % 100 == num / 1000) || (num % 1000 == num / 1000))
    {
        Console.WriteLine($"Число {num} - это полиндром");
    }
    else    
    Console.WriteLine($"Число {num} - это НЕ полиндром");
}

int num = InputData("Введите пятизначное число: ");

Polindrom(num);

