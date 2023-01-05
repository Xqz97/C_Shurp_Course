/* 2. Задайте прямоугольный двумерный массив. Напишите программу, 
 которая будет находить строку с наименьшей суммой элементов.
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

void FindLowSum(int[,] array)
{
    int raw = array.GetLength(0);
    int col = array.GetLength(1);
    int index = 0;
    int sum = int.MaxValue;
    for (int i = 0; i < raw; i++)
    {   
        int inter = 0;
        for (int j = 0; j < col; j++)
            inter = inter + array[i,j];           
        if ( inter < sum)
        {
            sum = inter;
            index = i;
        }
    }
    Console.Write($"Строка с наименьшей суммой элементов находится на позиции: {index + 1}");
}

int[,] array_1 = FillArrayTd(int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!));
PrintArrayTd(array_1);
Console.WriteLine();
FindLowSum(array_1);
