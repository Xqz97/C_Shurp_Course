/* Написать программу, которая выводит сумму цифр из введенного числа с ипользованием рекурсии.
*/


int InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

int Num(int n)
{

    if (n == 0) return 0;
    return Num (n / 10) + n % 10;
}
int n = InputData("Введите N: ");
Console.WriteLine(Num(n));
