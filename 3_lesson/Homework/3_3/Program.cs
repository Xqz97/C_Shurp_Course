/*  Задача 3: Напишите программу, которая принимает на вход число (N) и 
    выдаёт таблицу кубов чисел от 1 до N. 
    3 -> 1, 8, 27.
    5 -> 1, 8, 27, 64, 125
*/ 

int InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
void CubeTab(int N)
{
    int i = 1;
    double result;
    while (i <= N )
    {
            result = Math.Pow(i,3);
            Console.Write($"{result} | ");
            i++;
    }
}

int N = InputData("Введите число N: ");
CubeTab(N);


