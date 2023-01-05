/* 2. Задайте двумерный массив. Напишите программу, которая 
заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

void ChangeRawToColTd(int[,] array)
{
    int raw = array.GetLength(0);
    int col = array.GetLength(1);
    if (raw == col)
    {
        for(int i = 0; i < raw; i++)
        {
            for(int j = 0; j < i; j++)
            {
               (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
            }
        }
    }
    else
    {
        Console.WriteLine("Матрица не квадратная");
    }
}

int[,] array_1 = FillArrayTd(int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!));
PrintArrayTd(array_1);
Console.WriteLine();
ChangeRawToColTd(array_1);
PrintArrayTd(array_1);