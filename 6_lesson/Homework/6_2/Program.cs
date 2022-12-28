/*  Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
    задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    double a = s == null ? 0 : double.Parse(s);
    return a;
}

void CrossPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x) + b1;
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты: ({x};{y})");
}

double b1 = InputData("Введите b1: ");
double k1 = InputData("Введите k1: ");
double b2 = InputData("Введите b2: ");
double k2 = InputData("Введите k2: ");
CrossPoint(b1, k1, b2, k2);