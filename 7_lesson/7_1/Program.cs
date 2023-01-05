// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле A:m+n.

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

int[,] FillArrayTd(int raw, int col)
{
    int[,] array = new int[raw, col];

    for (int i = 0; i < raw; i++)
        for (int j = 0; j < col; j++)

            array[i, j] = i + j;
    return array;
}

int[,] array_1 = FillArrayTd(int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!));
PrintArrayTd(array_1);
