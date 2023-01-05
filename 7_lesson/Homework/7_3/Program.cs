/* Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом
столбце.
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

void AverArrayColTd(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    double resalt;
    for (int i = 0; i < col; i++)
    {
        resalt = 0;
        for (int j = 0; j < row; j++)
            resalt = resalt + array[j, i];
        Console.Write($"{Math.Round(resalt / row, 2)}; ");
    }
}

int[,] array_1 = FillArrayTd(int.Parse(Console.ReadLine()!),
                             int.Parse(Console.ReadLine()!),
                             int.Parse(Console.ReadLine()!),
                             int.Parse(Console.ReadLine()!));
PrintArrayTd(array_1);
AverArrayColTd(array_1);



