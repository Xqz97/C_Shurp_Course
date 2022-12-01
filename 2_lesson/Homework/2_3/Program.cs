// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string ThirdNum(int num)
{
	if(num > 99)
    {
        int numindex = 2; // индекс нужной цифры
        int num1 = num.ToString()[numindex] - '0';
        return $"Третья цифра равна: {num1}";
    }	
    else
        return "Третьей цифры нет!";
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(ThirdNum(num));