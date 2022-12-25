//

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

int RangeNums(int[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 99 & array[i] >= 10)
        {
            j++;
        }
    }
    return j;
}

int[] array_1 = FillArray(int.Parse(Console.ReadLine()!));
PrintArray(array_1);
Console.WriteLine(RangeNums(array_1));
