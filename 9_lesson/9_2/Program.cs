/* Напишите программу, которая выдаст с помощью рекурсии все числа от M до N.
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
    if (m == (n + 1)) return;
    Console.Write($" {m}");
    Num(m + 1, n);
}
int m = InputData("Введите M: ");
int n = InputData("Введите N: ");
Num(m, n);

