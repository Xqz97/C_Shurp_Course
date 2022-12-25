/* 1. Задайте массив заполненный случайными  положительными трёхзначными числами. 
Напишите программу,  которая покажет количество чётных чисел в массиве. */

void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] FillArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100,1000);
    return array;
}

int EvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array_1 = FillArray(int.Parse(Console.ReadLine()!));
PrintArray(array_1);
Console.WriteLine(EvenNum(array_1));