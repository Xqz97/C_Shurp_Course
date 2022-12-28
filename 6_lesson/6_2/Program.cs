// 2. Напишите программу, которая будеn преобразовывать десятичное число в двоичное.

int InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

string TranBinary(int n)
{
    string result = "";

    while (n > 0)
    {
        result = n % 2 + result;
        n /= 2;
    }
    return result;
}

Console.WriteLine(TranBinary(InputData("Введите число: ")));