// Не используя рекурсию, выведите первые N чисел Фибоначчи.Первые два числа Фибоначчи: 0 и 1.


int InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

void Fibo (int n)
{
int a = 0, b = 1;

for (int i = 0; i < n; i++)
{
Console.Write($"{a} ");
(a, b) = (b, a+b);
}
}

Fibo(InputData("Введите n: "));

//Альтернативное решение через рекурсию.

/*
void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] FiboArray(int n)
{
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < n; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

PrintArray(FiboArray(InputData("Введите n: ")));

*/
