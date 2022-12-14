/* Напишите программу замены элементов массива: 
положительные элементы замените на соответствующие отрицательные м наоборот.
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
array[i] = new Random().Next(from, to);
return array;
}
 
int[] ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i]*(-1);
    }
    return array;
}

int[] array_1 = FillArray(int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()));
PrintArray(array_1);
PrintArray(ChangeArray(array_1));
