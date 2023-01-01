/*  Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и
вертикали, или напишите, что такого элемента нет.
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

string FindIndexArrayTd(int[,] array, int n)
{
    int raw = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
            if (array[i, j] == n)
                return $"[{i + 1},{j + 1}]";
    }
    return $"Элемент не найден.";
}

int[,] array_1 = FillArrayTd(int.Parse(Console.ReadLine()!),
                             int.Parse(Console.ReadLine()!),
                             int.Parse(Console.ReadLine()!),
                             int.Parse(Console.ReadLine()!));
PrintArrayTd(array_1);
Console.WriteLine("Введите число для поиска: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(FindIndexArrayTd(array_1, n));