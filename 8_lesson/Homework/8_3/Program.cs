/*3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] MultArrayTd(int[,] array_1, int[,] array_2)
{
    int raw = array_1.GetLength(0);
    int col = array_1.GetLength(1);

    int[,] res_array = new int[raw, col];

    if (col != array_2.GetLength(0)) 
        return res_array;
    else if (col == array_2.GetLength(0))
        res_array = new int[raw, raw];

    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < raw; j++)
        {
            for (int k = 0; k < col; k++)
                res_array[i, j] += array_1[i, k] * array_2[k, j];
        }
    }
    return res_array;
}

int[,] array_1 = FillArrayTd(int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!));

int[,] array_2 = FillArrayTd(int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!));
PrintArrayTd(array_1);
Console.WriteLine();
PrintArrayTd(array_2);
Console.WriteLine();
PrintArrayTd(MultArrayTd(array_1, array_2));