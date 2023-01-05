/* Задайте двумерный массив. Создайте программу, которая поменяет местами первую и последнюю строку в массиве. */

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

void ChangeRawTd(int[,] array)
{
    int raw = array.GetLength(0);
    int col = array.GetLength(1);

    for (int j = 0; j < col; j++)
    {
        (array[0, j], array[raw - 1, j]) = (array[raw - 1, j], array[0, j]);
    }
}

int[,] array_1 = FillArrayTd(int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!));
PrintArrayTd(array_1);
Console.WriteLine();
ChangeRawTd(array_1);
PrintArrayTd(array_1);
