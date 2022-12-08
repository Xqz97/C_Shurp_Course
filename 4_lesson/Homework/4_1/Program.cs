/* Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
Без модуля Math, используем цикл for. */

int InputData(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

int Step(int A, int B)
{
  int result = 1;
  for(int i=1; i <= B; i++)
  {
    result = result * A;
  }
    return result;
}

int A = InputData("Введите число А: ");
int B = InputData("Введите число B: ");
Console.WriteLine(Step(A,B));


