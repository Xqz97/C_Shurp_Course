/* Задайте массив вещественных чисел. 
   Найдите разницу между максимальным и минимальным элементов массива.
*/

double[] FillArray (int size)
{
    double[] array = new double [size];
    Random elements = new Random ();
    
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = Math.Round(elements.NextDouble()*10, 2);
        Console.Write($"{array [i]} ");
    }
    return array;
}

void DifMinMax (double[] array)
{
    double max = array [0];
    double min = array [1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > max) 
        {
            max = array[i];
        }
        else if (array [i] < min)
        {
            min = array [i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальное число: {min} | Максимальное число: {max}");
    Console.WriteLine($"Разница равна: {Math.Round((max - min), 2)}");
}

double [] array_1 = FillArray (int.Parse(Console.ReadLine()!));
DifMinMax(array_1);