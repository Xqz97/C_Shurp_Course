/* Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/
int InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

int Sum (int n)
{

 int j = Convert.ToString(n).Length;
    int inter = 0;
    int result = 0;

    for (int i = 0; i < j; i++)
    {
      inter = n - n % 10;
      result = result + (n - inter);
      n = n / 10;
    }
   return result;
  }
  
  int n =  InputData("Введите число: ");
  Console.WriteLine(Sum(n));