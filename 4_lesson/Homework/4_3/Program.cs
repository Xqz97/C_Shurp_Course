// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray (int[] a)
{
    int n =  a.Length;
    for(int i = 0; i < n; i++)
    {
        a[i] = Convert.ToInt32(Console.ReadLine());
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
