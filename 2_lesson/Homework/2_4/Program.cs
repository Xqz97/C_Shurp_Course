// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string HoliDay(int num)
{
    if (num == 6 || num == 7)
    {
        return "Это выходной день";
    }
    else if (num >= 1 && num <= 5)
    {
        return "Это НЕ выходной день";
    }
    else
    {
        return "Введенное число не является днем недели";
    }
}

Console.WriteLine("Введите номер дня недели: ");
int num =  int.Parse(Console.ReadLine());

Console.WriteLine(HoliDay(num));