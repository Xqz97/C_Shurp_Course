/* Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. */


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
 
string SearchNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return "YES";
        }
    }
    return "No";
}

int[] array_1 = FillArray(int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()));
PrintArray(array_1);
Console.WriteLine(SearchNum(array_1,  int.Parse(Console.ReadLine())));
