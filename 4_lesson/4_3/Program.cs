// Создать массив из 8 чисел, заполненный рандомно 0 и 1.

int InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

void FillArray (int[] a)
{
    int n = a.Length;
    int index = 0;
    while (index < n)
    {
        a[index] = new Random().Next(0,2);
        index++;
    }
}

void PrintArray(int[] b)
{
    int l = b.Length;
    int i = 0;
    while (i < l)
    {
        Console.Write(b[i]);
        i++;
    }
}

int[] c = new int[8];
FillArray(c);
PrintArray(c);