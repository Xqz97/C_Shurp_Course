/*// Напишите программу, которая перевернёт одномерный массив
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
*/

void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] FillArray(int size, int from, int to)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(from,to);
    return array;
}


int[] RevArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size / 2; i++)
    {
        // Принцип кортежа, меняем местами значения. Не нужна третья переменная.
        (array[i], array[size - 1 - i]) = (array[size - 1 - i], array[i]);

    }
    return array;
}

int[] array_1 = FillArray(int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!),
                          int.Parse(Console.ReadLine()!));
PrintArray(array_1);
PrintArray(RevArray(array_1));

