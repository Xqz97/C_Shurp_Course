/* Напишите программу, которая перевернёт одномерный массив
 (последний элемент будет на первом месте, а первый - на последнем и т.д.)
*/

int InputData(string message)
{
Console.Write(message);
var s = Console.ReadLine();
int a = s == null ? 0 : int.Parse(s);
return a;
}


void Trang(int a, int b, int c)
{
   if (a < (b + c) & b < (a + c) & c < (a + b))
   {
    Console.WriteLine($"Треугольник со сторонами a={a}, b={b}, c={c} может существовать");
   }
   else
   Console.WriteLine($"Треугольник со сторонами a={a}, b={b}, c={c} НЕ может существовать");
}

Console.WriteLine ("Введите стороны треугольника: ");
int a = InputData("Введите a = ");
int b = InputData("Введите b = ");
int c = InputData("Введите c = ");

Trang(a, b, c);



