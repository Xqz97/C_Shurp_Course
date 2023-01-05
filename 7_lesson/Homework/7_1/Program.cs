/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
*/

void PrintArrayTd(double[,] array)
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

double[,] FillArrayTd(int raw, int col)
{
    double[,] array = new double[raw, col];
    Random elements = new Random();

    for (int i = 0; i < raw; i++)
        for (int j = 0; j < col; j++)
            array[i, j] = Math.Round(elements.NextDouble() * 10, 2);
    return array;
}

double[,] array_1 = FillArrayTd(int.Parse(Console.ReadLine()!),
                                int.Parse(Console.ReadLine()!));
PrintArrayTd(array_1);