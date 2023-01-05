/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
*/

void PrintArrayTd(int[,] array)
{
    int raw = array.GetLength(0);
    int col = array.GetLength(1);

    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] FillArrayTd(int raw, int col, int from, int to)
{
    int[,] array = new int[raw, col];

    for (int i = 0; i < raw; i++)
        for (int j = 0; j < col; j++)

            array[i, j] = new Random().Next(from, to);
    return array;
}

string FindIndexArrayTd(int[,] array, int k, int z)
{
    int raw = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
            if (i == (k - 1) && j == (z - 1))
                return $"Искомое число {array[i, j]}";
    }
    return $"С данными индексами элемента в массиве нет";
}

int[,] array_1 = FillArrayTd(int.Parse(Console.ReadLine()!),
                             int.Parse(Console.ReadLine()!),
                             int.Parse(Console.ReadLine()!),
                             int.Parse(Console.ReadLine()!));
PrintArrayTd(array_1);
Console.WriteLine("Введите позиции элемента в двумерном массиве: ");
int k = int.Parse(Console.ReadLine()!);
int z = int.Parse(Console.ReadLine()!);
Console.WriteLine(FindIndexArrayTd(array_1, k, z));
