/*Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях. 
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
        array[i] = new Random().Next();
    return array;
}

int SumEvenPosNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
       sum = sum + array[i];
    }
    return sum;
}

int[] array_1 = FillArray(int.Parse(Console.ReadLine()!));
PrintArray(array_1);
Console.WriteLine(SumEvenPosNum(array_1));
