/* Найдите произведение пар чисел в одномерном массиве.
 Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
*/

void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] FillArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1,10);
    return array;
}

int[] MultArray(int[] array)
{
    int size = array.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_array = new int[flex_size];

    for (int i = 0; i < size / 2; i++)
        new_array[i] = array[i] * array[size - i - 1];

    if (new_array[flex_size - 1] == 0)
        new_array[flex_size - 1] = array[flex_size - 1];
    return new_array;
}

int[] array_1 = FillArray(int.Parse(Console.ReadLine()!));
PrintArray(array_1);
Console.WriteLine(MultArray(array_1));




