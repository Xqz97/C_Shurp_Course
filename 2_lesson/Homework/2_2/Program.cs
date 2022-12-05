// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

string DelSecondNum(int num)
{
    Console.WriteLine(num);
    int firstnum = num / 100;
    int thirdnum = num % 10;
    return firstnum.ToString() + thirdnum.ToString();
}

int num = new Random().Next(100,999);
Console.WriteLine(DelSecondNum(num));