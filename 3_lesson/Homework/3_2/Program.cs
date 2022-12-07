/*  Задача 2: Напишите программу, которая принимает на вход координаты 
    двух точек и находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84 
    A (7,-5, 0); B (1,-1,9) -> 11.53
*/ 

int InputData(string message)
{
Console.Write(message);
var s = Console.ReadLine();
int a = s == null ? 0 : int.Parse(s);
return a;
}

double Distance(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
    result = Math.Round(result, 2);
    Console.Write($"A ({ax}, {ay}, {az}); B ({bx}, {by}, {bz}) -> {result}");
    return result;
}
Console.WriteLine ("Введите координаты точки A: ");
int ax = InputData("Введите аХ = ");
int ay = InputData("Введите аY = ");
int az = InputData("Введите aZ = ");
Console.WriteLine ("Введите координаты точки B: ");
int bx = InputData("Введите bX = ");
int by = InputData("Введите bY = ");
int bz = InputData("Введите bZ = ");
Distance(ax, ay, az, bx, by, bz);