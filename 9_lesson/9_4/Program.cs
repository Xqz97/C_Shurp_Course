/* Создать программу, в которой пользователь вводит два числа А и В, и число А возводится в степень числа В,
с помощью рекурсии.
*/


int InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

int Degree(int a, int b)
{
    if (b == 0) return 1;
    return Degree (a, b - 1) * a;
}

int a = InputData("Введите a: ");
int b = InputData("Введите b: ");
Console.WriteLine(Degree(a,b));
