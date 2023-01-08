/* 3. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз
встречается элемент входных данных. Значения элементов массива 0..9
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
void PrintMass(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine($"{i} meets: {array[i]}");
    Console.WriteLine();
}

int[] FrequencyDict(int[,] array)
{
    int[] new_array = new int[10];

    foreach (int item in array)
        new_array[item] += 1;

    return new_array;
}

int[,] array_1 = FillArrayTd(int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!));
PrintArrayTd(array_1);
Console.WriteLine();

int[] array_2 = FrequencyDict(array_1);
PrintMass(array_2);
