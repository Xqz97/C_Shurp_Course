/* Создать программу с помощью рекурсии, выводящую числа от 1 до N.
*/

int InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
void Num(int a)
{
    if (a == 0) return;
    Num(a - 1);
    Console.Write($" {a}");
}

Num(InputData("Введите число a: "));
