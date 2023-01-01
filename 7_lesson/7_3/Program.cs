/* Задайте двумерный массив. Найдите сумму элементов на главной диагонали.
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

int SumDiagArrayTd(int[,] array)
{
    int raw = array.GetLength(0);
    int col = array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
            if (i == j)
                sum = sum + array[i,j];  
    }
    return sum;
}

int[,] array_1 = FillArrayTd(int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!));
PrintArrayTd(array_1);
Console.WriteLine();
Console.WriteLine(SumDiagArrayTd(array_1));